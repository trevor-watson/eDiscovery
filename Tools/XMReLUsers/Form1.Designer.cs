namespace XMReLUsers
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.textboxFilePath = new System.Windows.Forms.TextBox();
            this.listBox_XMLEmails = new System.Windows.Forms.ListBox();
            this.listBox_RemoveEmails = new System.Windows.Forms.ListBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonListRemove = new System.Windows.Forms.Button();
            this.buttonListKeep = new System.Windows.Forms.Button();
            this.labelKeep = new System.Windows.Forms.Label();
            this.labelRemove = new System.Windows.Forms.Label();
            this.textboxMassMove = new System.Windows.Forms.TextBox();
            this.buttonMassMove = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonWhitelist = new System.Windows.Forms.Button();
            this.buttonMassMoveItems = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textboxFilePath
            // 
            this.textboxFilePath.AllowDrop = true;
            this.textboxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxFilePath.Location = new System.Drawing.Point(12, 15);
            this.textboxFilePath.Name = "textboxFilePath";
            this.textboxFilePath.Size = new System.Drawing.Size(432, 20);
            this.textboxFilePath.TabIndex = 0;
            this.textboxFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_filePath_DragDrop);
            this.textboxFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_filePath_DragEnter);
            // 
            // listBox_XMLEmails
            // 
            this.listBox_XMLEmails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_XMLEmails.FormattingEnabled = true;
            this.listBox_XMLEmails.Location = new System.Drawing.Point(3, 16);
            this.listBox_XMLEmails.Name = "listBox_XMLEmails";
            this.tableLayoutPanel1.SetRowSpan(this.listBox_XMLEmails, 2);
            this.listBox_XMLEmails.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_XMLEmails.Size = new System.Drawing.Size(238, 361);
            this.listBox_XMLEmails.TabIndex = 1;
            this.listBox_XMLEmails.DoubleClick += new System.EventHandler(this.listBox_XMLEmails_DoubleClick);
            // 
            // listBox_RemoveEmails
            // 
            this.listBox_RemoveEmails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_RemoveEmails.FormattingEnabled = true;
            this.listBox_RemoveEmails.Location = new System.Drawing.Point(287, 16);
            this.listBox_RemoveEmails.Name = "listBox_RemoveEmails";
            this.tableLayoutPanel1.SetRowSpan(this.listBox_RemoveEmails, 2);
            this.listBox_RemoveEmails.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_RemoveEmails.Size = new System.Drawing.Size(238, 361);
            this.listBox_RemoveEmails.TabIndex = 2;
            this.listBox_RemoveEmails.DoubleClick += new System.EventHandler(this.listBox_RemoveEmails_DoubleClick);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen.Image")));
            this.buttonOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpen.Location = new System.Drawing.Point(450, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonOpen.Size = new System.Drawing.Size(92, 25);
            this.buttonOpen.TabIndex = 3;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(448, 429);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSave.Size = new System.Drawing.Size(92, 25);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonListRemove
            // 
            this.buttonListRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonListRemove.Image = ((System.Drawing.Image)(resources.GetObject("buttonListRemove.Image")));
            this.buttonListRemove.Location = new System.Drawing.Point(247, 170);
            this.buttonListRemove.Name = "buttonListRemove";
            this.buttonListRemove.Size = new System.Drawing.Size(34, 23);
            this.buttonListRemove.TabIndex = 5;
            this.buttonListRemove.UseVisualStyleBackColor = true;
            this.buttonListRemove.Click += new System.EventHandler(this.buttonListRemove_Click);
            // 
            // buttonListKeep
            // 
            this.buttonListKeep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonListKeep.Image = ((System.Drawing.Image)(resources.GetObject("buttonListKeep.Image")));
            this.buttonListKeep.Location = new System.Drawing.Point(247, 199);
            this.buttonListKeep.Name = "buttonListKeep";
            this.buttonListKeep.Size = new System.Drawing.Size(34, 23);
            this.buttonListKeep.TabIndex = 6;
            this.buttonListKeep.UseVisualStyleBackColor = true;
            this.buttonListKeep.Click += new System.EventHandler(this.buttonListKeep_Click);
            // 
            // labelKeep
            // 
            this.labelKeep.AutoSize = true;
            this.labelKeep.Location = new System.Drawing.Point(3, 0);
            this.labelKeep.Name = "labelKeep";
            this.labelKeep.Size = new System.Drawing.Size(35, 13);
            this.labelKeep.TabIndex = 7;
            this.labelKeep.Text = "Keep:";
            // 
            // labelRemove
            // 
            this.labelRemove.AutoSize = true;
            this.labelRemove.Location = new System.Drawing.Point(287, 0);
            this.labelRemove.Name = "labelRemove";
            this.labelRemove.Size = new System.Drawing.Size(50, 13);
            this.labelRemove.TabIndex = 8;
            this.labelRemove.Text = "Remove:";
            // 
            // textboxMassMove
            // 
            this.textboxMassMove.AllowDrop = true;
            this.textboxMassMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxMassMove.Location = new System.Drawing.Point(12, 432);
            this.textboxMassMove.Name = "textboxMassMove";
            this.textboxMassMove.Size = new System.Drawing.Size(119, 20);
            this.textboxMassMove.TabIndex = 10;
            // 
            // buttonMassMove
            // 
            this.buttonMassMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMassMove.Image = ((System.Drawing.Image)(resources.GetObject("buttonMassMove.Image")));
            this.buttonMassMove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMassMove.Location = new System.Drawing.Point(12, 461);
            this.buttonMassMove.Name = "buttonMassMove";
            this.buttonMassMove.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonMassMove.Size = new System.Drawing.Size(119, 25);
            this.buttonMassMove.TabIndex = 11;
            this.buttonMassMove.Text = "Blacklist";
            this.buttonMassMove.UseVisualStyleBackColor = true;
            this.buttonMassMove.Click += new System.EventHandler(this.buttonMassMove_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listBox_RemoveEmails, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox_XMLEmails, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonListKeep, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelKeep, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelRemove, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonListRemove, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(528, 380);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Enabled = false;
            this.buttonExport.Image = ((System.Drawing.Image)(resources.GetObject("buttonExport.Image")));
            this.buttonExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExport.Location = new System.Drawing.Point(448, 460);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonExport.Size = new System.Drawing.Size(92, 25);
            this.buttonExport.TabIndex = 13;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // buttonWhitelist
            // 
            this.buttonWhitelist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonWhitelist.Image = ((System.Drawing.Image)(resources.GetObject("buttonWhitelist.Image")));
            this.buttonWhitelist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWhitelist.Location = new System.Drawing.Point(137, 461);
            this.buttonWhitelist.Name = "buttonWhitelist";
            this.buttonWhitelist.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonWhitelist.Size = new System.Drawing.Size(116, 25);
            this.buttonWhitelist.TabIndex = 14;
            this.buttonWhitelist.Text = "Whitelist";
            this.buttonWhitelist.UseVisualStyleBackColor = true;
            this.buttonWhitelist.Click += new System.EventHandler(this.buttonWhitelist_Click);
            // 
            // buttonMassMoveItems
            // 
            this.buttonMassMoveItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMassMoveItems.Image = ((System.Drawing.Image)(resources.GetObject("buttonMassMoveItems.Image")));
            this.buttonMassMoveItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMassMoveItems.Location = new System.Drawing.Point(137, 429);
            this.buttonMassMoveItems.Name = "buttonMassMoveItems";
            this.buttonMassMoveItems.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonMassMoveItems.Size = new System.Drawing.Size(116, 25);
            this.buttonMassMoveItems.TabIndex = 15;
            this.buttonMassMoveItems.Text = "Mass Move";
            this.buttonMassMoveItems.UseVisualStyleBackColor = true;
            this.buttonMassMoveItems.Click += new System.EventHandler(this.button1_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 494);
            this.Controls.Add(this.buttonMassMoveItems);
            this.Controls.Add(this.buttonWhitelist);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonMassMove);
            this.Controls.Add(this.textboxMassMove);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textboxFilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "formMain";
            this.Text = "XMReLUsers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxFilePath;
        private System.Windows.Forms.ListBox listBox_XMLEmails;
        private System.Windows.Forms.ListBox listBox_RemoveEmails;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonListRemove;
        private System.Windows.Forms.Button buttonListKeep;
        private System.Windows.Forms.Label labelKeep;
        private System.Windows.Forms.Label labelRemove;
        private System.Windows.Forms.TextBox textboxMassMove;
        private System.Windows.Forms.Button buttonMassMove;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonWhitelist;
        private System.Windows.Forms.Button buttonMassMoveItems;
    }
}

