using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServerProductWebService
{
    /// <summary>
    /// Summary description for CustomerWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CustomerWebService : System.Web.Services.WebService
    {
        MusteriBaglantiDataContext musteriDb = new MusteriBaglantiDataContext();
        [WebMethod]
        public List<MusteriSonuc> MusteriGetir()
        {
            return musteriDb.Customers.Select(x=> new MusteriSonuc() { 
            MusteriId=x.CustomerID,
            SirketAdi=x.CompanyName,
            MusteriAdi=x.ContactName,
            Telefon=x.Phone
            }).ToList();
        }

    }
    public class MusteriSonuc
    {
        public string MusteriId { get; set; }
        public string SirketAdi { get; set; }
        public string MusteriAdi { get; set; }
        public string Telefon { get; set; }

    }
}
