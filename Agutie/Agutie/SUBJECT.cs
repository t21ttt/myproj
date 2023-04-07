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
    public partial class SUBJECT : Form
    {
        public SUBJECT()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
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
                    SqlCommand CM = new SqlCommand("insert into subject1 values(@sub_id,@S_name," +
                        "@gr_id,@teach_id,@stud_id)", conn);

                    conn.Open();
                    CM.Parameters.AddWithValue("@sub_id", t1.Text);
                    CM.Parameters.AddWithValue("@S_name", t2.Text);
                    CM.Parameters.AddWithValue("@gr_id", t3.Text);
                    CM.Parameters.AddWithValue("@teach_id", t4.Text);
                    CM.Parameters.AddWithValue("@stud_id", t5.Text);
                    DialogResult d = MessageBox.Show("do you want to delete", "confirmation",
                   MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        CM.ExecuteNonQuery();
                        this.BackColor = Color.Green;
                        conn.Close();
                        MessageBox.Show("Successfully delete");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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

        private void button5_Click(object sender, EventArgs e)
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
                    conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                        "Catalog=Agut;Integrated Security=True";
                    conn.Open();

                    SqlCommand CMD = new SqlCommand("update subject1 set S_name=@S_name," +
                        "gr_id=@gr_id,teach_id=@teach_id,stud_id=@stud_id where sub_id=@sub_id ", conn);

                    CMD.Parameters.AddWithValue("@sub_id", t1.Text);
                    CMD.Parameters.AddWithValue("@S_name", t2.Text);
                    CMD.Parameters.AddWithValue("@gr_id", t3.Text);
                    CMD.Parameters.AddWithValue("@teach_id", t4.Text);
                    CMD.Parameters.AddWithValue("@stud_id", t5.Text);

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
            if (t1.Text == "")
            {
                MessageBox.Show("please insert data.", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                    "Catalog=Agut;Integrated Security=True";
                conn.Open();
                SqlCommand CMD = new SqlCommand("Delete subject1 where sub_id=@sub_id", conn);
                CMD.Parameters.AddWithValue("@sub_id", t1.Text);
                DialogResult d = MessageBox.Show("do you want to delete", "confirmation",
                   MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    CMD.ExecuteNonQuery();
                    this.BackColor = Color.Green;
                    conn.Close();
                    MessageBox.Show("Successfully delete");

                }

            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (t1.Text == "")
            {
                MessageBox.Show("please insert data.", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SearchData1(txtsearch.Text);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void SUBJECT_Load(object sender, EventArgs e)
        {
            dataGridView1.ForeColor = Color.Black;
        }
    }
}
