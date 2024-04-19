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
using System.Security.Cryptography.X509Certificates;
namespace ProjeHastahaneYönetimOtomasyonu
{
    public partial class Frmsekreterdetay : Form
    {
        public Frmsekreterdetay()
        {
            InitializeComponent();
        }
        public string tcnumara;
        
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void Frmsekreterdetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tcnumara;

           

            SqlCommand komut1 = new SqlCommand("select sekreteradsoyad from tbl_sekreter where sekretertc=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",lbltc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbladsoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            DataTable dt1 = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("select bransad from tbl_branslar",bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            DataTable dt2= new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (doktorad+''+doktorsoyad)as 'doktorlar',doktorbrans from tbl_doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            SqlCommand komut2 = new SqlCommand("select bransad from tbl_branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();


        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into tbl_randevular(randevutarih,randevusaat,randevubrans,randevudoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti()); 
            komutkaydet.Parameters.AddWithValue("@r1", msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbbrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbdoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("randevu oluşturuldu");
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("select doktorad,doktorsoyad from tbl_doktorlar where doktorbrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",cmbbrans.Text);
            SqlDataReader dr=komut.ExecuteReader(); 
            while(dr.Read())
            {
                cmbdoktor.Items.Add(dr[0] + "" + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnolustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_duyurular(duyuru)values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",rchduyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("duyuru oluşturuldu");


        }

        private void btndoktorpanel_Click(object sender, EventArgs e)
        {
            Frmdoktorpaneli drp=new Frmdoktorpaneli();
            drp.Show();
        }

        private void btnbranspanel_Click(object sender, EventArgs e)
        {
            frmbrans frb=new frmbrans();
            frb.Show();
        }

        private void btnrandevu_Click(object sender, EventArgs e)
        {
            Frmrandevulistesi frl=new Frmrandevulistesi();
            frl.Show();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmduyurular fr=new Frmduyurular();
            fr.Show();
        }
    }
}
