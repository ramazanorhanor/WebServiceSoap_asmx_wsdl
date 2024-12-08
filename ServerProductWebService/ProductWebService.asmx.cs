using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServerProductWebService
{
    /// <summary>
    /// Summary description for ProductWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello ramazan sanada ";
        }
        [WebMethod]
        public List<UrunSonuc> UrunleriGetir()
        {
            ProductBaglantiDataContext db = new ProductBaglantiDataContext();
            return db.Products.Select(x=> new UrunSonuc() { 
            UrunId=x.ProductID,
            UrunAdi=x.ProductName,
            Fiyat=x.UnitPrice,
            Stok=x.UnitsInStock,
            }).ToList();
        }
    }
    public class UrunSonuc
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal? Fiyat { get; set; }
        public short? Stok { get; set; }
    }
}
