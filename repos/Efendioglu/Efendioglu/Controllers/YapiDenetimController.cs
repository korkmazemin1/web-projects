using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Efendioglu.Models;
using System.IO;

namespace Efendioglu.Controllers
{
    [Authorize]
    public class YapiDenetimController : Controller
    {
        
        // GET: YapiDenetim
        public ActionResult Bedel_Hesapla()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Yapilar(string YapiAdi,string YapiSahip,string YapiTarih,int YapiAlan,int YapiFiyat, HttpPostedFileBase dosya)
            
        {
            Yapi entity = new Yapi();
            entity.YapiAdi = YapiAdi;
            entity.YapiSahip = YapiSahip;
            entity.YapiTarih = YapiTarih;
            entity.YapiAlan = YapiAlan;
            entity.YapiFiyat = YapiFiyat;
            if (dosya != null && dosya.ContentLength > 0)
            {
                // Dosya adını alın
                string dosyaAdi = Path.GetFileName(dosya.FileName);

                // Dosyanın kaydedileceği yolu belirtin
                string dosyaYolu = Path.Combine(Server.MapPath("~/yapi_gorsel"), dosyaAdi);

                // Dosyayı kaydet
                dosya.SaveAs(dosyaYolu);

                // Dosya yolu veya adını Yapi nesnesine ekleyebilirsiniz
                entity.DosyaAdi = dosyaAdi;
                entity.DosyaYolu = dosyaYolu;
            }

            Veritabani.YapiEkle(entity);

            return View("yapilar", Veritabani.Liste);

        }


        [HttpGet]
        public ActionResult Yapilar()
        {
            // veri tabanınına bağlanan ve bilgileri getiren kısım 
            // çekilen veriler model kısmına bağlanır 

            List<Yapi> yapilar = new List<Yapi>()// models üzerinde hazırladığımız classa erişerek buradan onun bilgilerini getledik(hazırladık)
            {
                //new Yapi() {YapiId=1,YapiAdi="ofis",YapiAlan=1000,YapiFiyat=1000,YapiSahip="metehan",YapiTarih="10 Ocak 2022",DosyaAdi="bina.jpeg",DosyaYolu="C:/Users/korkm/source/repos/Efendioglu/Efendioglu/yapi_gorsel/bina.jpeg"},
                //new Yapi() {YapiId=2,YapiAdi="dükkan",YapiAlan=5000,YapiFiyat=5000,YapiSahip="veli",YapiTarih="10 Ocak 2002",DosyaAdi="bina.jpeg",DosyaYolu="~/yapi_gorsel/ofis.jpeg"},
                //new Yapi() {YapiId=3,YapiAdi="ev",YapiAlan=300,YapiFiyat=300,YapiSahip="veli",YapiTarih="10 Ocak 2022",DosyaAdi="bina.jpeg",DosyaYolu="~/yapi_gorsel/bina.jpeg"}
                
            };
            
            ViewBag.YapiSayisi = yapilar.Count();
            // bu şekilde bütün bir listeyide viewbag ile aktarabilirsin
            return View(yapilar);
        }

        
    }
}