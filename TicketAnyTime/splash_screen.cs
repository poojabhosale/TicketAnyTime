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
    public partial class splash_screen : Form
    {
        public splash_screen()
        {
            InitializeComponent();
        }

        private void splashscreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
                timer1.Stop();
  
        }
    }
}
