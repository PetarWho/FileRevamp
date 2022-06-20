namespace FileRevamp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileList = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.replaceBtn = new System.Windows.Forms.RadioButton();
            this.insertFront = new System.Windows.Forms.RadioButton();
            this.insertBack = new System.Windows.Forms.RadioButton();
            this.revampBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.extensionCheck = new System.Windows.Forms.CheckBox();
            this.revampSingleCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.extensionBox = new System.Windows.Forms.TextBox();
            this.deleteCheck = new System.Windows.Forms.CheckBox();
            this.replaceIfExistsCheck = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.clearSingleCheck = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.topMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.creditsToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.topMenu.Size = new System.Drawing.Size(1100, 30);
            this.topMenu.TabIndex = 0;
            this.topMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::FileRevamp.Properties.Resources.fileIcon;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.openToolStripMenuItem.Text = "Load Files";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Image = global::FileRevamp.Properties.Resources.folderIcon;
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(52, 25);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileList
            // 
            this.fileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.path});
            this.fileList.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileList.HideSelection = false;
            this.fileList.Location = new System.Drawing.Point(12, 44);
            this.fileList.MultiSelect = false;
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(794, 432);
            this.fileList.TabIndex = 1;
            this.fileList.UseCompatibleStateImageBehavior = false;
            this.fileList.View = System.Windows.Forms.View.Details;
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.fileList_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 293;
            // 
            // path
            // 
            this.path.Text = "Path";
            this.path.Width = 562;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.nameBox.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(35, 71);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(307, 26);
            this.nameBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(139, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Name";
            // 
            // replaceBtn
            // 
            this.replaceBtn.AutoSize = true;
            this.replaceBtn.Enabled = false;
            this.replaceBtn.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.replaceBtn.Location = new System.Drawing.Point(529, 21);
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.Size = new System.Drawing.Size(110, 22);
            this.replaceBtn.TabIndex = 4;
            this.replaceBtn.Text = "Full Replace";
            this.replaceBtn.UseVisualStyleBackColor = true;
            // 
            // insertFront
            // 
            this.insertFront.AutoSize = true;
            this.insertFront.Checked = true;
            this.insertFront.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertFront.Location = new System.Drawing.Point(529, 63);
            this.insertFront.Name = "insertFront";
            this.insertFront.Size = new System.Drawing.Size(118, 22);
            this.insertFront.TabIndex = 4;
            this.insertFront.TabStop = true;
            this.insertFront.Text = "Insert to front";
            this.insertFront.UseVisualStyleBackColor = true;
            // 
            // insertBack
            // 
            this.insertBack.AutoSize = true;
            this.insertBack.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertBack.Location = new System.Drawing.Point(529, 102);
            this.insertBack.Name = "insertBack";
            this.insertBack.Size = new System.Drawing.Size(118, 22);
            this.insertBack.TabIndex = 4;
            this.insertBack.Text = "Insert to back";
            this.insertBack.UseVisualStyleBackColor = true;
            // 
            // revampBtn
            // 
            this.revampBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.revampBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.revampBtn.Font = new System.Drawing.Font("Montserrat ExtraBold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.revampBtn.ForeColor = System.Drawing.Color.Coral;
            this.revampBtn.Location = new System.Drawing.Point(706, 37);
            this.revampBtn.Name = "revampBtn";
            this.revampBtn.Size = new System.Drawing.Size(247, 61);
            this.revampBtn.TabIndex = 5;
            this.revampBtn.Text = "REVAMP";
            this.revampBtn.UseVisualStyleBackColor = false;
            this.revampBtn.Click += new System.EventHandler(this.revampBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.clearSingleCheck);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.extensionCheck);
            this.panel1.Controls.Add(this.revampSingleCheck);
            this.panel1.Controls.Add(this.revampBtn);
            this.panel1.Controls.Add(this.insertBack);
            this.panel1.Controls.Add(this.insertFront);
            this.panel1.Controls.Add(this.replaceBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.extensionBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Location = new System.Drawing.Point(-9, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 160);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Montserrat ExtraBold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(959, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // extensionCheck
            // 
            this.extensionCheck.AutoSize = true;
            this.extensionCheck.Location = new System.Drawing.Point(356, 113);
            this.extensionCheck.Name = "extensionCheck";
            this.extensionCheck.Size = new System.Drawing.Size(150, 22);
            this.extensionCheck.TabIndex = 8;
            this.extensionCheck.Text = "Change extension";
            this.extensionCheck.UseVisualStyleBackColor = true;
            this.extensionCheck.CheckedChanged += new System.EventHandler(this.extensionCheck_CheckedChanged);
            // 
            // revampSingleCheck
            // 
            this.revampSingleCheck.AutoSize = true;
            this.revampSingleCheck.Location = new System.Drawing.Point(740, 113);
            this.revampSingleCheck.Name = "revampSingleCheck";
            this.revampSingleCheck.Size = new System.Drawing.Size(175, 22);
            this.revampSingleCheck.TabIndex = 7;
            this.revampSingleCheck.Text = "Revamp only selected";
            this.revampSingleCheck.UseVisualStyleBackColor = true;
            this.revampSingleCheck.CheckedChanged += new System.EventHandler(this.singleCheck_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(371, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Extension";
            // 
            // extensionBox
            // 
            this.extensionBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.extensionBox.Enabled = false;
            this.extensionBox.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extensionBox.Location = new System.Drawing.Point(348, 70);
            this.extensionBox.Name = "extensionBox";
            this.extensionBox.Size = new System.Drawing.Size(142, 26);
            this.extensionBox.TabIndex = 2;
            // 
            // deleteCheck
            // 
            this.deleteCheck.Location = new System.Drawing.Point(25, 106);
            this.deleteCheck.Name = "deleteCheck";
            this.deleteCheck.Size = new System.Drawing.Size(260, 43);
            this.deleteCheck.TabIndex = 6;
            this.deleteCheck.Text = "Delete initial files.";
            this.deleteCheck.UseVisualStyleBackColor = true;
            // 
            // replaceIfExistsCheck
            // 
            this.replaceIfExistsCheck.Location = new System.Drawing.Point(25, 69);
            this.replaceIfExistsCheck.Name = "replaceIfExistsCheck";
            this.replaceIfExistsCheck.Size = new System.Drawing.Size(241, 22);
            this.replaceIfExistsCheck.TabIndex = 6;
            this.replaceIfExistsCheck.Text = "Replace file if same name exists";
            this.replaceIfExistsCheck.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.replaceIfExistsCheck);
            this.panel2.Controls.Add(this.deleteCheck);
            this.panel2.Location = new System.Drawing.Point(811, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 604);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat ExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(90, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Settings";
            // 
            // clearSingleCheck
            // 
            this.clearSingleCheck.Location = new System.Drawing.Point(988, 102);
            this.clearSingleCheck.Name = "clearSingleCheck";
            this.clearSingleCheck.Size = new System.Drawing.Size(98, 47);
            this.clearSingleCheck.TabIndex = 10;
            this.clearSingleCheck.Text = "Clear only selecteed";
            this.clearSingleCheck.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "Change creation date";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1100, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.topMenu);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.topMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1118, 676);
            this.MinimumSize = new System.Drawing.Size(1118, 676);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Revamp";
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListView fileList;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton replaceBtn;
        private System.Windows.Forms.RadioButton insertFront;
        private System.Windows.Forms.RadioButton insertBack;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button revampBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader path;
        private System.Windows.Forms.CheckBox replaceIfExistsCheck;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox deleteCheck;
        private System.Windows.Forms.CheckBox revampSingleCheck;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox extensionBox;
        private System.Windows.Forms.CheckBox extensionCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox clearSingleCheck;
        private System.Windows.Forms.Button button2;
    }
}

