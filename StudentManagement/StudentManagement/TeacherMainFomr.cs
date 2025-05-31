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
    }
}
