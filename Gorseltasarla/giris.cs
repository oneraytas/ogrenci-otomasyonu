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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("server =.; Initial Catalog = okul; Integrated Security = SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanici where adi='" + textBox1.Text + "' AND parola='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())

            {
                MessageBox.Show("Giriş Başarılı");
                
                string rolu = dr["rol"].ToString().Trim();
                if (rolu == "ogrenci")
                {
                    Form1 frm = (Form1)Application.OpenForms["Form1"];
                    frm.pictureBox1.ImageLocation = "./profile/" + textBox1.Text + ".jpg";
                    frm.panel4.Show();
                    frm.button6.Hide();
                    frm.button7.Show();
                    Form1.idnumber = (int)dr["id"];
                    this.Close(); 
                }

            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }
    }
}

