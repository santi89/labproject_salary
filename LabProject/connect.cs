using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    class connect
    {
        static  SqlConnection con = new SqlConnection();
        public static SqlConnection GetConnection() { 
          string strss = string .Format ("Data Source=MSI;Initial Catalog=csharplab;Integrated Security=True");
        if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
         con.ConnectionString = strss;
                con.Open();
                return con;
        }

       
        
        //SqlCommand cmd = new SqlCommand();
        //public static void connected()
        //{
        //    con.ConnectionString = str;
        //    con.Open();
        //}
        
        }
    }

