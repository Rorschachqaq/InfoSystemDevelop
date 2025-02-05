﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Hotel
{
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
            cboType.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string adminName = txtAdminName.Text.Trim();
            if (txtAdminName.Text.Trim()==""||txtAdminPwd.Text.Trim()=="")
            {
                MessageBox.Show("不能为空！");
                return;
            }
            //判断是否已经有了此管理员
            DataSet ds = DBConnect.ExecuteQuery("select UserName from UserInfo where UserName='" + adminName + "'");
            if (ds.Tables[0].Rows.Count>0)
            {
                MessageBox.Show("已有此管理员！");
                return;
            }
            
            string adminPwd =txtAdminPwd.Text.Trim();
            string adminType = cboType.Text;
            if (DBConnect.Execute("insert into UserInfo values('" + adminName + "','" + adminPwd + "','" + adminType + "')") > 0)
            {
                MessageBox.Show("添加成功！");
                txtAdminName.Text = string.Empty;
                txtAdminPwd.Text = string.Empty;
                cboType.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
