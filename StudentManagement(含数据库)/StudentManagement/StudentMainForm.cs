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
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "SteelBlue.ssk";
            this.pictureBox1.Location = new Point(this.Width/2-700,200);
            this.pictureBox2.Location = new Point(this.Width / 2 - 400, 200);
            this.pictureBox3.Location = new Point(this.Width / 2-100 , 200);
            this.pictureBox4.Location = new Point(this.Width / 2 +200, 200);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StuScoreList sl = new StuScoreList();
            sl.label1.Text = this.label2.Text;
            sl.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
