using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicketAnyTime
{
    public partial class FinalReport : Form
    {
        public FinalReport(string a,string b,string c,string d,string e )
        {
            InitializeComponent();
            label3 .Text =a;
            label4.Text = b;
            label6.Text = c;
            label7.Text = d;
            label8.Text = e;
        }

        private void FinalReport_Load(object sender, EventArgs e)
        {

          
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
