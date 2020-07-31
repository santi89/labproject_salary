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
    public partial class position : Form
    {

        SqlConnection conn = connect.GetConnection();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string sql = "";
        public position()
        {
            InitializeComponent();
        }
        public void showdata()
        {
            sql = "select * from tbposition";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "po");
            if (ds.Tables["po"] != null)
            {
                ds.Tables.Clear();
                da.Fill(ds, "po");
            }
            dataGridView1.DataSource = ds.Tables["po"];
            dataGridView1.Refresh();
            dataGridView1.Columns[0].HeaderText = "positionID";
            dataGridView1.Columns[1].HeaderText = "positionName_lao";
            dataGridView1.Columns[2].HeaderText = "positionName_eng";
            dataGridView1.Columns[2].Width = 220;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[0].Width = 140;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = "update tbposition set pos_name_lao=@nl,pos_name_eng=@ne where pos_id=@id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nl", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@ne", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.ExecuteNonQuery();
            showdata();
        }

        private void position_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == comboBox1.FindString("ປະທານ"))
            {
                comboBox2.ResetText();
                comboBox2.SelectedItem = "ADMINISTRATOR";
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindString("ຮອງປະທານ"))
            {
                comboBox2.ResetText();
                comboBox2.SelectedItem = "VICE ADMINISTRATOR";
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindString("ຜູ້ບໍລິຫານ"))
            {
                comboBox2.ResetText();
                comboBox2.SelectedItem = "MANAGER";
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindString("ຫົວໜ້າພະແນກ"))
            {
                comboBox2.ResetText();
                comboBox2.SelectedItem = "HEADOFDEPARTMENT";
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindString("ຮອງພະແນກ"))
            {
                comboBox2.ResetText();
                comboBox2.SelectedItem = "DEPUTY OF DEPARTMENT";
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindString("ພະນັກງານ"))
            {
                comboBox2.ResetText();
                comboBox2.SelectedItem = "EMPLOYEE";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == comboBox1.FindString(" ADMINISTRATOR"))
            {
                comboBox2.ResetText();
                comboBox2.SelectedItem  = "ປະທານ";
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindString("VICE ADMINISTRATOR"))
            {
                comboBox2.ResetText();
                comboBox2.SelectedItem = "ຮອງປະທານ";
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindString("MANAGER"))
            {
                comboBox2.ResetText();
                comboBox2.SelectedItem = "ຜູ້ບໍລິຫານ";
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindString("HEADOFDEPARTMENT"))
            {
                comboBox2.ResetText();
                comboBox2.SelectedItem = "ຫົວໜ້າພະແນກ";
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindString("DEPUTY OF DEPARTMENT"))
            {
                comboBox2.ResetText();
                comboBox2.SelectedItem = "ຮອງພະແນກ";
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindString("EMPLOYEE"))
            {
                comboBox2.ResetText();
                comboBox2.SelectedItem = "ພະນັກງານ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "insert into tbposition values (@id,@namelao,@nameeng)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@namelao", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@nameeng", comboBox2.SelectedItem);
            cmd.ExecuteNonQuery();
            showdata();

        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            positionreport posi = new positionreport();
            posi.Show();
        }

        private void ສາຂາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            department dep = new department();
            this.Hide();
            dep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = "delete from tbposition where pos_id=@id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.ExecuteNonQuery();
            showdata();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1 .SelectedItem = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox2 .SelectedItem = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }

      
}
