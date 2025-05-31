using System;
using System.Collections.Generic;
using System.Text;
//1.添加引用
using System.Data;
using System.Data.SqlClient;

namespace StudentManagement
{
    public class DBHelper
    {
        //2.连接字符串
        string conStr = @"server=TEACHERZHOU\MYSQL;uid=sa;pwd=18827081901;database=Stu_DB";

        /// <summary>
        /// 用于完成添加、修改、删除的数据库操作
        /// </summary>
        /// <param name="sql">参数：数据库操作指令</param>
        /// <returns>返回受影响的行数</returns>
        public int InsertUpdateDelete(string sql)
        {
            int i = 0;

            //3.创建一个数据库连接
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            //4.创建数据库执行命令
            SqlCommand cmd = new SqlCommand(sql, con);

            //5.调用执行函数
            i = cmd.ExecuteNonQuery();

            return i;
        }




        /// <summary>
        /// 用与查询数据，并返回数据表
        /// </summary>
        /// <param name="sql">SQL指令</param>
        /// <returns>返回查询的数据结果</returns>
        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter(sql, con);

            sda.Fill(dt);

            return dt;
        }

    }
}
