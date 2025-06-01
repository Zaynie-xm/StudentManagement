using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void AddStu_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "SteelBlue.ssk";
            this.textBox1.Text = DateTime.Now.Year + DateTime.Now.Ticks.ToString().Substring(8);
        }

        private void button1_Click(object sender, EventArgs e)
        {   
                //获取用户输入的值
                string CorsNo = this.textBox1.Text;
                string CorsName = this.textBox2.Text;   
                string Point = this.comboBox1.Text;
                string StuCount = this.textBox3.Text;

                string sql = "insert into CourseTable values('"+ CorsNo + "','"+ CorsName + "',"+ Point + ","+ StuCount + ")";

                DBHelper dbh = new DBHelper();
                int a = dbh.InsertUpdateDelete(sql);
                if (a > 0)
                {
                    MessageBox.Show("添加成功！");
                    this.Hide();
                }

        }
    }
}
