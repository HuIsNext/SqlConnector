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
            this.連線設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加入連線設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.連線設定ToolStripMenuItem,
            this.加入連線設定ToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // 連線設定ToolStripMenuItem
            // 
            this.連線設定ToolStripMenuItem.Name = "連線設定ToolStripMenuItem";
            this.連線設定ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.連線設定ToolStripMenuItem.Text = "連線設定";
            // 
            // 加入連線設定ToolStripMenuItem
            // 
            this.加入連線設定ToolStripMenuItem.Name = "加入連線設定ToolStripMenuItem";
            this.加入連線設定ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.加入連線設定ToolStripMenuItem.Text = "加入連線設定";
            this.加入連線設定ToolStripMenuItem.Click += new System.EventHandler(this.加入連線設定ToolStripMenuItem_Click);
            // 
            // SQLconnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SQLconnector";
            this.Text = "SQLconnector";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 設定ToolStripMenuItem;
        private ToolStripMenuItem 連線設定ToolStripMenuItem;
        private ToolStripMenuItem 加入連線設定ToolStripMenuItem;
    }
}