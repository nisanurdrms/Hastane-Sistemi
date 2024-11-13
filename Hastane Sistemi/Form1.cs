using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxHastaAdi.Text) ||
                string.IsNullOrWhiteSpace(textBoxSoyadi.Text) ||
                string.IsNullOrWhiteSpace(textBoxTeshis.Text))
            {
                MessageBox.Show("Lütfen zorunlu alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hasta hasta = new Hasta(textBoxHastaAdi.Text, textBoxSoyadi.Text);
            Teshis teshis = new Teshis(textBoxTeshis.Text);
            Tedavi tedavi = !string.IsNullOrWhiteSpace(textBoxIlac.Text) || !string.IsNullOrWhiteSpace(textBoxTedavi.Text)
                            ? new Tedavi(textBoxIlac.Text, textBoxTedavi.Text)
                            : null;

            HastaKayit kayit = new HastaKayit(hasta, teshis, tedavi);

            listBoxKayitlar.Items.Add(kayit.HastaBilgisi());
            listBoxKayitlar.Items.Add(kayit.TeshisBilgisi());
            if (!string.IsNullOrEmpty(kayit.TedaviBilgisi()))
            {
                listBoxKayitlar.Items.Add(kayit.TedaviBilgisi());
            }

        }


        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxHastaAdi.Clear();
            textBoxSoyadi.Clear();
            textBoxTeshis.Clear();
            textBoxIlac.Clear();
            textBoxTedavi.Clear();
            listBoxKayitlar.Items.Clear();
        }
    }
}
