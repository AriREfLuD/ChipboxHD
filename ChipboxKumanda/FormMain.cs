using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using Chipbox;
using ChipboxKumanda.Properties;
using CodeProject.SystemHotkey;
using Microsoft.Win32;

namespace ChipboxKumanda
{
    public partial class FormMain : Form
    {

        #region Constructor

        public FormMain()
        {
            InitializeComponent();
            this.TopMost = true;

            SystemHotkey sSol = new SystemHotkey(this.components);
            sSol.Shortcut = Shortcut.AltLeftArrow;
            sSol.Pressed += sSol_Pressed;

            SystemHotkey sSag = new SystemHotkey(this.components);
            sSag.Shortcut = Shortcut.AltRightArrow;
            sSag.Pressed += sSag_Pressed;

            SystemHotkey sAsagi = new SystemHotkey(this.components);
            sAsagi.Shortcut = Shortcut.AltDownArrow;
            sAsagi.Pressed += sAsagi_Pressed;

            SystemHotkey sYukari = new SystemHotkey(this.components);
            sYukari.Shortcut = Shortcut.AltUpArrow;
            sYukari.Pressed += sYukari_Pressed;
        }

        #endregion

        #region Fields

        // The path to the key where Windows looks for startup applications
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        string MyAppName = "ChipboxHDMiniKumanda";

        ChipboxHD chipbox1 = null;

        bool Bagli = false;

        #endregion

