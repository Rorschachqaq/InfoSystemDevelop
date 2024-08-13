namespace Hotel
{
    partial class BookRoom
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDeposit = new System.Windows.Forms.ComboBox();
            this.txtRoomRemarks = new System.Windows.Forms.TextBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpCheckInTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(366, 642);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 38);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(204, 642);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 38);
            this.btnReset.TabIndex = 36;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(34, 642);
            this.btnBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(112, 38);
            this.btnBook.TabIndex = 35;
            this.btnBook.Text = "预定";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(138, 270);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(338, 104);
            this.txtRemarks.TabIndex = 34;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(138, 198);
            this.txtDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(208, 26);
            this.txtDays.TabIndex = 33;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(138, 107);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(208, 26);
            this.txtPhone.TabIndex = 31;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(138, 63);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(208, 26);
            this.txtCustomerName.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboDeposit);
            this.groupBox1.Controls.Add(this.txtRoomRemarks);
            this.groupBox1.Controls.Add(this.txtRoomNumber);
            this.groupBox1.Controls.Add(this.txtRoomPrice);
            this.groupBox1.Controls.Add(this.txtRoomType);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(34, 395);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(444, 233);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择客房";
            // 
            // cboDeposit
            // 
            this.cboDeposit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeposit.FormattingEnabled = true;
            this.cboDeposit.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.cboDeposit.Location = new System.Drawing.Point(324, 75);
            this.cboDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDeposit.Name = "cboDeposit";
            this.cboDeposit.Size = new System.Drawing.Size(104, 28);
            this.cboDeposit.TabIndex = 9;
            // 
            // txtRoomRemarks
            // 
            this.txtRoomRemarks.Location = new System.Drawing.Point(110, 127);
            this.txtRoomRemarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomRemarks.Multiline = true;
            this.txtRoomRemarks.Name = "txtRoomRemarks";
            this.txtRoomRemarks.Size = new System.Drawing.Size(319, 94);
            this.txtRoomRemarks.TabIndex = 8;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(110, 75);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(104, 26);
            this.txtRoomNumber.TabIndex = 7;
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.Location = new System.Drawing.Point(324, 28);
            this.txtRoomPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.Size = new System.Drawing.Size(104, 26);
            this.txtRoomPrice.TabIndex = 6;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(108, 28);
            this.txtRoomType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(104, 26);
            this.txtRoomType.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 127);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "客房备注：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(232, 82);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "押　　金：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "客房号码：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "客房价格：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "客房类型：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "备注信息：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "预计天数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "入住时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "联系电话：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "宾客姓名：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(519, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(504, 598);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dtpCheckInTime
            // 
            this.dtpCheckInTime.Location = new System.Drawing.Point(138, 150);
            this.dtpCheckInTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpCheckInTime.Name = "dtpCheckInTime";
            this.dtpCheckInTime.Size = new System.Drawing.Size(208, 26);
            this.dtpCheckInTime.TabIndex = 38;
            // 
            // BookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 732);
            this.Controls.Add(this.dtpCheckInTime);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BookRoom";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客房预定";
            this.Load += new System.EventHandler(this.BookRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboDeposit;
        private System.Windows.Forms.TextBox txtRoomRemarks;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpCheckInTime;
    }
}