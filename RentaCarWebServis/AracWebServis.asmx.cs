using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Models.Concretes;
using Business.Concretes;

namespace RentaCarWebServis
{
    /// <summary>
    /// Summary description for AracWebServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AracWebServis : System.Web.Services.WebService
    {

        [WebMethod]
        public bool AracEkle(Araclar arac,Sirket sirket)
        {
            try
            {
                using (var business = new AraclarBusiness())
                {
                    business.AracEkle(arac,sirket);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public bool AracKirala(Araclar arac)
        {
            try
            {
                using (var business = new AraclarBusiness())
                {
                    business.AracGuncelle(arac);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public bool AracGuncelle(Araclar entity)
        {
            try
            {
                using (var business = new AraclarBusiness())
                {
                    business.AracGuncelle(entity);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public bool AracIdSil(int id,Sirket sirket)
        {
            try
            {
                using (var business = new AraclarBusiness())
                {
                    business.AracIdSil(id,sirket);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public List<Araclar> AracHepsiniSec()
        {
            try
            {
                using (var business = new AraclarBusiness())
                {
                    return business.AracHepsiniSec();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public Araclar AracIdSec(int id)
        {
            try
            {
                using (var business = new AraclarBusiness())
                {
                    return business.AracIdSec(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
