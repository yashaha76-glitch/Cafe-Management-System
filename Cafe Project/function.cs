using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cafe_Project
{
    class function
    {
        protected MySqlConnection getConnection()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;uid=root;pwd=yasha123.;database=yashadb;";
            return con;
        }

        public DataSet getData(string query)
        {
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData (string query)
        {
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Processed Successfully.","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
