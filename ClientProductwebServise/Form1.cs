using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientProductwebServise.ProductWebServiceReferenceComsumer;
using ClientProductwebServise.MusteriWebServiceReferenceConsumer;
namespace ClientProductwebServise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductWebServiceSoapClient proxy = new ProductWebServiceSoapClient();
         string msg=   proxy.HelloWorld();
            MessageBox.Show(msg);
        }

        private void btnGetUrun_Click(object sender, EventArgs e)
        {
            ProductWebServiceSoapClient urunGetir = new ProductWebServiceSoapClient();
          dataGridView1.DataSource=  urunGetir.UrunleriGetir();
        }

        private void btnMusteriGetir_Click(object sender, EventArgs e)
        {
            CustomerWebServiceSoapClient musteriGetir = new CustomerWebServiceSoapClient();
            dataGridView1.DataSource= musteriGetir.MusteriGetir();
        }
    }
}
