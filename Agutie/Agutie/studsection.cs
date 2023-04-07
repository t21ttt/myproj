using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Agutie
{
    public partial class studsection : Form
    {
        public studsection()
        {
            InitializeComponent();
        }
       
        private void studsection_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = loaddata();
            fillCombo();


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            //DataTable DT = new DataTable();

           // SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd;
            //DataSet ds = new DataSet();
            String quer = "select stud_id,fname,lname from Student1 ";
            cmd = new SqlCommand(quer, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

           // da.SelectCommand = cmd;
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
            DataGridViewCheckBoxColumn che = new DataGridViewCheckBoxColumn();
            che.Width = 40;
            che.Name = "check1";
            che.HeaderText = " ";
            dataGridView1.Columns.Insert(0, che);







        }

        private DataTable loaddata()
        {
           SqlConnection conn = new SqlConnection();
           conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
           conn.Open();
           DataTable DT = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd;
            DataSet ds = new DataSet();
            String quer = "select * from Student1";
            cmd = new SqlCommand(quer, conn);
            da.SelectCommand = cmd;
            da.Fill(ds);
            DT = ds.Tables[0];

            return DT;
        }
        private void fillCombo()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd;
            DataSet ds = new DataSet();
            String quer = "select CR_ID from Class_Room1 ";
            cmd = new SqlCommand(quer, conn);
            da.SelectCommand = cmd;
            da.Fill(ds);
            dt = ds.Tables[0];
            
            DataGridViewComboBoxColumn com = new DataGridViewComboBoxColumn();
            com.HeaderText = "sect";
            com.Name = "sect";
            ArrayList ar = new ArrayList();
            foreach(DataRow dr in dt.Rows)
            {
                ar.Add(dr["CR_ID"].ToString());

            }
            com.Items.AddRange(ar.ToArray());
            dataGridView1.Columns.Add(com);

        }
        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    bool select1 = Convert.ToBoolean(row.Cells["check1"].Value);


                    if (select1)
                    {
                        SqlCommand CMD = new SqlCommand("insert into assign values(@stud_id,@fname,@lname,@section)", conn);
                        //CMD.Parameters.AddWithValue(@"stud_id", row.Cells["stud_id"].Value);
                        //CMD.Parameters.AddWithValue(@"fname", row.Cells["fname"].Value);
                        //CMD.Parameters.AddWithValue(@"lname", row.Cells["lname"].Value);
                        //CMD.Parameters.AddWithValue(@"section", row.Cells["section"].Value);


                        CMD.Parameters.Add("@stud_id", SqlDbType.VarChar).Value =row.Cells["stud_id"].Value;
                        CMD.Parameters.Add("@fname", SqlDbType.VarChar).Value = row.Cells["fname"].Value;
                        CMD.Parameters.Add("@lname", SqlDbType.VarChar).Value = row.Cells["lname"].Value;
                        CMD.Parameters.Add("@section", SqlDbType.VarChar).Value =row.Cells["sect"].Value;



                        CMD.ExecuteNonQuery();

                    }

                }
                conn.Close();
                MessageBox.Show(" data inserted succefully");
                //MessageBox.Show(" data inserted succefully");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6PCBB62\\MSSQLSERVER01;" + "Initial " +
                "Catalog=Agut;Integrated Security=True";
            conn.Open();
            SqlCommand CMD = new SqlCommand("Select*from assign", conn);
            SqlDataAdapter dat = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            dat.Fill(dt);
            dataGridView2.DataSource = dt;
        }
    }
}
