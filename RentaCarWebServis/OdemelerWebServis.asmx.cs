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
    /// Summary description for OdemelerWebServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OdemelerWebServis : System.Web.Services.WebService
    {

        [WebMethod]
        public bool OdemeEkle(Odemeler entity)
        {
            try
            {
                using (var business = new OdemelerBusiness())
                {
                    business.OdemeEkle(entity);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public bool OdemelerGuncelle(Odemeler entity)
        {
            try
            {
                using (var business = new OdemelerBusiness())
                {
                    business.OdemeGuncelle(entity);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public bool OdemelerIdSil(int id)
        {
            try
            {
                using (var business = new OdemelerBusiness())
                {
                    business.OdemeIdSil(id);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public List<Odemeler> OdemelerHepsiniSec()
        {
            try
            {
                using (var business = new OdemelerBusiness())
                {
                    return business.OdemeHepsiniSec();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public Odemeler OdemelerIdSec(int id)
        {
            try
            {
                using (var business = new OdemelerBusiness())
                {
                    return business.OdemeIdSec(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
