using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "SteelBlue.ssk";
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStu ad = new AddStu();
            ad.ShowDialog();
        }

        private void 添加ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddTea at = new AddTea();
            at.ShowDialog();
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuList s = new StuList();
            s.ShowDialog();
        }

        private void 查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TeaList tl = new TeaList();
            tl.ShowDialog();
        }

        private void 添加ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddCourse ac = new AddCourse();
            ac.ShowDialog();
        }

        private void 查询ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CourseList cl = new CourseList();
            cl.ShowDialog();
        }

        private void 添加管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAdmin aa = new AddAdmin();
            aa.ShowDialog();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminList al = new AdminList();
            al.ShowDialog();
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();

        }
    }
}
