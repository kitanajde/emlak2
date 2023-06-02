

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

namespace emlak
{ 
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-8K8HU1TP;Initial Catalog=evler1;Integrated Security=True");
        private void verilerigöster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From evlerbilgi1", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.SubItems.Add(oku["sıra"].ToString());
                ekle.SubItems.Add(oku["şehir/semt"].ToString());
                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["metre"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["ad/soyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());
                ekle.SubItems.Add(oku["sat/kira"].ToString());


                listView1.Items.Add(ekle);
            }
            baglan.Close(); }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void grnt_Click(object sender, EventArgs e)
        {
            verilerigöster();
        }

        
              private void kaydet1_Click(object sender, EventArgs e)
         {
                 baglan.Open();


                SqlCommand komut = new SqlCommand("Insert into evlerbilgi1 (sıra,şehir/semt,oda,metre,fiyat,ad/soyad,telefon,notlar,sat/kira) Values('" + textBox7.Text.ToString() + "' , '" + comboBox1.Text.ToString() + "' , '" + comboBox3.Text.ToString() + "' , '" + textBox2.Text.ToString() + "' , '" + textBox1.Text.ToString() + "' , '" + textBox6.Text.ToString() + "' , '" + textBox4.Text.ToString() + "' , '" + textBox5.Text.ToString() + "' , '" + comboBox2.Text.ToString() + "' )", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();


               verilerigöster();
        }

     

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
            {
            }

            private void textBox5_TextChanged(object sender, EventArgs e)
            {

            }
        }
    
}

  
