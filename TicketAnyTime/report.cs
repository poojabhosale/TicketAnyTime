using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace TicketAnyTime
{
    public partial class report : Form
    {
        SqlConnection con;
        public report(string strTextBox,string strb,string strc,string strd,string stre)
        {
            InitializeComponent();
           
           con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=TicketAnytime;Integrated Security=True ");
           label7.Text = strTextBox;
           label8.Text = strb;
           label9.Text = strc;
           label10.Text = strd;
           label11.Text = stre;

        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentGateway p = new PaymentGateway();
            p.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CentralStation s = new CentralStation();
            s.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void report_Load(object sender, EventArgs e)
        {
            //CentralStation c = new CentralStation();
            //c.Show();
            ////string s = "select date from CentralInsert";
            //SqlDataAdapter sda = new SqlDataAdapter(s, con);
            //DataTable st = new DataTable();
            //sda.Fill(st);
            //for (int i = 0; i < st.Rows.Count; i++)
            //{
              
            //    c.label12.Text = st.Rows[0][i].ToString();
            //}


           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PaymentGateway p = new PaymentGateway();
            p.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CentralStation c = new CentralStation();
            c.Show();
        }
    }
}
