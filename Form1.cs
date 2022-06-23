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

        List<MyFile> Files = new List<MyFile>();
        bool error = false;
        //Dictionary<string, string> fileNamesPaths = new Dictionary<string, string>();

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
                revampSingleCheck.CheckState = CheckState.Unchecked;
                clearSingleCheck.CheckState = CheckState.Unchecked;
                return;
            }

            try
            {
                MyFile currentFile = Files.Find(x=>x.Path == fileList.SelectedItems[0].SubItems[1].Text);
                nameBox.Text = currentFile.Name;
                extensionBox.Text = currentFile.Extension;
                creationBox.Text = currentFile.CreationDate.ToString();
                revampSingleCheck.CheckState = CheckState.Checked;
                clearSingleCheck.CheckState = CheckState.Checked;
            }
            catch (Exception)
            {
                revampSingleCheck.CheckState = CheckState.Unchecked;
                clearSingleCheck.CheckState = CheckState.Unchecked;
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
            else if (nameBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Name cannot be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (nameBox.Text.Trim().IndexOfAny("?/\\*<>|\":".ToCharArray()) != -1)
            {
                MessageBox.Show("Illegal file name!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (extensionBox.Text.Trim().Length <= 1 ||
                !extensionBox.Text.Trim().Contains('.') ||
                extensionBox.Text.Trim().IndexOfAny("?/\\*<>|\":".ToCharArray()) != -1)
            {
                MessageBox.Show("Invalid extension format!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            using (folderBrowserDialog1)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (revampSingleCheck.Checked)
                    {
                        var n = fileList.SelectedItems[0].SubItems[0];
                        var p = fileList.SelectedItems[0].SubItems[1];
                        ExportFile(n.Text, p.Text);
                        if (error)
                        {
                            error = false;
                            return;
                        }
                        MessageBox.Show("Successfully exported files!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }

                    foreach (var file in Files)
                    {
                        ExportFile(file.Name, file.Path);
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
                        string extension = item.Substring(item.LastIndexOf('.'));
                        DateTime date = File.GetCreationTime(item);
                        if (Files.FindIndex(x=>x.Path == item) != -1)
                        {
                            duplicate = true;
                            continue;
                        }
                        Files.Add(new MyFile(name, item, extension, date));
                    }
                    LoadToListView(Files);
                    nameBox.Text = Files[0].Name;
                    extensionBox.Text = Files[0].Extension;
                    creationBox.Text = Files[0].CreationDate.ToString();
                    if (duplicate) MessageBox.Show("Some files were already included, so they got skipped.", "Duplicate files", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void ResetApp()
        {
            nameBox.Text = String.Empty;
            extensionBox.Text = String.Empty;
            creationBox.Text = String.Empty;
            deleteCheck.CheckState = CheckState.Unchecked;
            replaceIfExistsCheck.CheckState = CheckState.Unchecked;
            revampSingleCheck.CheckState = CheckState.Unchecked;
        }
        void LoadToListView(List<MyFile> listOfFiles)
        {
            foreach (var file in listOfFiles)
            {
                ListViewItem item = new ListViewItem(file.Name);
                item.SubItems.Add(file.Path);
                item.SubItems.Add(file.CreationDate.ToString());

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
            if (revampSingleCheck.CheckState == CheckState.Checked)
                replaceBtn.Enabled = true;
            else if (revampSingleCheck.CheckState == CheckState.Unchecked)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Files.Count == 0)
            {
                MessageBox.Show("There are no items in the list", "Files not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clearSingleCheck.Checked)
            {
                if (MessageBox.Show("Do you want to remove this item from the list?", "Remove item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    while (fileList.SelectedItems.Count > 0)
                    {
                        fileList.Items.Remove(fileList.SelectedItems[0]);
                    }
                }
                return;
            }


            if (MessageBox.Show("Do you want to clear the list?", "Clear List", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fileList.Items.Clear();
                Files.Clear();
                ResetApp();
            }
        }
    }
}
