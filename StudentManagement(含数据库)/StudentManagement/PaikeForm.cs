using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class PaikeForm : Form
    {
        public PaikeForm()
        {
            InitializeComponent();
        }

        private void PaikeForm_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "SteelBlue.ssk";  

            string sql = "select * from TeacherTable";
            DataTable dt = new DBHelper().GetData(sql);
            this.comboBox2.Text = dt.Rows[0]["TeaName"].ToString().Trim();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.comboBox2.Items.Add(dt.Rows[i]["TeaName"].ToString().Trim()); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cn = this.textBox1.Text;
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
