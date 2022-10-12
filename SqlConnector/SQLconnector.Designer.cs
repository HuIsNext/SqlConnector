namespace SqlConnector
{
    partial class SQLconnector
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加入連線設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbbDBName = new System.Windows.Forms.ComboBox();
            this.txtConnName = new System.Windows.Forms.Label();
            this.dgvSqlCommand = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSqlcommand = new System.Windows.Forms.RichTextBox();
            this.btnSqlCommand = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSqlCommand)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加入連線設定ToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // 加入連線設定ToolStripMenuItem
            // 
            this.加入連線設定ToolStripMenuItem.Name = "加入連線設定ToolStripMenuItem";
            this.加入連線設定ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.加入連線設定ToolStripMenuItem.Text = "加入連線設定";
            this.加入連線設定ToolStripMenuItem.Click += new System.EventHandler(this.加入連線設定ToolStripMenuItem_Click);
            // 
            // cbbDBName
            // 
            this.cbbDBName.Location = new System.Drawing.Point(104, 30);
            this.cbbDBName.Name = "cbbDBName";
            this.cbbDBName.Size = new System.Drawing.Size(99, 27);
            this.cbbDBName.TabIndex = 2;
            this.cbbDBName.SelectedIndexChanged += new System.EventHandler(this.cbbDBName_SelectedIndexChanged);
            // 
            // txtConnName
            // 
            this.txtConnName.AutoSize = true;
            this.txtConnName.Location = new System.Drawing.Point(13, 30);
            this.txtConnName.Name = "txtConnName";
            this.txtConnName.Size = new System.Drawing.Size(76, 19);
            this.txtConnName.TabIndex = 4;
            this.txtConnName.Text = "連線設定 :";
            // 
            // dgvSqlCommand
            // 
            this.dgvSqlCommand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSqlCommand.Location = new System.Drawing.Point(225, 30);
            this.dgvSqlCommand.Name = "dgvSqlCommand";
            this.dgvSqlCommand.RowHeadersWidth = 51;
            this.dgvSqlCommand.RowTemplate.Height = 29;
            this.dgvSqlCommand.Size = new System.Drawing.Size(733, 260);
            this.dgvSqlCommand.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(13, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(190, 365);
            this.listBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "SQL 指令";
            // 
            // txtSqlcommand
            // 
            this.txtSqlcommand.Location = new System.Drawing.Point(303, 302);
            this.txtSqlcommand.Name = "txtSqlcommand";
            this.txtSqlcommand.Size = new System.Drawing.Size(655, 105);
            this.txtSqlcommand.TabIndex = 9;
            this.txtSqlcommand.Text = "";
            // 
            // btnSqlCommand
            // 
            this.btnSqlCommand.Location = new System.Drawing.Point(773, 420);
            this.btnSqlCommand.Name = "btnSqlCommand";
            this.btnSqlCommand.Size = new System.Drawing.Size(185, 29);
            this.btnSqlCommand.TabIndex = 10;
            this.btnSqlCommand.Text = "SQLcommand GO!";
            this.btnSqlCommand.UseVisualStyleBackColor = true;
            this.btnSqlCommand.Click += new System.EventHandler(this.btnSqlCommand_Click);
            // 
            // SQLconnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 461);
            this.Controls.Add(this.btnSqlCommand);
            this.Controls.Add(this.txtSqlcommand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dgvSqlCommand);
            this.Controls.Add(this.txtConnName);
            this.Controls.Add(this.cbbDBName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SQLconnector";
            this.Text = "SQLconnector";
            this.Load += new System.EventHandler(this.SQLconnector_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSqlCommand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 設定ToolStripMenuItem;
        private ToolStripMenuItem 加入連線設定ToolStripMenuItem;
        private ComboBox cbbDBName;
        private DataGridView dgvDBname;
        private Label txtConnName;
        private DataGridView dgvSqlCommand;
        private ListBox listBox1;
        private Label label1;
        private RichTextBox richTextBox1;
        private Button btnSqlCommand;
        private RichTextBox txtSqlcommand;
    }
}