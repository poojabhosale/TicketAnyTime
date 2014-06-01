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
    public partial class OneTimePassword : Form
    {
        public OneTimePassword()
        {
            InitializeComponent();
        }
        //private string generatePassword()
        //{
        //    int lenthofpass = 6;
        //    string allowedChars = "";
        //    allowedChars = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,";
        //    allowedChars += "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,";
        //    allowedChars += "1,2,3,4,5,6,7,8,9,0,!,@,#,$,%,&,?";
        //    char[] sep = { ',' };
        //    string[] arr = allowedChars.Split(sep);
        //    string passwordString = "";
        //    string temp = "";
        //    Random rand = new Random();
        //    for (int i = 0; i < lenthofpass; i++)
        //    {
        //        temp = arr[rand.Next(0, arr.Length)];
        //        passwordString += temp;
        //    }
        //    return passwordString;
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            
            
                Message m = new Message();
                m.Show();
                this.Hide();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void OneTimePassword_Load(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
