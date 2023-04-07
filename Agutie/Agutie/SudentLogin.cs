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
    public partial class SudentLogin : Form
    {
        public SudentLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SudentLogin sud = new SudentLogin();
            sud.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            t1.Clear();
            t2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
