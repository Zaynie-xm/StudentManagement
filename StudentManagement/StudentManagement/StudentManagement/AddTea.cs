using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class AddTea : Form
    {
        public AddTea()
        {
            InitializeComponent();
            this.textBox1.Text = DateTime.Now.Year + DateTime.Now.Ticks.ToString().Substring(12);
        }

        private void AddStu_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "SteelBlue.ssk";
        }
    }
}
