namespace ProjeHastahaneYönetimOtomasyonu
{
    partial class Frmbilgiduzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnkayıtyap = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbsinsiyet = new System.Windows.Forms.ComboBox();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnkayıtyap
            // 
            this.btnkayıtyap.Location = new System.Drawing.Point(163, 370);
            this.btnkayıtyap.Name = "btnkayıtyap";
            this.btnkayıtyap.Size = new System.Drawing.Size(134, 40);
            this.btnkayıtyap.TabIndex = 31;
            this.btnkayıtyap.Text = "Güncelle";
            this.btnkayıtyap.UseVisualStyleBackColor = true;
            this.btnkayıtyap.Click += new System.EventHandler(this.btnkayıtyap_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cinsiyet:";
            // 
            // cmbsinsiyet
            // 
            this.cmbsinsiyet.FormattingEnabled = true;
            this.cmbsinsiyet.Items.AddRange(new object[] {
            "Erkek ",
            "Kadın"});
            this.cmbsinsiyet.Location = new System.Drawing.Point(153, 308);
            this.cmbsinsiyet.Name = "cmbsinsiyet";
            this.cmbsinsiyet.Size = new System.Drawing.Size(154, 31);
            this.cmbsinsiyet.TabIndex = 29;
            // 
            // msktelefon
            // 
            this.msktelefon.Location = new System.Drawing.Point(153, 196);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(154, 31);
            this.msktelefon.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Telefon:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(153, 88);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(154, 31);
            this.txtsoyad.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Soyad:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(153, 256);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(154, 31);
            this.txtsifre.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Şifre:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(153, 39);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(154, 31);
            this.txtad.TabIndex = 22;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(153, 140);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(154, 31);
            this.msktc.TabIndex = 21;
            this.msktc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "T.C. Kimlik no:";
            // 
            // Frmbilgiduzenle
            // 
            this.AcceptButton = this.btnkayıtyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(464, 498);
            this.Controls.Add(this.btnkayıtyap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbsinsiyet);
            this.Controls.Add(this.msktelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frmbilgiduzenle";
            this.Text = "Frmbilgiduzenle";
            this.Load += new System.EventHandler(this.Frmbilgiduzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkayıtyap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbsinsiyet;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}