﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjeHastahaneYönetimOtomasyonu
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-OEOQ425\\SQLEXPRESS;Initial Catalog=HastahaneProje;Integrated Security=True;Encrypt=False");
            baglan.Open();
            return baglan;
        }
    }
}
