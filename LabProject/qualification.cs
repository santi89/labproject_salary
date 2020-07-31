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
    public partial class qualification : Form
    {
        SqlConnection conn = connect.GetConnection();

        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string sql = "";
        public qualification()
        {
            InitializeComponent();
        }
        public void showdata()
        {
            sql = "select * from tbqualigication";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "staff");
            if (ds.Tables["staff"] != null)
            {
                ds.Tables.Clear();
                da.Fill(ds, "staff");
            }
            dataGridView1.DataSource = ds.Tables["staff"];
            dataGridView1.Refresh();
            dataGridView1.Columns[0].HeaderText = "qualificationID";
            dataGridView1.Columns[1].HeaderText = "qualificationName_lao";
            dataGridView1.Columns[2].HeaderText = "qualificationName_eng";
            dataGridView1.Columns[2].Width = 220;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[0].Width = 140;


        }
        private void qualification_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            qualificationreport re = new qualificationreport();
            re.Show();
        }

        private void ສາຂາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            department dep = new department();
            this.Hide();
            dep.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "insert into tbqualigication values(@id,@lao,@eng)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@lao", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@eng", comboBox2.SelectedItem);
            cmd.ExecuteNonQuery();
            showdata();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == comboBox1.FindString("ປ ຕີ"))
            {
                comboBox2.ResetText();
                comboBox2.SelectedItem = "bachelor";
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindString("ປ ໂທ"))
            {
                comboBox2.ResetText();
                comboBox2.SelectedItem = "master";
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindString("ປ ເອກ"))
            {
                comboBox2.ResetText();
                comboBox2.SelectedItem = "PH.D";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == comboBox2.FindString("bachelor"))
            {
                comboBox1.ResetText();
                comboBox1.SelectedItem = "ປ ຕີ";
            }
            else if (comboBox2.SelectedIndex == comboBox2.FindString("master"))
            {
                comboBox1.ResetText();
                comboBox1.SelectedItem = "ປ ໂທ";
            }
            else if (comboBox2.SelectedIndex == comboBox2.FindString("PH.D"))
            {
                comboBox1.ResetText();
                comboBox1.SelectedItem = "ປ ເອກ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = "update tbqualigication set qu_name_lao=@lao,qu_name_eng=@eng where qu_id=@id";
            cmd = new SqlCommand(sql, conn);
            
            cmd.Parameters.AddWithValue("@lao", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@eng", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.ExecuteNonQuery();
            showdata();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = "delete from tbqualigication where qu_id=@id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.ExecuteNonQuery();
            showdata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox2.SelectedItem = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
