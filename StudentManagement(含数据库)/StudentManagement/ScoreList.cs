using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class ScoreList : Form
    {
        public ScoreList()
        {
            InitializeComponent();
        }

        private void ScoreList_Load(object sender, EventArgs e)
        {

            this.skinEngine1.SkinFile = "SteelBlue.ssk";
            this.Width = 1400;
            this.Height = 660;
            this.Location = new Point(110,200);

            string sql = "select A.CorsNo,A.Score,A.StuNo,B.StuName,C.CorsName from ScoreTable as A join StudentTable AS B on A.StuNo=B.StuNo join CourseTable AS C on A.CorsNo = C.CorsNo";

            this.dataGridView1.DataSource = new DBHelper().GetData(sql);

            string sql2 = "select * from CourseTable";
            DataTable dt = new DBHelper().GetData(sql2);
            this.comboBox1.Text = dt.Rows[0]["CorsName"].ToString().Trim();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.comboBox1.Items.Add(dt.Rows[i]["CorsName"].ToString().Trim());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cn = this.comboBox1.Text;
            string sql = "select A.CorsNo,A.Score,A.StuNo,B.StuName,C.CorsName from ScoreTable as A join StudentTable AS B on A.StuNo=B.StuNo join CourseTable AS C on A.CorsNo=C.CorsNo where C.CorsName ='"+cn+"'";

            this.dataGridView1.DataSource = new DBHelper().GetData(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Stuname = this.textBox1.Text; 
            string sql = "select A.CorsNo,A.Score,A.StuNo,B.StuName,C.CorsName from ScoreTable as A join StudentTable AS B on A.StuNo=B.StuNo join CourseTable AS C on A.CorsNo=C.CorsNo where B.StuName like '%" + Stuname+"%'";

            this.dataGridView1.DataSource = new DBHelper().GetData(sql);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string stuno = this.textBox3.Text;

            string sql = "select A.CorsNo,A.Score,A.StuNo,B.StuName,C.CorsName from ScoreTable as A join StudentTable AS B on A.StuNo=B.StuNo join CourseTable AS C on A.CorsNo=C.CorsNo where A.StuNo like '%" + stuno + "%'";

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
