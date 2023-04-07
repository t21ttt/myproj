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
    public partial class MainLog : Form
    {
        public MainLog()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                t2.UseSystemPasswordChar = false;
            }
            else
               t2.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.Clear();
            t2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TeachLog l = new TeachLog();
            this.Hide();
            l.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TeachLog l = new TeachLog();
            this.Hide();
            l.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (t1.Text == " " && t2.Text == " ")
            {
                MessageBox.Show("please login again");

            }
            else
            {
                try
                {


                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" +
                        "Initial Catalog=Agut;Integrated Security=True";
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from LOG1 Where username ='" +
                        t1.Text + "' and password ='" + t2.Text + "'  ", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Home L2 = new Home();
                        L2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(" Wrong UserName or Password");
                    }
                    conn.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeachLog tlog = new TeachLog();
            tlog.Show();
/*
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" +
                "Initial Catalog=Agut;Integrated Security=True";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from LOG1 Where username ='" + t1.Text + "' and password ='" + t2.Text + "'  ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                TeachLog tlog = new TeachLog();
                tlog.Show();
            }
            else
            {
                MessageBox.Show(" Wrong UserName or Password");
            }
            conn.Close();*/
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
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

                Student st = new Student();
                st.Show();
               
            }
            else
            {
                MessageBox.Show(" Wrong UserName or Password");
            }
            conn.Close();
        }
    }
}
