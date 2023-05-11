using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PartiSecimGrafikIstatistik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RR2PLUS\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert Into TblIlce (IlceAd,AParti,BParti,CParti,DParti,EParti) Values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1",txtIlceAd.Text);
            komut.Parameters.AddWithValue("@p2",txtA.Text);
            komut.Parameters.AddWithValue("@p3",txtB.Text);
            komut.Parameters.AddWithValue("@p4",txtC.Text);
            komut.Parameters.AddWithValue("@p5",txtD.Text);
            komut.Parameters.AddWithValue("@p6",txtE.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm=new FrmGrafikler();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
