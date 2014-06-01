using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data .Sql;
using System .Data .SqlClient ;
namespace TicketAnyTime
{
    public partial class PaymentGateway : Form
    {
        SqlConnection con;
        public PaymentGateway()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=TicketAnytime;Integrated Security=True");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                SqlCommand cmd;
                String s = "insert into payment(Name,CardNumber,CVV)Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";

                cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery();
            
                MessageBox.Show("record inserted");
                con.Close();
                OneTimePassword p = new OneTimePassword();
                p.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }


        private void PaymentGateway_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch))
            {
                e.Handled = true;
                MessageBox.Show("Please enter characters only");
            }



        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsLetter(ch))
            {
                e.Handled = true;
                MessageBox.Show("Please enter numbers only");
            }



        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsLetter(ch))
            {
                e.Handled = true;
                MessageBox.Show("Please enter numbers only");
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}

