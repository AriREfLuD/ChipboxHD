using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.FtpClient;
//using FolderSelect;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace ChipboxKanalYedek
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        #region Fields

        int zaman;

        const string iptv_kanal_listesi = "/usr/work1/iptv/kanallar.txt";

        const string kanal_listesi_database = "/application/data/database";
        const string kanal_listesi_indexdb = "/application/data/indexdb";
        const string kanal_listesi_sattp = "/application/data/sattp";

        //const string kanal_listesi_database = "/usr/work0/default/database";
        //const string kanal_listesi_indexdb = "/usr/work0/default/indexdb";
        //const string kanal_listesi_sattp = "/usr/work0/default/sattp";

        #endregion

        #region Events

        private void FormMain_Load(object sender, EventArgs e)
        {
            txtIP.Text = Properties.Settings.Default.txtIP;
            txtKullanici.Text = Properties.Settings.Default.txtKullanici;
            txtSifre.Text = Properties.Settings.Default.txtSifre;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.txtIP = txtIP.Text;
            Properties.Settings.Default.txtKullanici = txtKullanici.Text;
            Properties.Settings.Default.txtSifre = txtSifre.Text;
            Properties.Settings.Default.Save();
        }

        private void FormMain_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            e.Cancel = true;

            MessageBox.Show("Bu program 'Hiremco Chipbox HD' model uydu alıcıya FTP ve Telnet arabirimleri aracılığı ile bağlanıp, kullanıcı kanal listesi ve IPTV eklentisi kanal listesini yedeklemeyi ve cihaza geri liste yüklemeyi sağlar. Yedekleme butonları kullanıldığında program ile aynı klasörde ChipboxKanalYedek klasörü oluşturularak içine IPTV ve normal kanal listesi için ayrı ayrı klasörlere zamana göre isimlendirme yapılarak yedeklemeler yapılır. Geri yükleme butonları ile bilgisayarınızdaki kayıtlı yedekleri cihaza yükleyebilirsiniz. Program her kapanışta Chipbox bağlantı bilgileri ekranındaki bilgileri kaydeder ve sonraki açılışta yükler.\nYXSDF © " + DateTime.Now.Year, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIPTVYedekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (IPKontroluYap()) return;

                zaman = Environment.TickCount;

                string klasor = Application.StartupPath + "\\ChipboxKanalYedek\\IPTV\\";
                if (!Directory.Exists(klasor))
                    Directory.CreateDirectory(klasor);

                DateTime d = DateTime.Now;
                string dosyaadi = "iptv-kanallar-" + d.Year + "-" +
                                  new string('0', 2 - d.Month.ToString().Length) + d.Month + "-" +
                                  new string('0', 2 - d.Day.ToString().Length) + d.Day + "_" +
                                  new string('0', 2 - d.Hour.ToString().Length) + d.Hour + "." +
                                  new string('0', 2 - d.Minute.ToString().Length) + d.Minute + "." +
                                  new string('0', 2 - d.Second.ToString().Length) + d.Second +
                                  ".txt";

                FTPTools.DownloadFile(txtIP.Text, txtKullanici.Text, txtSifre.Text, iptv_kanal_listesi, klasor + dosyaadi);

                zaman = Environment.TickCount - zaman;

                MessageBox.Show("Chipbox IPTV Kanal Listesi başarıyla yedeklendi.\nDosya Konumu: " + klasor + dosyaadi + "\nİşlem süresi: " + zaman + " ms.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exp)
            {
                MessageBox.Show("Bağlantı sırasında hata oluştu!\nAçıklama: " + exp.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnIPTVGeriYukle_Click(object sender, EventArgs e)
        {
            try
            {
                if (IPKontroluYap()) return;

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = Application.StartupPath;
                ofd.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*";
                ofd.Title = "Lütfen Chipbox'a yüklenecek IPTV kanal listesi dosyasını seçin.";
                ofd.FileName = "";

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;

                zaman = Environment.TickCount;

                FTPTools.UploadFile(txtIP.Text, txtKullanici.Text, txtSifre.Text, ofd.FileName, iptv_kanal_listesi);

                zaman = Environment.TickCount - zaman;

                MessageBox.Show("IPTV Kanal Listesi başarıyla Chipbox'a yüklendi.\nİşlem süresi: " + zaman + " ms.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exp)
            {
                MessageBox.Show("Bağlantı sırasında hata oluştu!\nAçıklama: " + exp.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnNormalYedekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (IPKontroluYap()) return;

                zaman = Environment.TickCount;

                DateTime d = DateTime.Now;
                string klasoradi = "KanalListesi-" + d.Year + "-" +
                                  new string('0', 2 - d.Month.ToString().Length) + d.Month + "-" +
                                  new string('0', 2 - d.Day.ToString().Length) + d.Day + "_" +
                                  new string('0', 2 - d.Hour.ToString().Length) + d.Hour + "." +
                                  new string('0', 2 - d.Minute.ToString().Length) + d.Minute + "." +
                                  new string('0', 2 - d.Second.ToString().Length) + d.Second;

                string klasor = Application.StartupPath + "\\ChipboxKanalYedek\\KANALLISTESI\\" + klasoradi + "\\";
                if (!Directory.Exists(klasor))
                    Directory.CreateDirectory(klasor);

                FTPTools.DownloadFile(txtIP.Text, txtKullanici.Text, txtSifre.Text, kanal_listesi_database, klasor + "database");
                FTPTools.DownloadFile(txtIP.Text, txtKullanici.Text, txtSifre.Text, kanal_listesi_indexdb, klasor + "indexdb");
                FTPTools.DownloadFile(txtIP.Text, txtKullanici.Text, txtSifre.Text, kanal_listesi_sattp, klasor + "sattp");

                zaman = Environment.TickCount - zaman;

                MessageBox.Show("Chipbox Normal Kanal Listesi başarıyla yedeklendi.\nDosyaların Konumu: " + klasor + "\nİşlem süresi: " + zaman + " ms.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exp)
            {
                MessageBox.Show("Bağlantı sırasında hata oluştu!\nAçıklama: " + exp.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnNormalGeriYukle_Click(object sender, EventArgs e)
        {
            if (IPKontroluYap()) return;

            if (MessageBox.Show("Bu işlem, seçeceğiniz kanal listesi yedeğini Chipbox'a yükleyecektir.\nChipbox üzerindeki güncel kanal listeniz SİLİNİP yerine yeni liste yazılacaktır ve Chipbox yeniden başlatılacaktır.\nDevam etmek istiyor musunuz?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                return;

            try
            {
                FolderBrowserDialog fsd = new FolderBrowserDialog();
                //FolderSelectDialog fsd = new FolderSelectDialog();

                //fsd.InitialDirectory = Application.StartupPath;
                //fsd.Title = "Lütfen Chipbox kanal listesi yedeğinin olduğu klasörü seçin.";

                fsd.SelectedPath = Application.StartupPath;
                fsd.Description = "Lütfen Chipbox kanal listesi yedeğinin olduğu klasörü seçin.";

                //if (!fsd.ShowDialog())
                if (fsd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;

                if ((!File.Exists(fsd.SelectedPath + "\\database")) || (!File.Exists(fsd.SelectedPath + "\\indexdb")) || (!File.Exists(fsd.SelectedPath + "\\sattp")))
                {
                MessageBox.Show("Seçtiğiniz klasörde database, indexdb ve sattp dosyaları bulunamadı!\nLütfen doğru klasörü seçtiğinizden emin olun!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
                }
                
                zaman = Environment.TickCount;

                FTPTools.UploadFile(txtIP.Text, txtKullanici.Text, txtSifre.Text, fsd.SelectedPath + "\\database", kanal_listesi_database);
                FTPTools.UploadFile(txtIP.Text, txtKullanici.Text, txtSifre.Text, fsd.SelectedPath + "\\indexdb", kanal_listesi_indexdb);
                FTPTools.UploadFile(txtIP.Text, txtKullanici.Text, txtSifre.Text, fsd.SelectedPath + "\\sattp", kanal_listesi_sattp);

                ChipboxReset(txtIP.Text);

                zaman = Environment.TickCount - zaman;

                MessageBox.Show("Kanal Listesi başarıyla Chipbox'a yüklendi. Cihaz yeniden başlatılıyor.\nİşlem süresi: " + zaman + " ms.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exp)
            {
                MessageBox.Show("Bağlantı sırasında hata oluştu!\nAçıklama: " + exp.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region Methods

        void ChipboxReset(string ip)
        {
            TcpClient _chipbox = new TcpClient(ip, 23);
            byte[] data = Encoding.ASCII.GetBytes("reboot -f\n");
            _chipbox.GetStream().Write(data, 0, data.Length);
            //Thread.Sleep(1000);
            //_chipbox.GetStream().Close();
            //_chipbox.Close();
        }

        bool IPKontroluYap()
        {
            bool k = !IPKontrol(txtIP.Text);

            if (k)
                MessageBox.Show("Girdiğiniz IP adresi hatalı ya da ulaşılamıyor! Lütfen kontrol ediniz.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return k;
        }

        bool IPKontrol(string ip)
        {
            IPAddress ip1;
            if (!IPAddress.TryParse(ip, out ip1))
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

            return true;
        }

        #endregion

    }
}
