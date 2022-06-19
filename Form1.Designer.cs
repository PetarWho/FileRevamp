﻿namespace FileRevamp
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
            this.singleCheck = new System.Windows.Forms.CheckBox();
            this.deleteCheck = new System.Windows.Forms.CheckBox();
            this.replaceIfExistsCheck = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
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
            this.topMenu.Size = new System.Drawing.Size(1100, 29);
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
            this.nameBox.Location = new System.Drawing.Point(18, 78);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(328, 26);
            this.nameBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(69, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Change file name";
            // 
            // replaceBtn
            // 
            this.replaceBtn.AutoSize = true;
            this.replaceBtn.Enabled = false;
            this.replaceBtn.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.replaceBtn.Location = new System.Drawing.Point(390, 21);
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
            this.insertFront.Location = new System.Drawing.Point(390, 63);
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
            this.insertBack.Location = new System.Drawing.Point(390, 102);
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
            this.revampBtn.Location = new System.Drawing.Point(567, 43);
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
            this.panel1.Controls.Add(this.singleCheck);
            this.panel1.Controls.Add(this.revampBtn);
            this.panel1.Controls.Add(this.insertBack);
            this.panel1.Controls.Add(this.insertFront);
            this.panel1.Controls.Add(this.replaceBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Location = new System.Drawing.Point(-9, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 160);
            this.panel1.TabIndex = 6;
            // 
            // singleCheck
            // 
            this.singleCheck.AutoSize = true;
            this.singleCheck.Location = new System.Drawing.Point(101, 113);
            this.singleCheck.Name = "singleCheck";
            this.singleCheck.Size = new System.Drawing.Size(175, 22);
            this.singleCheck.TabIndex = 7;
            this.singleCheck.Text = "Revamp only selected";
            this.singleCheck.UseVisualStyleBackColor = true;
            this.singleCheck.CheckedChanged += new System.EventHandler(this.singleCheck_CheckedChanged);
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
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.replaceIfExistsCheck);
            this.panel2.Controls.Add(this.deleteCheck);
            this.panel2.Location = new System.Drawing.Point(811, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 604);
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
        private System.Windows.Forms.CheckBox singleCheck;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}
