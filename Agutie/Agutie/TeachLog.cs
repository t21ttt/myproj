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

namespace Agutie
{
    public partial class TeachLog : Form
    {
        public TeachLog()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void login2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" +
            //    "Initial Catalog=Agut;Integrated Security=True";
            //conn.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from LOG1 Where username ='" + t3.Text + "' and password ='" + t4.Text + "'  ", conn);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //if (dt.Rows[0][0].ToString() == "1")
            //{
            //    Student f3 = new Student();
            //    this.Hide();
            //    f3.Show();
            //}
            //else
            //{
            //    MessageBox.Show(" Wrong UserName or Password");
            //}
            //conn.Close();

            






            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" +
                "Initial Catalog=Agut;Integrated Security=True";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from LOG1 Where username ='" + t1.Text + "' and password ='" + t2.Text + "'  ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Teacher tr = new Teacher();
                tr.Show();
            }
            else
            {
                MessageBox.Show(" Wrong UserName or Password");
            }
            conn.Close();









        }

        private void button3_Click(object sender, EventArgs e)
        {
            //t3.Clear();
            //t4.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t1.Clear();
            t2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    

    

