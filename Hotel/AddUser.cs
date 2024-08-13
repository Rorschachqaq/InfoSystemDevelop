using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Hotel
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtUserPassword.Text = string.Empty;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if username and password are provided
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtUserPassword.Text))
            {
                MessageBox.Show("请输入完整的信息!");
                return;
            }

            string userName = txtUserName.Text.Trim();
            string password = txtUserPassword.Text.Trim();

            // Check if the user already exists
            DataSet ds = DBConnect.ExecuteQuery("SELECT UserName FROM UserInfo WHERE UserName = '" + userName + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("已有此用户！");
                return;
            }

            // Insert the new user with UserType set to 'operator'
            string sql = "INSERT INTO UserInfo (UserName, UserPassword, UserType) VALUES ('" + userName + "', '" + password + "', 'operator')";

            // Execute the query
            if (DBConnect.Execute(sql) > 0)
            {
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
