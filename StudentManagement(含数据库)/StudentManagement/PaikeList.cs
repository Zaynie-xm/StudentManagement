using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class PaikeList : Form
    {
        public PaikeList()
        {
            InitializeComponent();
        }

        private void ScoreList_Load(object sender, EventArgs e)
        {

            this.skinEngine1.SkinFile = "SteelBlue.ssk";
            this.Width = 1500;
            this.Height = 660;
            this.Location = new Point(110,200);
            DBHelper dbh = new DBHelper();

            string sql = "select A.CorsNo,C.CorsName,B.TeaName,B.TeaNo,A.Location,A.CorsTime from TeachTable as A join TeacherTable AS B on A.TeaNo=B.TeaNo join CourseTable AS C on A.CorsNo=C.CorsNo ";

            this.dataGridView1.DataSource = new DBHelper().GetData(sql);

            string sql2 = "select * from CourseTable";
            DataTable dt1 = dbh.GetData(sql2);
            this.comboBox1.Text = dt1.Rows[0]["CorsName"].ToString().Trim();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                this.comboBox1.Items.Add(dt1.Rows[i]["CorsName"].ToString().Trim());
            }

            string sql3 = "select * from TeacherTable";
            DataTable dt2 = dbh.GetData(sql3);
            this.comboBox2.Text = dt2.Rows[0]["TeaName"].ToString().Trim();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                this.comboBox2.Items.Add(dt2.Rows[i]["TeaName"].ToString().Trim());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string loca = this.comboBox3.Text;
            string sql = "select A.CorsNo,C.CorsName,B.TeaName,B.TeaNo,A.Location,A.CorsTime from TeachTable as A join TeacherTable AS B on A.TeaNo=B.TeaNo join CourseTable AS C on A.CorsNo=C.CorsNo where Location='" + loca + "'";

            this.dataGridView1.DataSource = new DBHelper().GetData(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cname = this.comboBox1.Text; 
            string sql = "select A.CorsNo,C.CorsName,B.TeaName,B.TeaNo,A.Location,A.CorsTime from TeachTable as A join TeacherTable AS B on A.TeaNo=B.TeaNo join CourseTable AS C on A.CorsNo=C.CorsNo where CorsName='"+cname+"'";

            this.dataGridView1.DataSource = new DBHelper().GetData(sql);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tname = this.comboBox2.Text;
            string sql = "select A.CorsNo,C.CorsName,B.TeaName,B.TeaNo,A.Location,A.CorsTime from TeachTable as A join TeacherTable AS B on A.TeaNo=B.TeaNo join CourseTable AS C on A.CorsNo=C.CorsNo where TeaName='" + tname + "'";

            this.dataGridView1.DataSource = new DBHelper().GetData(sql);
        }

        private void 学生详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuDetail sd = new StuDetail();
            sd.textBox2.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            sd.ShowDialog();
        }
    }
}
