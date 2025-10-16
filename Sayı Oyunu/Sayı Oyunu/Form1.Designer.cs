namespace Sayı_Oyunu
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnBitir = new System.Windows.Forms.Button();
            this.gbOyunAlani = new System.Windows.Forms.GroupBox();
            this.lbTiklananSayilar = new System.Windows.Forms.ListBox();
            this.lblSure = new System.Windows.Forms.Label();
            this.oyunZamanlayici = new System.Windows.Forms.Timer(this.components);
            this.butonYerDegistirici = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(45, 46);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(139, 143);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "Oyuna Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click_1);
            // 
            // btnBitir
            // 
            this.btnBitir.Location = new System.Drawing.Point(1144, 46);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(157, 115);
            this.btnBitir.TabIndex = 1;
            this.btnBitir.Text = "Oyunu Bitir";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // gbOyunAlani
            // 
            this.gbOyunAlani.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbOyunAlani.Location = new System.Drawing.Point(285, 14);
            this.gbOyunAlani.Name = "gbOyunAlani";
            this.gbOyunAlani.Size = new System.Drawing.Size(650, 630);
            this.gbOyunAlani.TabIndex = 2;
            this.gbOyunAlani.TabStop = false;
            this.gbOyunAlani.Text = "Oyun Alanı";
            // 
            // lbTiklananSayilar
            // 
            this.lbTiklananSayilar.FormattingEnabled = true;
            this.lbTiklananSayilar.ItemHeight = 16;
            this.lbTiklananSayilar.Location = new System.Drawing.Point(957, 14);
            this.lbTiklananSayilar.Name = "lbTiklananSayilar";
            this.lbTiklananSayilar.Size = new System.Drawing.Size(162, 628);
            this.lbTiklananSayilar.TabIndex = 4;
            this.lbTiklananSayilar.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // lblSure
            // 
            this.lblSure.AutoEllipsis = true;
            this.lblSure.Location = new System.Drawing.Point(1177, 313);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(100, 99);
            this.lblSure.TabIndex = 5;
            this.lblSure.Text = "Süre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 654);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lbTiklananSayilar);
            this.Controls.Add(this.gbOyunAlani);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.btnBasla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.GroupBox gbOyunAlani;
        private System.Windows.Forms.ListBox lbTiklananSayilar;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Timer oyunZamanlayici;
        private System.Windows.Forms.Timer butonYerDegistirici;
    }
}

