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
    public partial class home : Form
    {
        Form1 f1 = new Form1();
        public static string str = string.Format("Data Source=MSI;Initial Catalog=csharplab;Integrated Security=True");
        SqlConnection conn = connect.GetConnection();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds =new DataSet();
        string sql = "";
        public home()
        {
            InitializeComponent();
        }
        
        public void showdata()
        {
            sql = "select * from tbstaff";
            da = new SqlDataAdapter(sql,conn);
            da.Fill(ds, "staff");
            if (ds.Tables["staff"]!=null)
            {
                ds.Tables.Clear();
                da.Fill(ds, "staff");
            }dataGridView1.DataSource = ds.Tables["staff"];
                dataGridView1.Refresh();
            dataGridView1.Columns[0].HeaderText = "studentID";
            dataGridView1.Columns[14].HeaderText = "quelification";
            dataGridView1.Columns[15].HeaderText = "position";
            dataGridView1.Columns[16].HeaderText = "department";
            dataGridView1.Columns[2].Width =100;
            dataGridView1.Columns[3].Width =100;
            dataGridView1.Columns[4].Width =100;
            dataGridView1.Columns[7].Width =100;
            dataGridView1.Columns[8].Width = 100 ;
            dataGridView1.Columns[9].Width =100;
            dataGridView1.Columns[10].Width =100;
            dataGridView1.Columns[16].Width=120;
            dataGridView1.Columns[15].Width =120;
            dataGridView1.Columns[14].Width=100;
            dataGridView1.Columns[13].Width=100;
         dataGridView1.Columns[0].Width=100;


        }
        private void ວດທການສສາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qualification qua = new qualification();
            qua.Show();
            //this.Hide();
        }

        private void ການຕດຕToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ທ່ານຕ້ອງການອອກບໍ?", "ເຕືອນ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
                ///  Dispose();
               
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ທ່ານຕ້ອງການອອກບໍ?", "ເຕືອນ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                f1.Show();
                this.Hide();
            }
        }

        private void ຂມນພນຖານToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ສາຂາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            department dep = new department() ;
           // this.Hide();
            dep.Show();
        }

        private void home_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void ພະນກງານToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff s = new staff();
            s.Show();
        }

        private void ຕຳແໜງToolStripMenuItem_Click(object sender, EventArgs e)
        {
            position po = new position();
            po.Show();
            //this.Hide();
        }

        private void ສາງToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Createuser us = new Createuser();
            us.Show();
        }

        private void ເງນເດອນພນຖານToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saraly sa = new saraly();
            sa.Show();
        }

        private void ຜໃຊToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            saraly sa = new saraly();
            sa.Hide();
            sa.Show();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            staff gg = new staff();
            gg.Show();
        }
    }
}
