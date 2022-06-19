using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileRevamp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, string> fileNamesPaths = new Dictionary<string, string>();
        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (folderBrowserDialog1)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    bool duplicate = false;
                    foreach (var item in Directory.GetFiles(folderBrowserDialog1.SelectedPath).OrderBy(x => x))
                    {
                        string name = Path.GetFileNameWithoutExtension(item);
                        if (fileNamesPaths.ContainsKey(name))
                        {
                            duplicate = true;
                            continue;
                        }
                        fileNamesPaths.Add(name, item);
                    }
                    LoadToListView(fileNamesPaths);
                    if (duplicate) MessageBox.Show("Some files were already included, so they got skipped.", "Duplicate files", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (openFileDialog1)
            {
                openFileDialog1.InitialDirectory = "Documents";
                openFileDialog1.Filter = "All Files (*.*)|*.*";
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.Multiselect = true;
                openFileDialog1.Title = "Open file";
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    bool duplicate = false;
                    foreach (var file in openFileDialog1.FileNames)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(file);
                        if (fileNamesPaths.ContainsKey(fileName))
                        {
                            duplicate = true;
                            continue;
                        }
                        fileNamesPaths.Add(fileName, file);
                    }
                    LoadToListView(fileNamesPaths);
                    if (duplicate) MessageBox.Show("Some files were already included, so they got skipped.", "Duplicate files", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fileList.SelectedItems == null) return;

            try
            {
                nameBox.Text = fileList.SelectedItems[0].Text;
            }
            catch (Exception) { }
        }

        bool error = false;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void revampBtn_Click(object sender, EventArgs e)
        {
            if (fileList.Items.Count == 0)
            {
                MessageBox.Show("No files found. Please, load some files!", "Empty list of files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (nameBox.Text.Trim() == "")
            {
                MessageBox.Show("Name cannot be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            using (folderBrowserDialog1)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (singleCheck.Checked)
                    {
                        var n = fileList.SelectedItems[0].SubItems[0];
                        var p = fileList.SelectedItems[0].SubItems[1];
                        ExportFile(n.Text, p.Text);
                        MessageBox.Show("Successfully exported files!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }

                    foreach (var file in fileNamesPaths)
                    {
                        ExportFile(file.Key, file.Value);
                        if (error)
                        {
                            error = false;
                            return;
                        }
                    }
                    MessageBox.Show("Successfully exported files!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
        void LoadToListView(Dictionary<string, string> dict)
        {
            foreach (var file in dict)
            {
                ListViewItem item = new ListViewItem(file.Key);
                item.SubItems.Add(file.Value);

                fileList.Items.Add(item);
            }
        }

        void ExportFile(string fileName, string filePath)
        {
            string newName = nameBox.Text;

            var folderPath = folderBrowserDialog1.SelectedPath;
            string fileExtension = filePath.Substring(filePath.LastIndexOf('.'));

            string temp = string.Empty;
            if (deleteCheck.Checked)
            {
                try
                {
                    if (replaceBtn.Checked)
                    {
                        temp = newName + fileExtension;
                        File.Copy(filePath, $"{folderPath}\\{newName}{fileExtension}", replaceIfExistsCheck.Checked);
                    }
                    else if (insertFront.Checked)
                    {
                        temp = newName + fileName + fileExtension;
                        File.Copy(filePath, $"{folderPath}\\{newName}{fileName}{fileExtension}", replaceIfExistsCheck.Checked);
                    }
                    else if (insertBack.Checked)
                    {
                        temp = fileName + newName + fileExtension;
                        File.Copy(filePath, $"{folderPath}\\{fileName}{newName}{fileExtension}", replaceIfExistsCheck.Checked);
                    }
                    File.Delete(filePath);
                }
                catch (IOException)
                {
                    MessageBox.Show($"File name \"{temp}\" already exists. Check replace option if you want to replace it or change the name!", "Name already exists!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                }
                return;
            }

            else
            {
                try
                {
                    if (replaceBtn.Checked)
                    {
                        temp = newName + fileExtension;
                        File.Copy(filePath, $"{folderPath}\\{newName}{fileExtension}", replaceIfExistsCheck.Checked);
                    }
                    else if (insertFront.Checked)
                    {
                        temp = newName + fileName + fileExtension;
                        File.Copy(filePath, $"{folderPath}\\{newName}{fileName}{fileExtension}", replaceIfExistsCheck.Checked);
                    }
                    else if (insertBack.Checked)
                    {
                        temp = fileName + newName + fileExtension;
                        File.Copy(filePath, $"{folderPath}\\{fileName}{newName}{fileExtension}", replaceIfExistsCheck.Checked);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show($"File name \"{temp}\" already exists. Check replace option if you want to replace it or change the name!", "Name already exists!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                }
                return;
            }
        }

        private void singleCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (singleCheck.CheckState == CheckState.Checked)
                replaceBtn.Enabled = true;
            else if (singleCheck.CheckState == CheckState.Unchecked)
            {
                replaceBtn.Enabled = false;
                if (replaceBtn.Checked)
                {
                    replaceBtn.Checked = false;
                    insertFront.Checked = true;
                }
            }
        }
    }
}
