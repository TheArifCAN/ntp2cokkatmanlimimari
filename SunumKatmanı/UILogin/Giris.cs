using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using verierisimkatmani.Dbislemleri;

namespace SunumKatmanı.UILogin
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btn_sifre_Click(object sender, EventArgs e)
        {
            KullaniciGiris k = new KullaniciGiris();

            bool sonuc = k.GirisYap(txt_ka.Text,txt_sifre.Text);
            if (sonuc)
            {
                this.Hide();
                UIMain.Main frm = new UIMain.Main();

                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();

            }
            else { 
            
            
            }
           
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
