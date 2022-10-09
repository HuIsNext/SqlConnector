namespace SqlConnector
{
    partial class AddConnection
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
            this.txtDBname = new System.Windows.Forms.TextBox();
            this.txtConnStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DBname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbDBtype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDBname
            // 
            this.txtDBname.Location = new System.Drawing.Point(176, 39);
            this.txtDBname.Name = "txtDBname";
            this.txtDBname.Size = new System.Drawing.Size(250, 27);
            this.txtDBname.TabIndex = 0;
            // 
            // txtConnStr
            // 
            this.txtConnStr.Location = new System.Drawing.Point(176, 106);
            this.txtConnStr.Name = "txtConnStr";
            this.txtConnStr.Size = new System.Drawing.Size(250, 27);
            this.txtConnStr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "DB Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "ConnectionString";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "DB類型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "測試連線";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Insert_btn
            // 
            this.Insert_btn.Location = new System.Drawing.Point(176, 294);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(250, 29);
            this.Insert_btn.TabIndex = 9;
            this.Insert_btn.Text = "Insert";
            this.Insert_btn.UseVisualStyleBackColor = true;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(176, 397);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(250, 29);
            this.delete_btn.TabIndex = 10;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DBname,
            this.ConnStr,
            this.DBtype});
            this.dataGridView1.Location = new System.Drawing.Point(481, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(501, 387);
            this.dataGridView1.TabIndex = 11;
            // 
            // DBname
            // 
            this.DBname.HeaderText = "DBname";
            this.DBname.MinimumWidth = 6;
            this.DBname.Name = "DBname";
            this.DBname.Width = 125;
            // 
            // ConnStr
            // 
            this.ConnStr.HeaderText = "ConnStr";
            this.ConnStr.MinimumWidth = 6;
            this.ConnStr.Name = "ConnStr";
            this.ConnStr.Width = 125;
            // 
            // DBtype
            // 
            this.DBtype.HeaderText = "DBtype";
            this.DBtype.MinimumWidth = 6;
            this.DBtype.Name = "DBtype";
            this.DBtype.Width = 125;
            // 
            // cbbDBtype
            // 
            this.cbbDBtype.ForeColor = System.Drawing.Color.Black;
            this.cbbDBtype.FormattingEnabled = true;
            this.cbbDBtype.Location = new System.Drawing.Point(176, 176);
            this.cbbDBtype.Name = "cbbDBtype";
            this.cbbDBtype.Size = new System.Drawing.Size(250, 27);
            this.cbbDBtype.TabIndex = 12;
            // 
            // AddConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.cbbDBtype);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConnStr);
            this.Controls.Add(this.txtDBname);
            this.Name = "AddConnection";
            this.Text = "AddConnection";
            this.Load += new System.EventHandler(this.AddConnection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDBname;
        private TextBox txtConnStr;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button Insert_btn;
        private Button delete_btn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DBname;
        private DataGridViewTextBoxColumn ConnStr;
        private DataGridViewTextBoxColumn DBtype;
        private ComboBox cbbDBtype;
    }
}