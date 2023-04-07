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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t1.Text == "")
            {
                MessageBox.Show("please insert data.", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;Initial" +
                        " Catalog=Agut;Integrated Security=True";
                    SqlCommand CM = new SqlCommand("insert into teacher1 values(@teach_id,@fname," +
                        "@lname,@DOB,@phone)", conn);

                    conn.Open();
                    CM.Parameters.AddWithValue("@teach_id", t1.Text);
                    CM.Parameters.AddWithValue("@fname", t2.Text);
                    CM.Parameters.AddWithValue("@lname", t3.Text);
                    CM.Parameters.AddWithValue("@DOB", DateTime.Now.ToString(t4.Text));
                    CM.Parameters.AddWithValue("@phone", t5.Text);
                    CM.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("successfully saved!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (t1.Text == "")
            {
                MessageBox.Show("please insert data.", " message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SearchData(txtsearchteacher.Text);
            }
        }
        public void SearchData(string search)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            string query = "select*from teacher1 where fname like '%" + search + "%'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            SqlCommand CMD = new SqlCommand("Select*from teacher1", conn);
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t1.Text == "")
            {
                MessageBox.Show("please insert data.", " message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                        "Catalog=Agut;Integrated Security=True";
                    conn.Open();

                    SqlCommand CMD = new SqlCommand("update teacher1 set fname=@fname," +
                        "lname=@lname,DOB=@DOB,phone=@phone  where teach_id=@teach_id ", conn);

                    CMD.Parameters.AddWithValue("@teach_id", t1.Text);
                    CMD.Parameters.AddWithValue("@fname", t2.Text);
                    CMD.Parameters.AddWithValue("@lname", t3.Text);
                    CMD.Parameters.AddWithValue("@DOB", DateTime.Now.ToString(t4.Text));
                    CMD.Parameters.AddWithValue("@phone", t5.Text);

                    CMD.ExecuteNonQuery();
                    this.BackColor = Color.Brown;
                    conn.Close();
                    MessageBox.Show("Successfully Updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (t1.Text == "")
            {
                MessageBox.Show("please insert data.", " message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                    "Catalog=Agut;Integrated Security=True";
                conn.Open();
                SqlCommand CMD = new SqlCommand("Delete teacher1 where teach_id=@teach_id", conn);
                CMD.Parameters.AddWithValue("@teach_id", t1.Text);
                CMD.ExecuteNonQuery();
                this.BackColor = Color.Green;
                conn.Close();
                MessageBox.Show("Successfully Deleted");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
        
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                    "Catalog=Agut;Integrated Security=True";
                conn.Open();
                SqlCommand CMD = new SqlCommand("Select*from teacher1", conn);
                SqlDataAdapter da = new SqlDataAdapter(CMD);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            dataGridView1.Refresh();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            SqlCommand CMD = new SqlCommand("Select*from teacher1", conn);
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
