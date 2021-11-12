using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gorseltasarla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void notlarım1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            giris frm = new giris();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            solpanel.Height = button1.Height;
            solpanel.Top = button1.Top;
            notlarım1.Show();
        }
        public static int idnumber;
        private void button3_Click_1(object sender, EventArgs e)
        {
            solpanel.Height = button3.Height;
            solpanel.Top = button3.Top;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            solpanel.Height = button2.Height;
            solpanel.Top = button2.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Hide();
            button6.Show();
            panel4.Hide();
            notlarım1.Hide();
           pictureBox1.Image= Gorseltasarla.Properties.Resources.userpic;
        }
    }
}
