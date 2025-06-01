using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void AddStu_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "SteelBlue.ssk";
            this.textBox1.Text = DateTime.Now.Year + DateTime.Now.Ticks.ToString().Substring(14);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox3.Text == this.textBox4.Text)
            {
                //获取用户输入的值
                string stuid = this.textBox1.Text;
                string name = this.textBox2.Text;
                string pwd = this.textBox3.Text; 

                string sql = "insert into AdminTable values('"+ stuid + "','"+ pwd + "','"+ name + "')";

                DBHelper dbh = new DBHelper();
                int a = dbh.InsertUpdateDelete(sql);
                if (a > 0)
                {
                    MessageBox.Show("添加成功！");
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("两次输入密码不一致！");
            }
        }
    }
}
