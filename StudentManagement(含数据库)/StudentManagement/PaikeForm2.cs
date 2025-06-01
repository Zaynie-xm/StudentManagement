using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class PaikeForm2 : Form
    {
        public PaikeForm2()
        {
            InitializeComponent();
        }

        private void PaikeForm_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "SteelBlue.ssk";

            string sql = "select * from CourseTable";
            DataTable dt = new DBHelper().GetData(sql);
            this.comboBox3.Text = dt.Rows[0]["CorsName"].ToString().Trim();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.comboBox3.Items.Add(dt.Rows[i]["CorsName"].ToString().Trim());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cname = this.comboBox2.Text;
            string cn = "";
            DBHelper dbh = new DBHelper();
            string sql = "select TeaNo from TeacherTable where TeaName='"+this.comboBox2.Text+"'";
            string tn = dbh.GetData(sql).Rows[0]["TeaNo"].ToString().Trim();
            string didian = this.comboBox1.Text;
            string ti = this.dateTimePicker1.Value.ToString();

            string sql2 = "insert into TeachTable values('"+cn+"','"+tn+"','"+didian+"','"+ti+"')";
            if (dbh.InsertUpdateDelete(sql2) > 0)
            {
                MessageBox.Show("排课成功！");
                this.Close();
          }
        }
    }
}
