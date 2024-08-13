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
    public partial class UserFeedBack : Form
    {
        public UserFeedBack()
        {
            InitializeComponent();
        }

        private void UserFeedBack_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBConnect.ExecuteQuery("select username as '用户名',usermsg as '反馈信息' from FeedBack").Tables[0].DefaultView;
        }
    }
}
