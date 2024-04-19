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
    public partial class Frmdoktordetay : Form
    {
        public Frmdoktordetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        public string tc;
        private void Frmdoktordetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;

            SqlCommand komut=new SqlCommand("select doktorad,doktorsoyad from tbl_doktorlar where doktortc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lbltc.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + "" + dr[1];
            }
            bgl.baglanti().Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("select * from tbl_randevular where randevudoktor='"+lbladsoyad.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void lbladsoyad_Click(object sender, EventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Frmdoktorbilgidüzenle fr=new Frmdoktorbilgidüzenle();
            fr.tcno = lbltc.Text;
            fr.Show();
        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            Frmduyurular fr=new Frmduyurular();
            fr.Show();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
