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
    public partial class ThaneVashiStations : Form
    {
        public ThaneVashiStations()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PaymentGateway p = new PaymentGateway();
            p.Show();

        }
    }
}
