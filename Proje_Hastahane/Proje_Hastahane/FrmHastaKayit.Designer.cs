
namespace Proje_Hastahane
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.BtnKayitYap = new System.Windows.Forms.Button();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(125, 80);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(198, 31);
            this.TxtSoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(82, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 23);
            this.label13.TabIndex = 4;
            this.label13.Text = "Ad:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(125, 196);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(198, 31);
            this.TxtSifre.TabIndex = 5;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(125, 117);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(198, 31);
            this.MskTC.TabIndex = 3;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "TC Kimlik No:";
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(125, 156);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(198, 31);
            this.MskTelefon.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Şifre:";
            // 
            // Cmbcinsiyet
            // 
            this.Cmbcinsiyet.FormattingEnabled = true;
            this.Cmbcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.Cmbcinsiyet.Location = new System.Drawing.Point(125, 236);
            this.Cmbcinsiyet.Name = "Cmbcinsiyet";
            this.Cmbcinsiyet.Size = new System.Drawing.Size(198, 31);
            this.Cmbcinsiyet.TabIndex = 6;
            // 
            // BtnKayitYap
            // 
            this.BtnKayitYap.Location = new System.Drawing.Point(221, 278);
            this.BtnKayitYap.Name = "BtnKayitYap";
            this.BtnKayitYap.Size = new System.Drawing.Size(102, 33);
            this.BtnKayitYap.TabIndex = 16;
            this.BtnKayitYap.Text = "Kayıt Yap";
            this.BtnKayitYap.UseVisualStyleBackColor = true;
            this.BtnKayitYap.Click += new System.EventHandler(this.BtnKayitYap_Click);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(125, 43);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(198, 31);
            this.TxtAd.TabIndex = 1;
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.BtnKayitYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(335, 333);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.BtnKayitYap);
            this.Controls.Add(this.Cmbcinsiyet);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cmbcinsiyet;
        private System.Windows.Forms.Button BtnKayitYap;
        private System.Windows.Forms.TextBox TxtAd;
    }
}