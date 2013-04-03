namespace ChipboxKanalYedek
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnIPTVYedekle = new System.Windows.Forms.Button();
            this.btnIPTVGeriYukle = new System.Windows.Forms.Button();
            this.btnNormalYedekle = new System.Windows.Forms.Button();
            this.btnNormalGeriYukle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Adresi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(80, 19);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(120, 20);
            this.txtIP.TabIndex = 3;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(80, 45);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(120, 20);
            this.txtKullanici.TabIndex = 4;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(80, 71);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(120, 20);
            this.txtSifre.TabIndex = 5;
            // 
            // btnIPTVYedekle
            // 
            this.btnIPTVYedekle.Location = new System.Drawing.Point(10, 22);
            this.btnIPTVYedekle.Name = "btnIPTVYedekle";
            this.btnIPTVYedekle.Size = new System.Drawing.Size(180, 30);
            this.btnIPTVYedekle.TabIndex = 6;
            this.btnIPTVYedekle.Text = "IPTV Kanal Listesi Yedekle";
            this.btnIPTVYedekle.UseVisualStyleBackColor = true;
            this.btnIPTVYedekle.Click += new System.EventHandler(this.btnIPTVYedekle_Click);
            // 
            // btnIPTVGeriYukle
            // 
            this.btnIPTVGeriYukle.Location = new System.Drawing.Point(10, 58);
            this.btnIPTVGeriYukle.Name = "btnIPTVGeriYukle";
            this.btnIPTVGeriYukle.Size = new System.Drawing.Size(180, 30);
            this.btnIPTVGeriYukle.TabIndex = 7;
            this.btnIPTVGeriYukle.Text = "IPTV Kanal Listesi Geri Yükle";
            this.btnIPTVGeriYukle.UseVisualStyleBackColor = true;
            this.btnIPTVGeriYukle.Click += new System.EventHandler(this.btnIPTVGeriYukle_Click);
            // 
            // btnNormalYedekle
            // 
            this.btnNormalYedekle.Location = new System.Drawing.Point(10, 22);
            this.btnNormalYedekle.Name = "btnNormalYedekle";
            this.btnNormalYedekle.Size = new System.Drawing.Size(180, 30);
            this.btnNormalYedekle.TabIndex = 9;
            this.btnNormalYedekle.Text = "Normal Kanal Listesi Yedekle";
            this.btnNormalYedekle.UseVisualStyleBackColor = true;
            this.btnNormalYedekle.Click += new System.EventHandler(this.btnNormalYedekle_Click);
            // 
            // btnNormalGeriYukle
            // 
            this.btnNormalGeriYukle.Location = new System.Drawing.Point(10, 58);
            this.btnNormalGeriYukle.Name = "btnNormalGeriYukle";
            this.btnNormalGeriYukle.Size = new System.Drawing.Size(180, 30);
            this.btnNormalGeriYukle.TabIndex = 10;
            this.btnNormalGeriYukle.Text = "Normal Kanal Listesi Geri Yükle";
            this.btnNormalGeriYukle.UseVisualStyleBackColor = true;
            this.btnNormalGeriYukle.Click += new System.EventHandler(this.btnNormalGeriYukle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKullanici);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chipbox Bağlantı Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIPTVYedekle);
            this.groupBox2.Controls.Add(this.btnIPTVGeriYukle);
            this.groupBox2.Location = new System.Drawing.Point(229, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IPTV Eklentisi İşlemleri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNormalYedekle);
            this.groupBox3.Controls.Add(this.btnNormalGeriYukle);
            this.groupBox3.Location = new System.Drawing.Point(435, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kanal Listesi İşlemleri";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 123);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chipbox HD Normal ve IPTV Kanal Listesi Yedekleme/Geri Yükleme Yazılımı v1.1";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FormMain_HelpButtonClicked);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnIPTVYedekle;
        private System.Windows.Forms.Button btnIPTVGeriYukle;
        private System.Windows.Forms.Button btnNormalYedekle;
        private System.Windows.Forms.Button btnNormalGeriYukle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

