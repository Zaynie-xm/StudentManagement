using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class StuList : Form
    {
        public StuList()
        {
            InitializeComponent();
        }

        private void StuList_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "SteelBlue.ssk";

            string sql = "select * from StudentTable";
            this.dataGridView1.DataSource = new DBHelper().GetData(sql);


            this.textBox1.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.comboBox1.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.textBox3.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            this.textBox4.Text = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox1.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.comboBox1.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.textBox3.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            this.textBox4.Text = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuDetail sd = new StuDetail();
            sd.textBox2.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            sd.ShowDialog();
        }

        private void 添加成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScore ae= new AddScore();
            ae.textBox1.Text = this.textBox1.Text;
            ae.textBox2.Text = this.textBox3.Text; 
            ae.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {    
        }
    }
}
