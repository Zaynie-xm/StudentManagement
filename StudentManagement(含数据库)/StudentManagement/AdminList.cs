using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class AdminList : Form
    {
        public AdminList()
        {
            InitializeComponent();
        }

        private void StuList_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "SteelBlue.ssk";

            string sql = "select * from AdminTable";
            this.dataGridView1.DataSource = new DBHelper().GetData(sql);


            this.textBox1.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();  
            this.textBox3.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.textBox4.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox1.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();  
            this.textBox3.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.textBox4.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = true;
            this.groupBox1.Refresh();
        }
    }
}
