using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class AddScore : Form
    {
        public AddScore()
        {
            InitializeComponent();
        }

        private void AddStu_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "SteelBlue.ssk";   

            string sql = "select * from CourseTable";
            DataTable dt = new DBHelper().GetData(sql);
            this.comboBox1.Text = dt.Rows[0]["CorsName"].ToString().Trim();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.comboBox1.Items.Add(dt.Rows[i]["CorsName"].ToString().Trim());
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            //获取用户输入的值
            string sn = this.textBox1.Text;
            string cn = this.comboBox1.Text;
            string sql1 = "select CorsNo from CourseTable where CorsName='"+cn+"'";
            DBHelper dbh = new DBHelper();
            string fenshu = this.textBox4.Text;  

            string sql = "insert into ScoreTable values('"+dbh.GetData(sql1).Rows[0]["CorsNo"].ToString().Trim() +"','"+sn+"',"+ fenshu + ")";  

            int a = dbh.InsertUpdateDelete(sql);
            if (a > 0)
            {
                MessageBox.Show("添加成功！");
                this.Hide();
            }
        }
    }
}
