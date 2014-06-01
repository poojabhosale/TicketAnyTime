using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TicketAnyTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(splashscreen));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();
            t.Abort();
        }

        public void splashscreen()
        {
            Application.Run(new splash_screen());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WesternStations W = new WesternStations();
            W.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CentralStation c = new CentralStation();
            c.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HarbourStations h = new HarbourStations();
            h.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThaneVashiStations t = new ThaneVashiStations();
            t.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
