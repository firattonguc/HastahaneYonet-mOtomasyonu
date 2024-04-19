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
    public partial class frmhastakayıt : Form
    {
        public frmhastakayıt()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void btnkayıtyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("insert into tbl_hastalar(hastaad,hastasoyad,hastatc,hastatelefon,hastasifre,hastacinsiyet)values(@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktc.Text);
            komut.Parameters.AddWithValue("@p4", msktelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtsifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbsinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("kaydınız gerçekleşmiştir şifreniz:"+txtsifre.Text,"bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
