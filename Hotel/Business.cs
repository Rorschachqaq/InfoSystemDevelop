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
    public partial class Business : Form
    {
        private DataSet dataSet = new DataSet();
        //查询重命名字段
        private string words = "ID,CustomerName as '宾客姓名',Sex as '性别',CredentialNumber as '身份证号',Phone as '电话号码',CheckInTime as '入住时间',CheckOutTime as '离开时间',Days as '预计天数',Spending as '花费',RoomType as '房间类型',RoomNumber as '房间号',Remarks as '备注'";
        public Business()
        {
            InitializeComponent();
        }

        private void Business_Load(object sender, EventArgs e)
        {
            dataSet = DBConnect.ExecuteQuery("select "+words+" from Record");
            dataGridView1.DataSource = dataSet.Tables[0].DefaultView;

            // 本周营业额
                //今天
            DateTime dt = DateTime.Now;
                //本周周一
            DateTime startWeek = dt.AddDays(1 - Convert.ToInt32(dt.DayOfWeek.ToString("d")));
            DataSet ds = DBConnect.ExecuteQuery("select * from Record where CheckInTime>='" + startWeek + "' and CheckOutTime<='" + dt + "'");
            int weekMoney = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                weekMoney += int.Parse(dataSet.Tables[0].Rows[i][8].ToString());
            }
            lblWeek.Text += weekMoney.ToString();

            //本月营业额
                //本月月初
            DateTime startMonth = dt.AddDays(1 - dt.Day);
            ds = DBConnect.ExecuteQuery("select * from Record where CheckInTime>='" + startMonth + "' and CheckOutTime<='" + dt + "'");
            int monthMoney = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                monthMoney += int.Parse(dataSet.Tables[0].Rows[i][8].ToString()); 
            }
            lblMonth.Text += monthMoney.ToString();

            //本年营业额
                //本年年初 
            DateTime startYear = new DateTime(dt.Year, 1, 1);
            ds = DBConnect.ExecuteQuery("select * from Record where CheckInTime>='" + startYear + "' and CheckOutTime<='" + dt + "'");
            int yearMoney = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                yearMoney += int.Parse(dataSet.Tables[0].Rows[i][8].ToString());
            }
            lblYear.Text += yearMoney.ToString();

            //总营业额计算
            int allMoney = 0;
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                allMoney += int.Parse(dataSet.Tables[0].Rows[i][8].ToString());
            }
            lblAll.Text += allMoney.ToString();

            //设置右下角
            lblPs.Text += dt.ToLongTimeString().ToString() + ")";
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEnd.Value<dtpStart.Value)
            {
                MessageBox.Show("选择日期有误！");
                dtpEnd.Value = dtpStart.Value;
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sql = "select " + words + " from Record where 1=1 and CheckInTime>='" + dtpStart.Value + "' and CheckOutTime<='" + dtpEnd.Value + "'";
            if (txtUserName.Text.Trim()!=string.Empty)
            {
                sql += "and CustomerName='" + txtUserName.Text.Trim() + "'";
            }
            dataSet = DBConnect.ExecuteQuery(sql);
            dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
        }

    }
}
