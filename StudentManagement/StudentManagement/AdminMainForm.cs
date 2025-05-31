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
    }
}
