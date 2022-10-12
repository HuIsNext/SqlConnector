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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.cbbDBName.Location = new System.Drawing.Point(150, 30);
            this.cbbDBName.Name = "cbbDBName";
            this.cbbDBName.Size = new System.Drawing.Size(151, 27);
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(353, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(605, 341);
            this.dataGridView2.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(13, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(318, 308);
            this.listBox1.TabIndex = 6;
            // 
            // SQLconnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 461);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtConnName);
            this.Controls.Add(this.cbbDBName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SQLconnector";
            this.Text = "SQLconnector";
            this.Load += new System.EventHandler(this.SQLconnector_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private DataGridView dataGridView2;
        private ListBox listBox1;
    }
}