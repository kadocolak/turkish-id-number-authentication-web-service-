using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TC_Kimlik_Doğrulama_Web_Servis.TCKimlik;

namespace TC_Kimlik_Doğrulama_Web_Servis.Controllers
{
    public class HomeController : Controller
    {
        TCKimlik.KPSPublic webServis = new TCKimlik.KPSPublic();
        public static Boolean result;

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Sorgula(long tcNo,string ad,string soyad,int dogumYili)
        {
            try
            {
                if (string.IsNullOrEmpty(tcNo.ToString()) || string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(dogumYili.ToString()))
                {
                    return Json("required field is not empty", JsonRequestBehavior.AllowGet);
                }
                else
                {
                    try
                    {
                        result = webServis.TCKimlikNoDogrula(tcNo, ad, soyad, dogumYili);
                        return Json(result.ToString(), JsonRequestBehavior.AllowGet);
                    }
                    catch
                    {
                        return Json("web service connection error", JsonRequestBehavior.AllowGet);
                    }
                }
            }
            catch
            {
                return Json("input data error", JsonRequestBehavior.AllowGet);
            }
        }


        [HttpGet]
        public JsonResult Sorgula() 
        {
            return Json("this web service not working GET method", JsonRequestBehavior.AllowGet);
        }


    }
}