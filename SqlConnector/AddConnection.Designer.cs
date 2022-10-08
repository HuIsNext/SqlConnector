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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DBname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxDBtype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 27);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 27);
            this.textBox2.TabIndex = 1;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "Insert";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(176, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 29);
            this.button4.TabIndex = 10;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
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
            // comboBoxDBtype
            // 
            this.comboBoxDBtype.ForeColor = System.Drawing.Color.Black;
            this.comboBoxDBtype.FormattingEnabled = true;
            this.comboBoxDBtype.Location = new System.Drawing.Point(176, 176);
            this.comboBoxDBtype.Name = "comboBoxDBtype";
            this.comboBoxDBtype.Size = new System.Drawing.Size(250, 27);
            this.comboBoxDBtype.TabIndex = 12;
            
            // 
            // AddConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.comboBoxDBtype);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "AddConnection";
            this.Text = "AddConnection";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DBname;
        private DataGridViewTextBoxColumn ConnStr;
        private DataGridViewTextBoxColumn DBtype;
        private ComboBox comboBoxDBtype;
    }
}