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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = connect.GetConnection();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader re;
        string sql = "";
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ທ່ານຕ້ອງການອອກບໍ?", "ເຕືອນ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //this.Close();
                Application.Exit();
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpassword.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select * from tbcreate_account where username='" + txtuser.Text + "' and password= '" + pass + "'";
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

               /* cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@use", txtuser.Text);
                cmd.Parameters.AddWithValue("@pass", pass);*/
                if (dt.Rows .Count ==1)
                {
                    dt.Clear();
                    home h1 = new home();
                    this.Hide();
                    h1.Show();

                }
                else
                {
                    MessageBox.Show("ກະລຸນາກວດເບິ່ງລະຫັດແລະຊື່ຜູ້ໃຊ້ໃໝ່", "ແຈ້ງເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtpassword.Clear();
                    txtuser.Clear();
                }
            }
            catch (Exception q)
            {

                MessageBox.Show(q.Message);
            }
          

        }
        string pass = "";
        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            pass = txtpassword.Text;
        }
    }
}
