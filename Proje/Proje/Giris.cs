using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Proje
{
    public partial class Giris : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public Giris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           SqlConnection con = new SqlConnection("Data Source=LAPTOP-48B1DNR2;Initial Catalog=Giris;Integrated Security=True");
           
            con.Open();
           
            SqlCommand komut = new SqlCommand ("Select*from Kullanici_Bilgi where kullanici_adi='"+textBox1.Text.Trim()+"' and sifre='"+textBox2.Text.Trim()+"'",con);
            SqlDataReader dr = komut.ExecuteReader();
           
            if (dr.Read())
            {
               
                Filmler gecis = new Filmler();
                gecis.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
                textBox1.Clear();
                textBox2.Clear();
            }
            con.Close();
        }
    }
}
