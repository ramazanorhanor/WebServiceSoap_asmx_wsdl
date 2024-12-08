using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebServiceTCKimlikDogrulama.TCKNServiceReferenceConsumer;

namespace WebServiceTCKimlikDogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTCDogrula_Click(object sender, EventArgs e)
        {
            KPSPublicSoapClient tcDogrula = new KPSPublicSoapClient();
        bool sonuc=    tcDogrula.TCKimlikNoDogrula(Convert.ToInt64(txtTCKN.Text),txtAd.Text,txtSoyad.Text,Convert.ToInt32(txtDogumYili.Text));

            if (sonuc==true)
            {
                MessageBox.Show("bilgiler dogru");
            }
            else
            {
                MessageBox.Show("bilgiler yanlış");
            }
        }
    }
}
