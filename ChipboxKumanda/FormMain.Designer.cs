namespace ChipboxKumanda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtIP = new System.Windows.Forms.ToolStripTextBox();
            this.btnBaglan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOtoBaslat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProgramiKapat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.btnSag = new System.Windows.Forms.Button();
            this.btnYukari = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnStandby = new System.Windows.Forms.Button();
            this.btnSessiz = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtIP,
            this.btnBaglan,
            this.btnOtoBaslat,
            this.btnHakkinda,
            this.btnProgramiKapat});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(198, 117);
            this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
            // 
            // txtIP
            // 
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 23);
            this.txtIP.ToolTipText = "Chipbox IP Adresi";
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // btnBaglan
            // 
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(197, 22);
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // btnOtoBaslat
            // 
            this.btnOtoBaslat.Name = "btnOtoBaslat";
            this.btnOtoBaslat.Size = new System.Drawing.Size(197, 22);
            this.btnOtoBaslat.Text = "Açılışta otomatik başlat";
            this.btnOtoBaslat.Click += new System.EventHandler(this.btnOtoBaslat_Click);
            // 
            // btnHakkinda
            // 
            this.btnHakkinda.Name = "btnHakkinda";
            this.btnHakkinda.Size = new System.Drawing.Size(197, 22);
            this.btnHakkinda.Text = "Hakkında";
            this.btnHakkinda.Click += new System.EventHandler(this.btnHakkinda_Click);
            // 
            // btnProgramiKapat
            // 
            this.btnProgramiKapat.Name = "btnProgramiKapat";
            this.btnProgramiKapat.Size = new System.Drawing.Size(197, 22);
            this.btnProgramiKapat.Text = "Çıkış";
            this.btnProgramiKapat.Click += new System.EventHandler(this.btnProgramiKapat_Click);
            // 
            // btnSol
            // 
            this.btnSol.BackColor = System.Drawing.Color.Gold;
            this.btnSol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSol.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSol.Location = new System.Drawing.Point(50, 33);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(25, 25);
            this.btnSol.TabIndex = 3;
            this.btnSol.Text = "◄";
            this.btnSol.UseVisualStyleBackColor = false;
            // 
            // btnAsagi
            // 
            this.btnAsagi.BackColor = System.Drawing.Color.Gold;
            this.btnAsagi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsagi.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAsagi.Location = new System.Drawing.Point(76, 59);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(25, 25);
            this.btnAsagi.TabIndex = 7;
            this.btnAsagi.Text = "▼";
            this.btnAsagi.UseVisualStyleBackColor = false;
            // 
            // btnSag
            // 
            this.btnSag.BackColor = System.Drawing.Color.Gold;
            this.btnSag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSag.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSag.Location = new System.Drawing.Point(101, 33);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(25, 25);
            this.btnSag.TabIndex = 5;
            this.btnSag.Text = "►";
            this.btnSag.UseVisualStyleBackColor = false;
            // 
            // btnYukari
            // 
            this.btnYukari.BackColor = System.Drawing.Color.Gold;
            this.btnYukari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYukari.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYukari.Location = new System.Drawing.Point(75, 6);
            this.btnYukari.Name = "btnYukari";
            this.btnYukari.Size = new System.Drawing.Size(25, 25);
            this.btnYukari.TabIndex = 1;
            this.btnYukari.Text = "▲";
            this.btnYukari.UseVisualStyleBackColor = false;
            // 
            // btnTamam
            // 
            this.btnTamam.BackColor = System.Drawing.Color.Gold;
            this.btnTamam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamam.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamam.Location = new System.Drawing.Point(78, 35);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(20, 20);
            this.btnTamam.TabIndex = 4;
            this.btnTamam.UseVisualStyleBackColor = false;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Gold;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(104, 62);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(20, 20);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Ç";
            this.toolTip1.SetToolTip(this.btnCikis, "Çıkış");
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Gold;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenu.Location = new System.Drawing.Point(52, 62);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(20, 20);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "M";
            this.toolTip1.SetToolTip(this.btnMenu, "Menü");
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // btnStandby
            // 
            this.btnStandby.BackColor = System.Drawing.Color.Gold;
            this.btnStandby.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStandby.BackgroundImage")));
            this.btnStandby.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStandby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStandby.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStandby.Location = new System.Drawing.Point(52, 9);
            this.btnStandby.Margin = new System.Windows.Forms.Padding(0);
            this.btnStandby.Name = "btnStandby";
            this.btnStandby.Size = new System.Drawing.Size(20, 20);
            this.btnStandby.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnStandby, "Aç/Kapat");
            this.btnStandby.UseVisualStyleBackColor = false;
            // 
            // btnSessiz
            // 
            this.btnSessiz.BackColor = System.Drawing.Color.Gold;
            this.btnSessiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSessiz.BackgroundImage")));
            this.btnSessiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSessiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSessiz.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSessiz.Location = new System.Drawing.Point(103, 9);
            this.btnSessiz.Margin = new System.Windows.Forms.Padding(0);
            this.btnSessiz.Name = "btnSessiz";
            this.btnSessiz.Size = new System.Drawing.Size(20, 20);
            this.btnSessiz.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSessiz, "Sessiz");
            this.btnSessiz.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(132, 90);
            this.Controls.Add(this.btnSessiz);
            this.Controls.Add(this.btnStandby);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.btnYukari);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.btnAsagi);
            this.Controls.Add(this.btnSol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chipbox HD Mini Kumanda";
            this.TransparencyKey = System.Drawing.Color.LemonChiffon;
            this.Deactivate += new System.EventHandler(this.FormMain_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnProgramiKapat;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnAsagi;
        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.Button btnYukari;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem btnOtoBaslat;
        private System.Windows.Forms.ToolStripMenuItem btnHakkinda;
        private System.Windows.Forms.ToolStripTextBox txtIP;
        private System.Windows.Forms.ToolStripMenuItem btnBaglan;
        private System.Windows.Forms.Button btnStandby;
        private System.Windows.Forms.Button btnSessiz;
    }
}

