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
    public partial class subgrade : Form
    {
        public subgrade()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txt3.Text == "")
            {
                MessageBox.Show("please insert data.", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                        "Catalog=Agut;Integrated Security=True";

                    conn.Open();
                    SqlCommand CMD = new SqlCommand("insert into Grade1 values( @gr_id)", conn);


                    CMD.Parameters.AddWithValue("@gr_id", txt3.Text);
                    CMD.ExecuteNonQuery();
                    this.BackColor = Color.Green;
                    conn.Close();
                    MessageBox.Show("Successfully Saved");
                    txt3.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            SqlCommand CMD = new SqlCommand("Select*from  Grade1", conn);
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                    "Catalog=Agut;Integrated Security=True";
                conn.Open();
                SqlCommand CMD = new SqlCommand("Select*from Grade1", conn);
                SqlDataAdapter da = new SqlDataAdapter(CMD);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            dataGridView1.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {


            if (txt3.Text == "")
            {
                MessageBox.Show("please insert data.", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                    "Catalog=Agut;Integrated Security=True";
                conn.Open();
                SqlCommand CMD = new SqlCommand("Delete Grade1 where gr_id=@gr_id", conn);
                CMD.Parameters.AddWithValue("@gr_id", txt3.Text);
                CMD.ExecuteNonQuery(); this.BackColor = Color.Green;
                conn.Close();
                MessageBox.Show("Successfully Deleted");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (txt4.Text == "")
            {
                MessageBox.Show("please insert data.", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SearchData(txt4.Text);
            }
        }
        public void SearchData(string search)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            string query = "select*from Grade1 where gr_id like '%" + search + "%'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


        }

        private void button18_Click(object sender, EventArgs e)
        {

            if (txt3.Text == "")
            {
                MessageBox.Show("please insert data.", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                        "Catalog=Agut;Integrated Security=True";

                    conn.Open();
                    SqlCommand CMD = new SqlCommand("insert into Class_Room1 values( @CR_ID,@Building)", conn);


                    CMD.Parameters.AddWithValue("@CR_ID", txt1.Text);
                    CMD.Parameters.AddWithValue("@Building", txt2.Text);
                    CMD.ExecuteNonQuery();
                    this.BackColor = Color.Green;
                    conn.Close();
                    MessageBox.Show("Successfully Saved");
                    txt3.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            SqlCommand CMD = new SqlCommand("Select*from Class_Room1", conn);
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txt3.Text == "")
            {
                MessageBox.Show("please insert data.", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                        "Catalog=Agut;Integrated Security=True";
                    conn.Open();

                    SqlCommand CMD = new SqlCommand("update Class_Room1 set " +
                        " Building=@Building where CR_ID=@CR_ID", conn);

                    CMD.Parameters.AddWithValue("@CR_ID", txt1.Text);
                    CMD.Parameters.AddWithValue("@Building ", txt2.Text);


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

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                    "Catalog=Agut;Integrated Security=True";
                conn.Open();
                SqlCommand CMD = new SqlCommand("Select*from Class_Room1", conn);
                SqlDataAdapter da = new SqlDataAdapter(CMD);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            dataGridView1.Refresh();
        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (txt3.Text == "")
            {
                MessageBox.Show("please insert data.", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                    "Catalog=Agut;Integrated Security=True";
                conn.Open();
                SqlCommand CMD = new SqlCommand("Delete  Class_Room1 where CR_ID=@CR_ID", conn);
                CMD.Parameters.AddWithValue("@CR_ID", txt1.Text);
                CMD.ExecuteNonQuery(); this.BackColor = Color.Green;
                conn.Close();
                MessageBox.Show("Successfully Deleted");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnection conn = new SqlConnection();
            //    conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;Initial" +
            //        " Catalog=Agut;Integrated Security=True";
            //    SqlCommand CM = new SqlCommand("insert into subject1 values(@sub_id,@S_name," +
            //        "@gr_id,@teach_id,@stud_id)", conn);

            //    conn.Open();
            //    CM.Parameters.AddWithValue("@sub_id", t1.Text);
            //    CM.Parameters.AddWithValue("@S_name", t2.Text);
            //    CM.Parameters.AddWithValue("@gr_id", t3.Text);
            //    CM.Parameters.AddWithValue("@teach_id", t4.Text);
            //    CM.Parameters.AddWithValue("@stud_id", t5.Text);
            //    CM.ExecuteNonQuery();
            //    conn.Close();
            //    MessageBox.Show("successfully saved!!!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            SqlCommand CMD = new SqlCommand("Select*from subject1", conn);
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                    "Catalog=Agut;Integrated Security=True";
                conn.Open();
                SqlCommand CMD = new SqlCommand("Select*from subject1", conn);
                SqlDataAdapter da = new SqlDataAdapter(CMD);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
            //    "Catalog=Agut;Integrated Security=True";
            //conn.Open();
            //SqlCommand CMD = new SqlCommand("Delete subject1 where sub_id=@sub_id", conn);
            //CMD.Parameters.AddWithValue("@sub_id", t1.Text);
            //CMD.ExecuteNonQuery(); this.BackColor = Color.Green;
            //conn.Close();
            //MessageBox.Show("Successfully Deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnection conn = new SqlConnection();
            //    conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
            //        "Catalog=Agut;Integrated Security=True";
            //    conn.Open();

            //    SqlCommand CMD = new SqlCommand("update subject1 set S_name=@S_name," +
            //        "gr_id=@gr_id,teach_id=@teach_id,stud_id=@stud_id where sub_id=@sub_id ", conn);

            //    CMD.Parameters.AddWithValue("@sub_id", t1.Text);
            //    CMD.Parameters.AddWithValue("@S_name", t2.Text);
            //    CMD.Parameters.AddWithValue("@gr_id", t3.Text);
            //    CMD.Parameters.AddWithValue("@teach_id",  t4.Text);
            //    CMD.Parameters.AddWithValue("@stud_id", t5.Text);

            //    CMD.ExecuteNonQuery();
            //    this.BackColor = Color.Brown;
            //    conn.Close();
            //    MessageBox.Show("Successfully Updated");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void button20_Click(object sender, EventArgs e)
        {
           // SearchData1(txtsearch.Text);
        }
        public void SearchData1(string search)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            string query = "select*from subject1 where sub_id like '%" + search + "%'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBoxsearch.Text == "")
            {
                MessageBox.Show("please insert data.", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SearchData3(textBoxsearch.Text);
            }
        }
        public void SearchData3(string search)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            string query = "select*from Class_Room1 where Building like '%" + search + "%'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void subgrade_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
