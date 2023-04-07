using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agutie
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (t1.Text == "")
            {
                MessageBox.Show("please insert data,", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                        "Catalog=Agut;Integrated Security=True";

                    conn.Open();
                    SqlCommand CMD = new SqlCommand("insert into Student1 values(@stud_id,@fname," +
                                                      "@lname,@DOB,@phone,@gr_id,@parent_id)", conn);



                    CMD.Parameters.AddWithValue("@stud_id", t1.Text);
                    CMD.Parameters.AddWithValue("@fname", t2.Text);
                    CMD.Parameters.AddWithValue("@lname", t3.Text);
                    CMD.Parameters.AddWithValue("@DOB", DateTime.Now.ToString(t4.Text));
                    CMD.Parameters.AddWithValue("@phone", t5.Text);
                    CMD.Parameters.AddWithValue("@gr_id", t6.Text);
                    CMD.Parameters.AddWithValue("@parent_id", txtparentid.Text);
                    DialogResult d = MessageBox.Show("do you want to insert", "confirmation",
                    MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        CMD.ExecuteNonQuery();
                        //this.BackColor = Color.Green;
                        conn.Close();
                        MessageBox.Show("Successfully Saved");

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                t1.Clear(); t2.Clear(); t3.Clear(); t4.Clear(); t5.Clear(); t6.Clear();
                txtparentid.Clear();
            }
        }
          void display()
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            SqlCommand CMD = new SqlCommand("Select*from Student1", conn);
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            SqlCommand CMD = new SqlCommand("Select*from Student1", conn);
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (t1.Text == "")
            {
                MessageBox.Show("please insert data,", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                    "Catalog=Agut;Integrated Security=True";
                conn.Open();
                SqlCommand CMD = new SqlCommand("Delete Student1 where stud_id=@stud_id", conn);
                CMD.Parameters.AddWithValue("@stud_id", t1.Text);
                DialogResult d = MessageBox.Show("do you want to delete", "confirmation",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    CMD.ExecuteNonQuery();
                    this.BackColor = Color.Green;
                    MessageBox.Show("Successfully Deleted");
                    conn.Close();
                }
                display();



            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (t1.Text == "")
            {
                MessageBox.Show("please insert data,", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                        "Catalog=Agut;Integrated Security=True";
                    conn.Open();

                    SqlCommand CMD = new SqlCommand("update Student1 set fname=@fname," +
                   "lname=@lname where stud_id=@stud_id", conn);

                    CMD.Parameters.AddWithValue("@stud_id", t1.Text);
                    CMD.Parameters.AddWithValue("@fname", t2.Text);
                    CMD.Parameters.AddWithValue("@lname", t3.Text);


                    CMD.ExecuteNonQuery();
                    this.BackColor = Color.Green;
                    conn.Close();
                    MessageBox.Show("Successfully Updated");
                    t1.Clear(); t2.Clear(); t3.Clear(); t4.Clear();
                    t5.Clear(); txtparentid.Clear(); t6.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                    "Catalog=Agut;Integrated Security=True";
                conn.Open();
                SqlCommand CMD = new SqlCommand("Select*from Student1", conn);
                SqlDataAdapter da = new SqlDataAdapter(CMD);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            dataGridView1.Refresh();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("please insert data,", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SearchData(textBox1.Text);
            }
        }
        public void SearchData(string search)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            string query = "select*from Student1 where fname like '%" + search + "%'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


        }

        private void button12_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                    "Catalog=Agut;Integrated Security=True";

                conn.Open();
                SqlCommand CMD = new SqlCommand("insert into EXAM_RESULT1 values(@Sub_ID,@StudID," +
                                                  "@Score)", conn);

                CMD.Parameters.AddWithValue("@Sub_ID", t7.Text);
                CMD.Parameters.AddWithValue("@StudID", t8.Text);
                CMD.Parameters.AddWithValue("@Score", t9.Text);
                DialogResult d = MessageBox.Show("do you want to delete", "confirmation",
               MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    CMD.ExecuteNonQuery();
                    this.BackColor = Color.Green;
                    conn.Close();
                    MessageBox.Show("Successfully Saved");

                }


               
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                    "Catalog=Agut;Integrated Security=True";
                conn.Open();

                SqlCommand CMD = new SqlCommand("update EXAM_RESULT1 set StudID=@StudID," +
                                                  "Score=@Score where Sub_ID=@Sub_ID", conn);

                CMD.Parameters.AddWithValue("@Sub_ID", t7.Text);
                CMD.Parameters.AddWithValue("@StudID", t8.Text);
                CMD.Parameters.AddWithValue("@Score", t9.Text);
                 
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

        private void button8_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                    "Catalog=Agut;Integrated Security=True";
                conn.Open();
                SqlCommand CMD = new SqlCommand("Select*from EXAM_RESULT1", conn);
                SqlDataAdapter da = new SqlDataAdapter(CMD);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            dataGridView1.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            SqlCommand CMD = new SqlCommand("Select*from EXAM_RESULT1", conn);
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SearchData2(textBox2.Text);
        }
        public void SearchData2(string search)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            string query = "select*from EXAM_RESULT1 where fname like '%" + search + "%'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            SqlCommand CMD = new SqlCommand("Delete EXAM_RESULT1 where StudID=@StudID", conn);
            CMD.Parameters.AddWithValue("@StudID", t8.Text);
            CMD.ExecuteNonQuery(); this.BackColor = Color.Green;
            conn.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawImage(bitmap, 0, 0);
             
              }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
            
              
            
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void t2_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^[A-Za-z\s]+$")).IsMatch(t2.Text))
            {
                t2.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Invalid first name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void t3_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^[A-Za-z\s]+$")).IsMatch(t3.Text))
            {
                t3.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Invalid Last name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void t1_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^[0-9\s]{1,4}$")).IsMatch(t1.Text))
            {
                t1.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Invalid student id.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void t5_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^[0-9\s]{0,10}$")).IsMatch(t5.Text))
            {
                t5.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Invalid phone number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtparentid_TextChanged(object sender, EventArgs e)
        {

            

             
            }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Bitmap bitmap;
        private void button15_Click_1(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowTemplate.Height * 7;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            printPreviewDialog2.PrintPreviewControl.Zoom = 1;
            printPreviewDialog2.ShowDialog();
            dataGridView1.Height = height;
        }

        private void button16_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            SqlCommand CMD = new SqlCommand(" SELECT Stud_id,fname,lname,Sub_id, Score FROM Student1 INNER JOIN EXAM_RESULT1 ON Student1.Stud_id = Student1.Stud_id	", conn);
              SqlDataAdapter da = new SqlDataAdapter(CMD);
              DataTable dt = new DataTable();
              da.Fill(dt);
              dataGridView1.DataSource = dt;
            
        }
    }
               
    }
