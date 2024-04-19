namespace ProjeHastahaneYönetimOtomasyonu
{
    partial class frmgirisler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgirisler));
            this.btnhastagirisi = new System.Windows.Forms.Button();
            this.btndoktorgirisi = new System.Windows.Forms.Button();
            this.btnsekretergirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnhastagirisi
            // 
            this.btnhastagirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhastagirisi.BackgroundImage")));
            this.btnhastagirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhastagirisi.Location = new System.Drawing.Point(12, 36);
            this.btnhastagirisi.Name = "btnhastagirisi";
            this.btnhastagirisi.Size = new System.Drawing.Size(209, 156);
            this.btnhastagirisi.TabIndex = 0;
            this.btnhastagirisi.UseVisualStyleBackColor = true;
            this.btnhastagirisi.Click += new System.EventHandler(this.btnhastagirisi_Click);
            // 
            // btndoktorgirisi
            // 
            this.btndoktorgirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndoktorgirisi.BackgroundImage")));
            this.btndoktorgirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndoktorgirisi.Location = new System.Drawing.Point(241, 36);
            this.btndoktorgirisi.Name = "btndoktorgirisi";
            this.btndoktorgirisi.Size = new System.Drawing.Size(209, 156);
            this.btndoktorgirisi.TabIndex = 1;
            this.btndoktorgirisi.UseVisualStyleBackColor = true;
            this.btndoktorgirisi.Click += new System.EventHandler(this.btndoktorgirisi_Click);
            // 
            // btnsekretergirisi
            // 
            this.btnsekretergirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsekretergirisi.BackgroundImage")));
            this.btnsekretergirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsekretergirisi.Location = new System.Drawing.Point(475, 36);
            this.btnsekretergirisi.Name = "btnsekretergirisi";
            this.btnsekretergirisi.Size = new System.Drawing.Size(209, 156);
            this.btnsekretergirisi.TabIndex = 2;
            this.btnsekretergirisi.UseVisualStyleBackColor = true;
            this.btnsekretergirisi.Click += new System.EventHandler(this.btnsekretergirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // frmgirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(729, 291);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsekretergirisi);
            this.Controls.Add(this.btndoktorgirisi);
            this.Controls.Add(this.btnhastagirisi);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmgirisler";
            this.Text = "Sea Grenn Hospital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhastagirisi;
        private System.Windows.Forms.Button btndoktorgirisi;
        private System.Windows.Forms.Button btnsekretergirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

