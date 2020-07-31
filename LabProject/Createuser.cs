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
    public partial class Createuser : Form
    {
        Form1 f1 = new Form1();
        public Createuser()
        {
            InitializeComponent();
            
        }
        SqlConnection con = connect.GetConnection();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader re;
        string sql = "";
        private void button2_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("ທ່ານຕ້ອງການອອກບໍ?", "ເຕືອນ", MessageBoxButtons.YesNo);
            txtrepass.Clear();
            txtpass.Clear();
            txtname.Clear();
            txtuser.Clear ();
            comboBox1.Items.Clear(); 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpass .Text ==txtrepass .Text)
            {
            sql = "insert into tbcreate_account values((select st_id from tbstaff where name_lao=@st_id),(select pos_id from tbposition where pos_name_lao=@pos),@username,@pass)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@st_id", txtname.Text);
            cmd.Parameters.AddWithValue("@pos",comboBox1 .SelectedItem );
            cmd.Parameters.AddWithValue("@username", txtuser .Text);
            cmd.Parameters.AddWithValue("@pass", txtpass .Text);
           if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("ll");
                    txtrepass.Clear();
                    txtpass.Clear();
                    txtname.Clear();
                    txtuser.Clear();
                    comboBox1.Items.Clear();
                }
                
            }else
            {
                MessageBox.Show("password not match");
                txtrepass.Clear();
                txtpass.Clear();
                
            }
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
