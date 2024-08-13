using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Hotel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // 点击登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ToLogin();
        }

        // 密码框回车登录
        private void txtUserPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ToLogin();
            }
        }

        private void ToLogin()
        {
            // 判断用户输入是否有误
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtUserPassword.Text))
            {
                MessageBox.Show("输入有误！");
                return;
            }

            string userName = txtUserName.Text.Trim();
            string password = txtUserPassword.Text.Trim();

            DataSet ds = DBConnect.ExecuteQuery($"SELECT * FROM UserInfo WHERE UserName='{userName}' AND UserPassword='{password}'");

            // 查到此用户登录，否则登录失败
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("登录成功！");
                this.Hide();
                
                new HotelManage(ds.Tables[0].Rows[0][0].ToString()).Show();
                
            }
            else
            {
                MessageBox.Show("登录失败！");
                return;
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
