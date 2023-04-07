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
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }
        Student newMDIChild;
        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newMDIChild == null)
            {

                Student newMDIChild = new Student();
                // Set the Parent Form of the Child window.
                newMDIChild.FormClosed += new FormClosedEventHandler(newMDIChild_formClosed);
                newMDIChild.MdiParent = this;
                // Display the new form.
                newMDIChild.Show();
            }
            else
                newMDIChild.Activate();



           
        }

        private void newMDIChild_formClosed(object sender, FormClosedEventArgs e)
        {
            newMDIChild=null;
            //throw new NotImplementedException();
        }

        private void teacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Teacher newMDIChil= new Teacher();
            //// Set the Parent Form of the Child window.
            //newMDIChil.MdiParent = this;
            //// Display the new form.
            //newMDIChil.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void subgradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //subgrade newMDIChil = new subgrade();
            //// Set the Parent Form of the Child window.
            //newMDIChil.MdiParent = this;
            //// Display the new form.
            //newMDIChil.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (t1.Text == "")
            {
                MessageBox.Show("please insert data before insert...", "Notifymessage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                try
                {
                    this.BackColor = Color.Gray;
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;Initial" +
                        " Catalog=Agut;Integrated Security=True";
                    SqlCommand CM = new SqlCommand("insert into parent1 values(@parent_id,@fname," +
                        "@lname,@DOB,@phone)", conn);

                    conn.Open();
                    CM.Parameters.AddWithValue("@parent_id", t1.Text);
                    CM.Parameters.AddWithValue("@fname", t2.Text);
                    CM.Parameters.AddWithValue("@lname", t3.Text);
                    CM.Parameters.AddWithValue("@DOB", DateTime.Now.ToString(t4.Text));
                    CM.Parameters.AddWithValue("@phone", t5.Text);
                    CM.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("successfully saved!!!");
                    t1.Clear(); t2.Clear(); t3.Clear(); t4.Clear(); t5.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t1.Text == "")
            {
                MessageBox.Show("please insert data.", "Notifymessage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                        "Catalog=Agut;Integrated Security=True";
                    conn.Open();

                    SqlCommand CMD = new SqlCommand("update parent1 set fname=@fname," +
                        "lname=@lname,DOB=@DOB,phone=@phone  where parent_id=@parent_id ", conn);

                    CMD.Parameters.AddWithValue("@parent_id", t1.Text);
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

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            SqlCommand CMD = new SqlCommand("Select*from parent1", conn);
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                
                 // dataGridView1.SelectedColumns;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                    "Catalog=Agut;Integrated Security=True";
                conn.Open();
                SqlCommand CMD = new SqlCommand("Select*from parent1", conn);
                SqlDataAdapter da = new SqlDataAdapter(CMD);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (t1.Text == "")
            {
                MessageBox.Show("please insert data.", "Notifymessage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                    "Catalog=Agut;Integrated Security=True";
                conn.Open();
                SqlCommand CMD = new SqlCommand("Delete parent1 where parent_id=@parent_id", conn);
                CMD.Parameters.AddWithValue("@parent_id", t1.Text);
                CMD.ExecuteNonQuery();
                this.BackColor = Color.Green;
                conn.Close();
                MessageBox.Show("Successfully Deleted");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SearchData(txtsearch.Text);
        }
        public void SearchData(string search)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            string query = "select*from parent1 where fname like '%" + search + "%'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
