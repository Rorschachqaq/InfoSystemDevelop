﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace Hotel
{
    internal class DBConnect
    {
        //连接字符串
        private static string conStr = @"Data Source=DESKTOP-9DRB05G\SQLSERVER;Initial Catalog=HotelInfoSystem;Integrated Security=True;Connect Timeout=30";

        /// <summary>
        /// 对数据库的表进行增删改功能
        /// </summary>
        /// <param name="sql">用于操作的sql语句</param>
        /// <returns>返回受影响的行数</returns>
        public static int Execute(string sql)
        {
            //if (sql.Contains('-')&&sql.Contains('o'))
            //{
            //    return 0;
            //}
            int rows;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    con.Open();
                    rows = com.ExecuteNonQuery();
                }
            }
            return rows;
        }

        /// <summary>
        /// 对数据库的表进行查询功能
        /// </summary>
        /// <param name="sql">用于操作的sql语句</param>
        /// <returns>返回查询的结果，类型为DataSet</returns>
        public static DataSet ExecuteQuery(string sql)
        {
            DataSet ds = new DataSet();
            //if (sql.Contains('-'))
            //{
            //    return ds;
            //}

            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(com);
                    adapter.Fill(ds);
                }
            }
            return ds;
        }
    }
}

