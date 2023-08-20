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
namespace VeriTabanli_Secim_Istatistik_App
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }

        private SqlConnection baglanti =
            new SqlConnection(
                @"Data Source=LAPTOP-IAK7778Q\SQLEXPRESS;Initial Catalog=DbSecimDatabase;Integrated Security=True");

        private void button1OyGirisi_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut =
                new SqlCommand(
                    "INSERT INTO TBLILCE(ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)",
                    baglanti);
            komut.Parameters.AddWithValue("@P1", textBox1IlceAd.Text);
            komut.Parameters.AddWithValue("@P2", textBox3AParti.Text);
            komut.Parameters.AddWithValue("@P3", textBox2BParti.Text);
            komut.Parameters.AddWithValue("@P4", textBox4CParti.Text);
            komut.Parameters.AddWithValue("@P5", textBox5DParti.Text);
            komut.Parameters.AddWithValue("@P6", textBox6EParti.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("OY GIRIRSI YAPILDI");



        }

        private void button2GRAFIK_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmGrafikler = new FrmGrafikler();
            frmGrafikler.Show();

        }
    }
}
