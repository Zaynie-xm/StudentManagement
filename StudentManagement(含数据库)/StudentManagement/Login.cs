using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //实现登录的模拟代码
            string name = this.textBox1.Text;
            string password = this.textBox2.Text;

            if (this.comboBox1.Text=="教师")
            {
                #region  教师登录
                string sql = "select * from TeacherTable where TeaName='" + name + "' and TeaPwd='" + password + "'";
                DataTable dt = new DBHelper().GetData(sql);
                if (dt.Rows.Count > 0)
                {
                    //进行教师登录判断
                    TeacherMainFomr t = new TeacherMainFomr();
                    t.label1.Text = name;
                    t.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                }
                #endregion

            }
            else if (this.comboBox1.Text=="学生")
            {
                #region 学生登录
                string sql = "select * from StudentTable where StuName='" + name + "' and StuPwd='" + password + "'";
                DataTable dt = new DBHelper().GetData(sql);
                if (dt.Rows.Count > 0)
                {
                    //进行学生登录判断
                    StudentMainForm s = new StudentMainForm();
                    s.label2.Text = name;

                    s.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                }
                #endregion
            }
            else
            {
                #region 管理员登录
                string sql = "select * from AdminTable where AdminName='" + name + "' and AdminPwd='" + password + "'";
                DataTable dt = new DBHelper().GetData(sql);
                if (dt.Rows.Count > 0)
                {
                    //进行学生登录判断
                    AdminMainForm s = new AdminMainForm();
                    s.label1.Text = name;
                    s.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                }
                #endregion
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox2.Text = "";
            this.textBox2.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "SteelBlue.ssk";
        }
    }
}
