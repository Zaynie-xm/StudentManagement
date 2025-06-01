using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class StuScoreList : Form
    {
        public StuScoreList()
        {
            InitializeComponent();
        }

        private void ScoreList_Load(object sender, EventArgs e)
        {

            this.skinEngine1.SkinFile = "SteelBlue.ssk";
            this.Width = 880;
            this.Height = 660;
            this.Location = new Point(110,200);

            string sql = "select A.CorsNo,A.Score,A.StuNo,B.StuName,C.CorsName from ScoreTable as A join StudentTable AS B on A.StuNo=B.StuNo join CourseTable AS C on A.CorsNo = C.CorsNo where StuName='" + this.label1.Text+"'";

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
