using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class CourseList : Form
    {
        public CourseList()
        {
            InitializeComponent();
        }

        private void StuList_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "SteelBlue.ssk";

            string sql = "select * from CourseTable";
            this.dataGridView1.DataSource = new DBHelper().GetData(sql);


            this.textBox1.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.textBox2.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.textBox3.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            this.textBox4.Text = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox1.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.textBox2.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.textBox3.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            this.textBox4.Text = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaikeForm pk = new PaikeForm();
            pk.textBox1.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            pk.textBox2.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            pk.ShowDialog();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定删除？", "确认信息", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string id = this.textBox1.Text;
                string sql = "delete from CourseTable where CorsNo='"+id+"'";
                if (new DBHelper().InsertUpdateDelete(sql)>0)
                {
                    MessageBox.Show("删除成功！");
                }
            }
        }
    }
}