        #region Events

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            notifyIcon1.Text = "Chipbox HD Mini Kumanda";

            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    Button b = c as Button;
                    //if (b.Text != "B")
                    b.Click += new EventHandler(btnKomut_Click);
                }
            }

            btnSol.Tag = RCKeys.Key_Left;
            btnSag.Tag = RCKeys.Key_Right;
            btnYukari.Tag = RCKeys.Key_Up;
            btnAsagi.Tag = RCKeys.Key_Down;
            btnTamam.Tag = RCKeys.Key_Ok;
            btnMenu.Tag = RCKeys.Key_Menu;
            btnCikis.Tag = RCKeys.Key_Exit;
            btnStandby.Tag = RCKeys.Key_Standby;
            btnSessiz.Tag = RCKeys.Key_Mute;

            try
            {
                // Açılışta otomatik başlıyor mu?
                if (rkApp.GetValue(MyAppName) == null)
                    btnOtoBaslat.Checked = false;
                else
                {
                    rkApp.DeleteValue(MyAppName, false);
                    rkApp.SetValue(MyAppName, Application.ExecutablePath.ToString());
                    btnOtoBaslat.Checked = true;
                }
            }
            catch { }

            txtIP.Text = Settings.Default.txtIP;
            Bagli = SessizBaglan();

        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            this.Hide();
            if (Bagli)
            {
                notifyIcon1.ShowBalloonTip(100, "Chipbox HD Mini Kumanda", "Chipbox'a başarıyla bağlanıldı.", ToolTipIcon.Info);
            }
            else
            {
                notifyIcon1.ShowBalloonTip(100, "Chipbox HD Mini Kumanda", "Bağlantı hatası! Lütfen ayarları kontrol edin.", ToolTipIcon.Info);
            }

            //MessageBox.Show(this.Size.ToString());
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Visible = false;
            if (chipbox1 != null)
                chipbox1.CloseAll();
            //MessageBox.Show("Closed");
        }

        private void FormMain_Deactivate(object sender, EventArgs e)
        {
            // form dışında bir noktaya tıklandığında formu gizle
            this.Hide();
        }

        private void btnKomut_Click(object sender, EventArgs e)
        {
            if (chipbox1 != null)
            {
                if (!chipbox1.IsConnected)
                    SessizBaglan();

                try
                {
                    chipbox1.SendRCKey((RCKeys)((sender as Button).Tag));
                }
                catch
                {
                    MessageBox.Show("Bağlantı hatası! Bağlandığınız cihaz Chipbox olmayabilir.\nLütfen ayarlarınızı kontrol edin.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Aktif bağlantı yok. Lütfen sağ alttaki uygulama logosuna sağ tıklayarak Chipbox bağlantı ayarlarını yapın.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = Cursor.Position.X - this.Width;
                this.Top = Cursor.Position.Y - this.Height;
                this.Show();
                this.BringToFront();
            }
        }

        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            if (chipbox1 != null && chipbox1.IsConnected)
            {
                btnBaglan.Checked = true;
                btnBaglan.Text = "Bağlı";
                //txtIP.Text = chipbox1.IPAdress;
            }
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            IPAddress ip1;
            if (!IPAddress.TryParse(txtIP.Text, out ip1))
            {
                MessageBox.Show("Yazdığınız IP adresi hatalı!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                Ping ping = new Ping();

                PingReply pingReply = ping.Send(ip1);

                if (pingReply.Status != IPStatus.Success)
                {
                    MessageBox.Show("Yazdığınız IP adresine ulaşılamıyor.\nAçıklama: " + pingReply.Status.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch
            {
                return;
            }

            if (chipbox1 != null)
                chipbox1.CloseAll();

            try
            {
                chipbox1 = new ChipboxHD(txtIP.Text);
                btnBaglan.Checked = true;
                btnBaglan.Text = "Bağlı";
                Settings.Default.txtIP = txtIP.Text;
                Settings.Default.Save();
            }
            catch
            {
                return;
            }



        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {
            btnBaglan.Checked = false;
            btnBaglan.Text = "Bağlan";
        }

        private void btnProgramiKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOtoBaslat_Click(object sender, EventArgs e)
        {
            if (btnOtoBaslat.Checked)
            {
                rkApp.DeleteValue(MyAppName, false);
                btnOtoBaslat.Checked = false;
            }
            else
            {
                rkApp.SetValue(MyAppName, Application.ExecutablePath.ToString());
                btnOtoBaslat.Checked = true;
            }
        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program 'Hiremco Chipbox HD' model uydu alıcıyı ağ üzerinden Telnet arabirimi ile komutlar göndererek kontrol etmenizi sağlar. Programın arabirimi görev çubuğunun sağ altında beliren logodur. Logoya sol tıklamak kontrol arabirimini, sağ tıklamak ayar ve bilgi seçeneklerini getirecektir. Sol tıklama ile açılan kontrol ekranında Yön, OK, Menü, Çıkış, Sessiz ve Güç tuşlarına ait kısayollar mevcuttur. Herhangi bir butona tıkladıktan sonra başka bir alana tıklamak kontrol ekranını kapatacaktır. Bağlantı yapılan son IP adresine programın bir sonraki açılışında otomatik olarak bağlantı yapılır. Açılışta otomatik başlat seçeneği ile Windows'un her açılışında programın otomatik başlamasını sağlayabilirsiniz. Program açıldıktan sonra sağ altta logosu olduğu sürece Windows içinde herhangi bir ekranda iken Alt + ok tuşlarını kullanarak kanal değiştirme ve ses kontrolü işlemlerini yapabilirsiniz.\r\nYXSDF © " + DateTime.Now.Year, this.Text + " v1.1", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void sYukari_Pressed(object sender, EventArgs e)
        {
            btnKomut_Click(btnYukari, null);
        }

        void sAsagi_Pressed(object sender, EventArgs e)
        {
            btnKomut_Click(btnAsagi, null);
        }

        void sSag_Pressed(object sender, EventArgs e)
        {
            btnKomut_Click(btnSag, null);
        }

        void sSol_Pressed(object sender, EventArgs e)
        {
            btnKomut_Click(btnSol, null);
        }

        #endregion

        #region Methods

        bool SessizBaglan()
        {
            IPAddress ip1;
            if (!IPAddress.TryParse(txtIP.Text, out ip1))
                return false;

            try
            {
                Ping ping = new Ping();

                PingReply pingReply = ping.Send(ip1);

                if (pingReply.Status != IPStatus.Success)
                    return false;
            }
            catch
            {
                return false;
            }

            if (chipbox1 != null)
                chipbox1.CloseAll();

            try
            {
                chipbox1 = new ChipboxHD(txtIP.Text);
                btnBaglan.Checked = true;
                btnBaglan.Text = "Bağlı";
                Settings.Default.txtIP = txtIP.Text;
                Settings.Default.Save();
                return true;
            }
            catch
            {
                return false;
            }

        }

        #endregion

    }
}
