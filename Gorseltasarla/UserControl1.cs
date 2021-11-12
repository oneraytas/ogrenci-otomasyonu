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
    public partial class Notlarım : UserControl
    {
        public Notlarım()
        {
            InitializeComponent();
        }

        private void Notlarım_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(224, 224, 224);
            label1.Text = "Görsel Programlama";
            label2.Text = "Nesne Tabanlı";
            label3.Text = "Web ve İnternet";
            label4.Text = "İşletim Sistemleri";

            con = new SqlConnection("server =.; Initial Catalog = okul; Integrated Security = SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanici,notlarim where kullanici.id=notlarim.kid AND notlarim.kid="+ Form1.idnumber;
            dr = cmd.ExecuteReader();
            if (dr.Read())

            {
                MessageBox.Show("Notlar Getirildi");
                label5.Text = dr["gorsel"].ToString();
                label6.Text = dr["nesne"].ToString();
                label7.Text = dr["web"].ToString();
                label8.Text = dr["ist"].ToString();

            }

            
            else
            {
                MessageBox.Show("Hata Not Bilgisi Okunamadı");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(234, 234, 234);
            label1.Text = "Bilgisayar Donanımı";
            label2.Text = "Ağ Temelleri";
            label3.Text = "Web ve İnternet 2";
            label4.Text = "Akıllı Sistemler";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(244, 244, 244);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(254, 254, 254);
        }
    }
}
