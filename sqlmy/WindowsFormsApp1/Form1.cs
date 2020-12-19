using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(SqlConnection cn = cn1.cnn)
            {
                cn.Open();
                SqlCommand con = new SqlCommand();
                con.Connection = cn;
                con.CommandText =                    
                    $"Select Birthday From Account Where AccountID = '0000000005'";
                MessageBox.Show(con.ExecuteScalar().ToString());
                //SqlDataReader dr = con.ExecuteReader();
                //while (dr.Read())
                //{
                //    if (! dr.Equals(DBNull.Value))
                //    {
                //        comboBox1.Items.Add(dr[0].ToString());
                //    }
                //}
            }
        }
    }
}
