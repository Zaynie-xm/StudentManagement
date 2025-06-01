using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class TeacherMainFomr : Form
    {
        public TeacherMainFomr()
        {
            InitializeComponent();
        }

        private void TeacherMainFomr_Load(object sender, EventArgs e)
        {
            this.panel2.Width = this.Width;
            this.skinEngine1.SkinFile = "SteelBlue.ssk";
        }

        private void 学生查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuList sl = new StuList();
            sl.ShowDialog();
        }

        private void 成绩录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuList sl = new StuList();
            sl.ShowDialog();
        }

        private void 查询成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScoreList sl = new ScoreList();
            sl.ShowDialog();
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void 排课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaikeForm2 pk = new PaikeForm2();
            pk.comboBox2.Text = this.label1.Text;
            pk.ShowDialog();

        }             

        private void 课程列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseList cl = new CourseList();
            cl.ShowDialog();
        }

        private void 课表查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaikeList PL = new PaikeList();
            PL.ShowDialog();
        }
    }
}
