using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesDemo
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    /// namespace System.Web.Services
    /// public sealed class WebServiceAttribute : Attribute
    /// public string Namespace { get; set; }
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
   //[System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {
        // SessionState ApplicationState Asp.net gibi uygulamalrın objelerine erişmek için  System.Web.Services.WebService miras almak gerekir.

        //  [WebMethod] projeyi dış dünyaya açar. 
        // [WebMethod] kullanmak zorunlu yazmazsak gözükmez 
        [WebMethod]
        public int Add(int firstNumber,int secondNumber)
        {
            List<string> calculations;
            if (Session["CALCULATIONS"]==null)
            {
                calculations = new List<string>();
            }
            else
            {
              //  calculations = Session["CALCULATIONS"] as List<string>;
                calculations =(List<string>) Session["CALCULATIONS"] ;
            }
            string strRecentCalculation = firstNumber.ToString() + " + " + secondNumber.ToString() + " = " + (firstNumber + secondNumber).ToString();
            calculations.Add(strRecentCalculation); ;
            Session["CALCULATIONS"] = calculations;
            return firstNumber + secondNumber;
        }
        [WebMethod ]
        public List<string> GetCalculations()
        {
            if (Session["CALCULATIONS"]==null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("herhangi bir hesaplama yapmadınız");
                return calculations;
            }
            else
            {
                return (List<string>)Session["CALCULATIONS"];
            }

        }
    }
    //https://localhost:44309/CalculatorWebService.asmx
    //https://localhost:44309/CalculatorWebService.asmx?WSDL
    //https://localhost:44309/CalculatorWebService.asmx/Add
    //https://localhost:44309/CalculatorWebService.asmx?op=Add

}
