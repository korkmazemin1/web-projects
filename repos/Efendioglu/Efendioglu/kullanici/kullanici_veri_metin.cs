using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
namespace Efendioglu.kullanici
{
    public class kullanici_veri_metin : IdentityDbContext<kullanici>
    {
        public kullanici_veri_metin() : base("kullanici_iletisim")
        {
        }
    }
}
    