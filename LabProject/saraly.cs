using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace LabProject
{
    public partial class saraly : Form
    {
        public saraly()
        {
            InitializeComponent();
        }    
        SqlConnection conn = connect.GetConnection();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string sql = "";

        public void showdata()
        {
            sql = "select * from tbbasic_salary";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "sa");
            if (ds.Tables["sa"] != null)
            {
                ds.Tables.Clear();
                da.Fill(ds, "sa");
            }
            dataGridView1.DataSource = ds.Tables["sa"];
            dataGridView1.Refresh();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "ລະຫັດ";
            dataGridView1.Columns[1].HeaderText = "ຈຳນວນເງິນ";
            dataGridView1.Columns[2].HeaderText = "ຕຳແໜ່ງ";

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saraly_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saraly sa = new saraly();
            sa.Show();
        }

        private void ຂມນພນຖານToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ສາຂາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            department dep = new department();
            this.Hide();
            dep.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "insert into tbbasic_salary values (@id,@amount,@pn)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@amount", textBox2.Text);
            cmd.Parameters.AddWithValue("@pn", comboBox2.SelectedItem);
            cmd.ExecuteNonQuery();
            showdata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = "update tbbasic_salary set amount=@am,pos_name_eng=@pn where bas_id=@bid";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@am", textBox2.Text);
            cmd.Parameters.AddWithValue("@pn", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("@bid", textBox1.Text);
            cmd.ExecuteNonQuery();
            showdata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = "delete * from tbbasic_salary where bas_id=@id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.ExecuteNonQuery();
            showdata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           textBox2.Text  = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox2.SelectedItem = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home h1 = new home();
            h1.Show();
            this.Close();
        }

        private void ພະນກງານToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff s = new staff();
            s.Show();
            this.Close();
        }
    }
}
