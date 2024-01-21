using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Efendioglu.Models
{
    public class Yapi

    {
        
        public int YapiId { get; set; }
        public string YapiAdi { get; set; }
        public string YapiTarih { get; set; }
        public int YapiAlan { get; set; }
        public string YapiSahip { get; set; }
        public int YapiFiyat { get; set; }

        public string DosyaAdi { get; set; }

        public string DosyaYolu { get; set; }



    }
    // uygulama durduğu zaman elemanlar gider
    public static class Veritabani // static olması burada nesne işinin olmadığını gösterir
    {
        private static List<Yapi> _liste;
        static Veritabani()
        {
            _liste = new List<Yapi>()
            {
                
                //new Yapi() {YapiId=1,YapiAdi="ofis",YapiAlan=1000,YapiFiyat=1000,YapiSahip="metehan",YapiTarih="10 Ocak 2022",DosyaAdi="ofis.jpeg",DosyaYolu="~/yapi_gorsel/bina.jpeg"},
                //new Yapi() {YapiId=2,YapiAdi="dükkan",YapiAlan=5000,YapiFiyat=5000,YapiSahip="veli",YapiTarih="10 Ocak 2002",DosyaAdi="ofis.jpeg",DosyaYolu="~/yapi_gorsel/bina.jpeg"},
                //new Yapi() {YapiId=3,YapiAdi="ev",YapiAlan=300,YapiFiyat=300,YapiSahip="veli",YapiTarih="10 Ocak 2022",DosyaAdi="ofis.jpeg",DosyaYolu="~/yapi_gorsel/bina.jpeg"}
            };



        }

        public static List<Yapi> Liste
        {
            get { return _liste; }
        }
        public static void YapiEkle(Yapi entity)

        {
            _liste.Add(entity);

        }
        public static Yapi YapiDetay(int YapiId)

        {
            Yapi entity = null;
            foreach (var yapi in _liste)
            {
                if (yapi.YapiId == YapiId)
                {
                    entity = yapi;
                }
            }
            return entity;
        }
    }
}