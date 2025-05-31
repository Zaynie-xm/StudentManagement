using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class StudentMainForm : Form
    {
        public StudentMainForm()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "SteelBlue.ssk";
            this.pictureBox1.Location = new Point(this.Width/2-700,200);
            this.pictureBox2.Location = new Point(this.Width / 2 - 300, 200);
            this.pictureBox3.Location = new Point(this.Width / 2+100 , 200);
            this.pictureBox4.Location = new Point(this.Width / 2 +500, 200);
        }


        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            this.label1.Text = "成绩查询：查询本学期对应课程的成绩信息！";
            this.label1.Location = new Point(41, 600);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.label1.Text = "";
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.label1.Text = "";
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            this.label1.Text = "课表查询：查询本学期上课信息！";
            this.label1.Location = new Point(100, 600);
        }
    }
}
