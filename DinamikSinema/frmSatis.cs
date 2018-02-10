using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikSinema
{
    public partial class frmSatis : Form
    {
        Form1 anaKayit;
        int sayi = 0;
        
        public frmSatis(Form1 frm, int adet)
        {
            InitializeComponent();
            sayi = adet;
            anaKayit = frm;
            
            
        }

        private void btnToplam_Click(object sender, EventArgs e)
        {
            int ogrSayisi;
            int menuSayisi;
            int gozlukSayisi;
            int toplam = 0;
            Int32.TryParse(txbOgr.Text, out ogrSayisi);
            Int32.TryParse(txbMenu.Text, out menuSayisi);
            Int32.TryParse(txbGozluk.Text, out gozlukSayisi);
            while (ogrSayisi > sayi)
            {
                MessageBox.Show("Seçilen koltuk sayısına göre öğrenci sayısı belirleyin.");
                txbOgr.Text = " ";
                ogrSayisi = 0;
            }
            toplam = ((sayi - ogrSayisi) * 20) + (menuSayisi * 10) + (gozlukSayisi * 6)+(ogrSayisi*15);
            lblToplam.Text = toplam.ToString();
            lblToplam.Visible = true;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {        
            lblToplam.Visible = false;
            this.Close();
            Application.Restart();


        }
    }
}
