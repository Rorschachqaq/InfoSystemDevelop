namespace Hotel
{
    partial class Business
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
            this.lblWeek = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblAll = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPs = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Location = new System.Drawing.Point(64, 57);
            this.lblWeek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(105, 20);
            this.lblWeek.TabIndex = 0;
            this.lblWeek.Text = "本周营业额：";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(298, 57);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(105, 20);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "本月营业额：";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(532, 57);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(105, 20);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "年度营业额：";
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Location = new System.Drawing.Point(766, 57);
            this.lblAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(89, 20);
            this.lblAll.TabIndex = 4;
            this.lblAll.Text = "总营业额：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Location = new System.Drawing.Point(75, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(852, 107);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "入住记录：";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(704, 38);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(112, 38);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "至";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(468, 40);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(181, 26);
            this.dtpEnd.TabIndex = 3;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(234, 40);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(181, 26);
            this.dtpStart.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名：";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(112, 40);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(90, 26);
            this.txtUserName.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 288);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(852, 480);
            this.dataGridView1.TabIndex = 6;
            // 
            // lblPs
            // 
            this.lblPs.AutoSize = true;
            this.lblPs.ForeColor = System.Drawing.Color.Red;
            this.lblPs.Location = new System.Drawing.Point(546, 780);
            this.lblPs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPs.Name = "lblPs";
            this.lblPs.Size = new System.Drawing.Size(254, 20);
            this.lblPs.TabIndex = 7;
            this.lblPs.Text = "(注：所有查询结果均为起始日期的";

            // 
            // Business
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 813);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblPs);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAll);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblWeek);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Business";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "营业额度";
            this.Load += new System.EventHandler(this.Business_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPs;
        private System.Windows.Forms.Button btnImport;
    }
}