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
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }

        SqlConnection conn = connect.GetConnection();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        SqlDataReader re;
        string sql = "";
        private void showdata()
        {
            sql = "select * from tbstaff ";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "staff");
            if (ds.Tables["staff"] != null)
            {
                ds.Tables.Clear();
                da.Fill(ds, "staff");
            }
            dataGridView1.DataSource = ds.Tables["staff"];
           // dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
            dataGridView1.Columns[0].HeaderText = "StaffID";
            dataGridView1.Columns[14].HeaderText = "quelification";
            dataGridView1.Columns[15].HeaderText = "position";
            dataGridView1.Columns[16].HeaderText = "department";
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[7].Width = 120;
            dataGridView1.Columns[8].Width = 120;
            dataGridView1.Columns[9].Width = 120;
            dataGridView1.Columns[10].Width = 120;
            dataGridView1.Columns[16].Width = 140;
            dataGridView1.Columns[15].Width = 140;
            dataGridView1.Columns[14].Width = 120;
            dataGridView1.Columns[13].Width = 120;
            dataGridView1.Columns[0].Width = 120;

        }

        private void comboqui()
        {
            sql = "select qu_name_lao from tbqualigication";
            cmd = new SqlCommand(sql, conn);
            re = cmd.ExecuteReader();
            cbqui.Items.Clear();
            while (re.Read())
            {
                cbqui.Items.Add(re.GetString(0));
            }re.Close();
        }
        private void combopos()
        {
            sql = "select pos_name_lao from tbposition";
            cmd = new SqlCommand(sql, conn);
            re = cmd.ExecuteReader();
            cbpos.Items.Clear();
            while (re.Read())
            {
                cbpos.Items.Add(re.GetString(0));
            }
            re.Close();
        }
        private void combodep()
        {
            sql = "select dep_name_lao from tbdepartment";
            cmd = new SqlCommand(sql, conn);
            re = cmd.ExecuteReader();
            cbdept .Items.Clear();
            while (re.Read())
            {
                cbdept .Items.Add(re.GetString(0));
            }
            re.Close();
        }
        private void staff_Load(object sender, EventArgs e)
        {
            showdata();
            comboqui();
            combodep();
            combopos();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into tbstaff values (@id,@nlao,@surlao,@neng,@sureng,@sex,@sta,@dateof,@provin,@dist,@vill,@tel,@email,@face,(select qu_id from tbqualigication where qu_name_lao=@quid),(select pos_id from tbposition where pos_name_lao=@posid),(select dep_id from tbdepartment where dep_name_lao=@dep))";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", txtid.Text);
                cmd.Parameters.AddWithValue("@nlao", txtnamelao.Text);
                cmd.Parameters.AddWithValue("@surlao", txtsurnamelao.Text);
                cmd.Parameters.AddWithValue("@neng", txtnameeng.Text);
                cmd.Parameters.AddWithValue("@sureng", txtsurnameeng.Text);
                string sex = "";
                if (rbmale.Checked == true)
                {
                    sex = "male";
                }
                else if (rbfemale.Checked == true)
                {
                    sex = "female";
                }
                cmd.Parameters.AddWithValue("@sex", sex);
                cmd.Parameters.AddWithValue("@sta", txtstatus.Text);
                cmd.Parameters.AddWithValue("@dateof", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@provin", txtprovince.Text);
                cmd.Parameters.AddWithValue("@dist", txtdistrict.Text);
                cmd.Parameters.AddWithValue("@vill", txtvillage.Text);
                cmd.Parameters.AddWithValue("@tel", txttel.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@face", txtfacebook.Text);
                cmd.Parameters.AddWithValue("@quid", cbqui.SelectedItem);
                cmd.Parameters.AddWithValue("@posid", cbpos.SelectedItem);
                cmd.Parameters.AddWithValue("@dep", cbdept.SelectedItem);
                cmd.ExecuteNonQuery();
                showdata();
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            sql = "delete from tbstaff where st_id=@id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", txtid.Text); ;
            cmd.ExecuteNonQuery();
            showdata();
        }

        private void btedit_Click(object sender, EventArgs e)
        {
         sql = "update tbstaff set name_lao=@nlao,surname_lao=@surlao,name_eng=@neng,surname_eng=@sureng,gender=@sex,statuses=@sta,datebirth=@dateof,province_now=@provin,district_now=@dist,village_now=@vill,mobile=@tel,email=@email,facebook=@face,qu_id=(select qu_id from tbqualigication where qu_name_lao=@quid),pos_id=(select pos_id from tbposition where pos_name_lao=@posid),dep_id=(select dep_id from tbdepartment where dep_name_lao=@dep) where st_id=@id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nlao", txtnamelao.Text);
            cmd.Parameters.AddWithValue("@surlao", txtsurnamelao.Text);
            cmd.Parameters.AddWithValue("@neng", txtnameeng.Text);
            cmd.Parameters.AddWithValue("@sureng", txtsurnameeng.Text);
            string sex = "";
            if (rbmale.Checked == true)
            {
                sex = "male";
            }
            else if (rbfemale.Checked == true)
            {
                sex = "female";
            }
            cmd.Parameters.AddWithValue("@sex", sex);
            cmd.Parameters.AddWithValue("@sta", txtstatus.Text);
            cmd.Parameters.AddWithValue("@dateof", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@provin", txtprovince.Text);
            cmd.Parameters.AddWithValue("@dist", txtdistrict.Text);
            cmd.Parameters.AddWithValue("@vill", txtvillage.Text);
            cmd.Parameters.AddWithValue("@tel", txttel.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@face", txtfacebook.Text);

            cmd.Parameters.AddWithValue("@quid", cbqui.SelectedItem);
            cmd.Parameters.AddWithValue("@posid", cbpos.SelectedItem);
            cmd.Parameters.AddWithValue("@dep", cbdept.SelectedItem);
            cmd.Parameters.AddWithValue("@id", txtid.Text);

            cmd.ExecuteNonQuery();
            showdata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnamelao.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsurnamelao.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtnameeng .Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtsurnameeng .Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string ss;
            if ("male"== dataGridView1.CurrentRow.Cells[5].Value.ToString())
            {
              rbmale.Checked = true;
            }
            else if ("female"== dataGridView1.CurrentRow.Cells[5].Value.ToString())
            {
                rbfemale.Checked = true;
            }
           
            txtstatus .Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker1.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtprovince.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtdistrict.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtvillage.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txttel.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtemail.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtfacebook .Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            cbqui.SelectedItem = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            cbpos.SelectedItem = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            cbdept.SelectedItem = dataGridView1.CurrentRow.Cells[16].Value.ToString();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            restaff rs = new restaff();
            rs.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
