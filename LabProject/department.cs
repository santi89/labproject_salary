using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabProject
{
    public partial class department : Form
    {
        SqlConnection conn = connect.GetConnection();

        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string sql = "";
        public department()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb2.SelectedIndex == cb2.FindString("ADMINSTATIVE"))
            {
               cb1.ResetText();
                cb1.SelectedItem= "ພະແນກບໍລິຫານ";
            }
           else  if (cb2.SelectedIndex == cb2.FindString("FINANCIAL"))
            {
                cb1.ResetText();
                cb1.SelectedItem = "ພະແນກການເງິນ";
            }
            else if (cb2.SelectedIndex == cb2.FindString("IT"))
            {
                cb1.ResetText();
                cb1.SelectedItem = "ພະແນກໄອທີ";
            }
            else if (cb2.SelectedIndex == cb2.FindString("DESIGNING"))
            {
                cb1.ResetText();
                cb1.SelectedItem = "ພະແນກດີໄຊ";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb1.SelectedIndex == cb1.FindString("ພະແນກບໍລິຫານ"))
            {
                cb2.ResetText();
                cb2.SelectedItem = "ADMINSTATIVE";
            }
            else if (cb1.SelectedIndex == cb1.FindString("ພະແນກການເງິນ"))
            {
                cb2.ResetText();
                cb2.SelectedItem = "FINANCIAL";
            }
            else if (cb1.SelectedIndex == cb1.FindString("ພະແນກໄອທີ"))
            {
                cb2.ResetText();
                cb2.SelectedItem = "IT";
            }
            else if (cb1.SelectedIndex == cb1.FindString("ພະແນກດີໄຊ"))
            {
                cb2.ResetText();
                cb2.SelectedItem = "DESIGNING";
            }
        }

        public void showdata()
        {
            sql = "select * from tbdepartment";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "de");
            if (ds.Tables["de"] != null)
            {
                ds.Tables.Clear();
                da.Fill(ds, "de");
            }
            dataGridView1.DataSource = ds.Tables["de"];
            dataGridView1.Refresh();
            dataGridView1.Columns[0].HeaderText = "departmentID";
            dataGridView1.Columns[1].HeaderText = "departmentName_lao";
            dataGridView1.Columns[2].HeaderText = "departmentName_eng";
            dataGridView1.Columns[2].Width = 220;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[0].Width = 140;

        }
        private void department_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            departmentreport de = new departmentreport();
            de.Show();
        }

        private void ສາຂາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            department dep = new department();
            this.Hide();
            dep.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            sql = @"insert into tbdepartment values (@id,@nl,@nn)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@nl", cb1.SelectedItem);
          
            cmd.Parameters.AddWithValue("@nn", cb2.SelectedItem);
            cmd.ExecuteNonQuery();
            showdata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = @"update tbdepartment set dep_name_lao=@nl,dep_name_eng=@ne where dep_id=@id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nl", cb1.SelectedItem);
            cmd.Parameters.AddWithValue("@ne", cb2.SelectedItem);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.ExecuteNonQuery();
            showdata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = "delete from tbdepartment where dep_id='"+ textBox1.Text +"'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            showdata();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            cb1.SelectedItem = dataGridView1.CurrentRow.Cells[1].Value.ToString();               
            cb2.SelectedItem = dataGridView1.CurrentRow.Cells[2].Value.ToString();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
