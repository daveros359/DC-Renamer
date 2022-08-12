
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OriginalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.RenameButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Prefix = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Suffix = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OriginalName,
            this.Number,
            this.Caption,
            this.Extension,
            this.NewName});
            this.dataGridView1.Location = new System.Drawing.Point(14, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(0, 200);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(843, 476);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // OriginalName
            // 
            this.OriginalName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OriginalName.HeaderText = "Original Name";
            this.OriginalName.MinimumWidth = 6;
            this.OriginalName.Name = "OriginalName";
            this.OriginalName.ReadOnly = true;
            this.OriginalName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Number.Width = 60;
            // 
            // Caption
            // 
            this.Caption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Caption.HeaderText = "Caption";
            this.Caption.MinimumWidth = 6;
            this.Caption.Name = "Caption";
            this.Caption.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Extension
            // 
            this.Extension.HeaderText = "Extension";
            this.Extension.MinimumWidth = 6;
            this.Extension.Name = "Extension";
            this.Extension.ReadOnly = true;
            this.Extension.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Extension.Width = 125;
            // 
            // NewName
            // 
            this.NewName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NewName.HeaderText = "New Name";
            this.NewName.MinimumWidth = 6;
            this.NewName.Name = "NewName";
            this.NewName.ReadOnly = true;
            // 
            // FolderPath
            // 
            this.FolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderPath.BackColor = System.Drawing.Color.MistyRose;
            this.FolderPath.Location = new System.Drawing.Point(15, 33);
            this.FolderPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.ReadOnly = true;
            this.FolderPath.Size = new System.Drawing.Size(794, 27);
            this.FolderPath.TabIndex = 2;
            // 
            // OpenButton
            // 
            this.OpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenButton.BackColor = System.Drawing.Color.IndianRed;
            this.OpenButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.OpenButton.Location = new System.Drawing.Point(816, 32);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(86, 31);
            this.OpenButton.TabIndex = 3;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // RenameButton
            // 
            this.RenameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RenameButton.Enabled = false;
            this.RenameButton.Location = new System.Drawing.Point(771, 587);
            this.RenameButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(86, 31);
            this.RenameButton.TabIndex = 4;
            this.RenameButton.Text = "Rename";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(14, 587);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(745, 31);
            this.progressBar1.TabIndex = 5;
            // 
            // Prefix
            // 
            this.Prefix.BackColor = System.Drawing.Color.MistyRose;
            this.Prefix.FormattingEnabled = true;
            this.Prefix.Items.AddRange(new object[] {
            " ",
            "",
            "-",
            "_"});
            this.Prefix.Location = new System.Drawing.Point(97, 67);
            this.Prefix.Name = "Prefix";
            this.Prefix.Size = new System.Drawing.Size(158, 28);
            this.Prefix.TabIndex = 6;
            this.Prefix.Text = " ";
            this.Prefix.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(863, 89);
            this.panel1.MinimumSize = new System.Drawing.Size(47, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 209);
            this.panel1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(0, 128);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 81);
            this.button2.TabIndex = 10;
            this.button2.Text = "↓";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 81);
            this.button1.TabIndex = 8;
            this.button1.Text = "↑";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "File Prefix:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Default Caption:";
            // 
            // Suffix
            // 
            this.Suffix.BackColor = System.Drawing.Color.MistyRose;
            this.Suffix.FormattingEnabled = true;
            this.Suffix.Items.AddRange(new object[] {
            " ",
            "IMG",
            "Image",
            "File",
            "Picture",
            "PIC",
            "Video",
            "VID"});
            this.Suffix.Location = new System.Drawing.Point(399, 67);
            this.Suffix.Margin = new System.Windows.Forms.Padding(0);
            this.Suffix.Name = "Suffix";
            this.Suffix.Size = new System.Drawing.Size(158, 28);
            this.Suffix.TabIndex = 11;
            this.Suffix.SelectedIndexChanged += new System.EventHandler(this.Suffix_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.colourToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.grayToolStripMenuItem});
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.colourToolStripMenuItem.Text = "Colour";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Checked = true;
            this.grayToolStripMenuItem.CheckOnClick = true;
            this.grayToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.grayToolStripMenuItem.Text = "Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(914, 635);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Suffix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Prefix);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.FolderPath);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "Form1";
            this.Text = "Dave\'s Renamer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caption;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewName;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox Prefix;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
        private ComboBox Suffix;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem colourToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem grayToolStripMenuItem;
    }
}

