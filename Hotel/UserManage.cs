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
    public partial class UserManage : Form
    {
        private DataSet ds = new DataSet();

        public UserManage()
        {
            InitializeComponent();
        }

        private void UserManage_Load(object sender, EventArgs e)
        {
            ds = DBConnect.ExecuteQuery("SELECT UserName AS '用户名', UserPassword AS '密码' FROM UserInfo");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        // 双击赋值
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("请选择要删除的用户!");
                return;
            }

            string sql = $"DELETE FROM UserInfo WHERE UserName = '{txtUserName.Text.Trim()}'";

            if (DBConnect.Execute(sql) > 0)
            {
                MessageBox.Show("删除成功！");

                ds = DBConnect.ExecuteQuery("SELECT UserName AS '用户名', UserPassword AS '密码' FROM UserInfo");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

                txtUserName.Text = string.Empty;
                txtUserPassword.Text = string.Empty;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string password = txtUserPassword.Text.Trim();

            // 注意修改 SQL 语句，只更新密码
            string sql = "UPDATE UserInfo SET UserPassword = @password WHERE UserName = @userName";

            // 如果选择更新密码，添加密码参数
            if (cboPwd.Checked)
            {
                if (txtUserPassword.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("密码不能为空！");
                    return;
                }

                // 将密码参数添加到 SQL 语句中
                sql = sql.Replace("@password", $"'{password}'").Replace("@userName", $"'{userName}'");

                if (DBConnect.Execute(sql) > 0)
                {
                    MessageBox.Show("修改成功！");

                    ds = DBConnect.ExecuteQuery("SELECT UserName AS '用户名', UserPassword AS '密码' FROM UserInfo");
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;

                    txtUserName.Text = string.Empty;
                    txtUserPassword.Text = string.Empty;
                }
            }

        }

        private void cboPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (cboPwd.Checked)
            {
                txtUserPassword.Enabled = true;
            }
            else
            {
                txtUserPassword.Text = string.Empty;
                txtUserPassword.Enabled = false;
            }
        }


    }


}
