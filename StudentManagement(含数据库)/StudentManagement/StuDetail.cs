using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class StuDetail : Form
    {
        public StuDetail()
        {
            InitializeComponent();
        }

        private void StuDetail_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "SteelBlue.ssk";
            string sid = this.textBox2.Text;
            string sql = "select * from StudentTable where StuNo='"+sid+"'";
            DataTable dt = new DBHelper().GetData(sql);
            this.textBox1.Text = dt.Rows[0]["StuName"].ToString().Trim();
            this.textBox4.Text= dt.Rows[0]["ClassNo"].ToString().Trim();
        }
    }
}
