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
    public partial class CentralStation : Form
    {
        SqlConnection con;
        public CentralStation()
        {

            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=TicketAnytime;Integrated Security=True");
        }
        

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            string[] arr2 = { "vikroli", "ghatkopar", "vidyavihar", "kurla", "sion", "matunga", "dadar" };
            //string a = comboBox2.Text; 
            int i, b, d, f = 0, h = 0;
            //string c = comboBox1.Text;

            for (i = 0; i < 7; i++)
            {
                int j = 0;
                string a = comboBox2.Text;
                if (a == arr2[i])
                {
                    f = i;
                }
                string c = comboBox1.Text;
                if (c == arr2[j])
                {
                    h = j;
                }
                j++;


            }
            if (f > h)
            {
                string a = comboBox2.Text;
                for (i = 0; i < 7; i++)
                {

                    if (a == arr2[i])
                    {
                        b = i;

                        if (b <= 3)
                        {
                            textBox3.Text = "5";
                            break;
                            //MessageBox.Show("Rs. 5");
                        }

                        else
                        {
                            textBox3.Text = "10";
                            //MessageBox.Show("Rs .10");
                        }
                    }

                }
            }
            else
            {
                string c = comboBox1.Text;
                for (i = 0; i < 7; i++)
                {

                    if (c == arr2[i])
                    {
                        b = i;

                        if (b <= 3)
                        {
                            textBox3.Text = "5";
                            break;
                            //MessageBox.Show("Rs. 5");
                        }
                        else
                        {
                            textBox3.Text = "10";
                            //MessageBox.Show("Rs .10");
                        }
                    }

                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {

            con.Open();

            SqlCommand cmd;
            String s = "insert into CentralInsert(source,destination,Fare,Qty,Total,date)Values('" + comboBox1.Text + "','" + comboBox2.Text + "'," + Convert.ToInt32(textBox3.Text) + "," + Convert.ToInt32(textBox2.Text) + "," + Convert.ToInt32(textBox1.Text) + ",'" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "')";

            cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();

            

            report r = new report(comboBox1 .Text ,comboBox2 .Text,textBox3 .Text ,textBox2 .Text ,textBox1 .Text  );
            r.Show();
            con.Close();

            FinalReport f = new FinalReport(comboBox1.Text, comboBox2.Text, textBox3.Text, textBox2.Text, textBox1.Text);




            this.Hide();
            //string s1 = "select source from CentralInsert";
            //SqlDataAdapter sda = new SqlDataAdapter(s1, con);
            //DataTable st = new DataTable();
            //r.label6.Text = cmd.ExecuteScalar().ToString();
            //sda.Fill(st);



            //for (int i = 0; i < st.Rows.Count; i++)
            //{

            //    r.label6.Text = st.Rows[0][i].ToString();

            //}
        }
        //catch (Exception ex)
        //{
        //    MessageBox.Show(Convert.ToString(ex));
        //}



        private void CentralStation_Load(object sender, EventArgs e)
        {



            //string strCmd = "select source from CentralData";
            //SqlCommand cmd = new SqlCommand(strCmd, con);
            //SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
            //DataTable dtt = new DataTable();
            //da.Fill(dtt);


            //comboBox1.Enabled = true;


            //comboBox1.ValueMember = "source";
            //comboBox1.DisplayMember = "source";
            //comboBox1.DataSource = dtt;
            //cmd.ExecuteNonQuery();


            //string strCmd1 = "select destination from CentralData";
            //SqlCommand cmd1 = new SqlCommand(strCmd1, con);
            //SqlDataAdapter daa = new SqlDataAdapter(strCmd1, con);
            //DataTable dttt = new DataTable();
            //daa.Fill(dttt);


            //comboBox2.Enabled = true;


            //comboBox2.ValueMember = "destination";
            //comboBox2.DisplayMember = "destination";
            //comboBox2.DataSource = dttt;
            //cmd1.ExecuteNonQuery();






            //string strCmd2 = "select Fare from CentralData";
            //SqlCommand cmd2 = new SqlCommand(strCmd2, con);
            //SqlDataAdapter da1 = new SqlDataAdapter(strCmd2, con);
            //DataTable dtt1 = new DataTable();
            //da1.Fill(dtt1);


            //comboBox3.Enabled = true;


            //comboBox3.ValueMember = "Fare";
            //comboBox3.DisplayMember = "Fare";
            //comboBox3.DataSource = dtt1;
            //cmd2.ExecuteNonQuery();

            //con.Close();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ((Convert.ToInt32(textBox3.Text) * 2) * Convert.ToInt32(textBox2.Text)).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = ((Convert.ToInt32(textBox3.Text) / 2) * Convert.ToInt32(textBox2.Text)).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}

