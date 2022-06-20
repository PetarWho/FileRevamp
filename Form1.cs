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
        #region fields

        bool error = false;
        Dictionary<string, string> fileNamesPaths = new Dictionary<string, string>();

        #endregion
        public Form1()
        {
            InitializeComponent();
        }


        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFiles(folderBrowserDialog1);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFiles(openFileDialog1);
        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fileList.SelectedItems == null)
            {
                singleCheck.CheckState = CheckState.Unchecked;
                return;
            }

            try
            {
                nameBox.Text = fileList.SelectedItems[0].Text;
                extensionBox.Text = fileList.SelectedItems[0].SubItems[1].Text
                    .Substring(fileList.SelectedItems[0].SubItems[1].Text.LastIndexOf('.'));
                singleCheck.CheckState = CheckState.Checked;
            }
            catch (Exception)
            {
                singleCheck.CheckState = CheckState.Unchecked;
                nameBox.Text = String.Empty;
            }
        }

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
            else if (extensionBox.Text.Trim().Length <=1 || !extensionBox.Text.Trim().Contains('.'))
            {
                MessageBox.Show("Invalid extension format!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        void OpenFiles(CommonDialog dialog)
        {
            if (!(dialog is FolderBrowserDialog || dialog is OpenFileDialog))
            {
                MessageBox.Show("Wrong file dialog", "Error", MessageBoxButtons.OK);
                return;
            }

            if (dialog is OpenFileDialog)
            {
                (dialog as OpenFileDialog).InitialDirectory = "Documents";
                (dialog as OpenFileDialog).Filter = "All Files (*.*)|*.*";
                (dialog as OpenFileDialog).RestoreDirectory = true;
                (dialog as OpenFileDialog).Multiselect = true;
                (dialog as OpenFileDialog).Title = "Open file";
                (dialog as OpenFileDialog).FileName = "";
            }

            using (dialog)
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    bool duplicate = false;
                    foreach (var item in (dialog is FolderBrowserDialog ? Directory.GetFiles(folderBrowserDialog1.SelectedPath) : openFileDialog1.FileNames).OrderBy(x => x))
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
                    extensionBox.Text = fileList.Items[0].SubItems[1].Text
                        .Substring(fileList.Items[0].SubItems[1].Text.LastIndexOf('.'));
                    if (duplicate) MessageBox.Show("Some files were already included, so they got skipped.", "Duplicate files", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void ResetApp()
        {
            nameBox.Text = String.Empty;
            extensionBox.Text = String.Empty;
            deleteCheck.CheckState = CheckState.Unchecked;
            replaceIfExistsCheck.CheckState = CheckState.Unchecked;
            singleCheck.CheckState = CheckState.Unchecked;
            extensionCheck.CheckState = CheckState.Unchecked;
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
            string fileExtension = extensionBox.Text.Trim();

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
                if (this.fileList.SelectedIndices.Count > 0)
                    for (int i = 0; i < this.fileList.SelectedIndices.Count; i++)
                    {
                        this.fileList.Items[this.fileList.SelectedIndices[i]].Selected = false;
                    }

                replaceBtn.Enabled = false;

                if (replaceBtn.Checked)
                {
                    replaceBtn.Checked = false;
                    insertFront.Checked = true;
                }
            }
        }

        private void extensionCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (extensionCheck.CheckState == CheckState.Checked)
            {
                extensionBox.Enabled = true;
            }
            else
            {
                extensionBox.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to clear the list?", "Clear List", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fileList.Items.Clear();
                fileNamesPaths.Clear();
                ResetApp();
            }
        }
    }
}
