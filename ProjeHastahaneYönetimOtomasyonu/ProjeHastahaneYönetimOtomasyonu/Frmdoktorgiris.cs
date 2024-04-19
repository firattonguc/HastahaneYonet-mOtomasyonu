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

namespace ProjeHastahaneYönetimOtomasyonu
{
    public partial class Frmdoktorgiris : Form
    {
        public Frmdoktorgiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("select * from tbl_doktorlar where doktortc=@p1 and doktorsifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                Frmdoktordetay fr=new Frmdoktordetay();
                fr.tc=msktc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı kullanıcı adı ya da şifre");

            }
            bgl.baglanti().Close();
        }
    }
}
