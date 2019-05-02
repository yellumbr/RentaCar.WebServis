using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Business.Concretes;
using Models.Concretes;
namespace RentaCarWebServis
{
    /// <summary>
    /// Summary description for SirketWebServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SirketWebServis : System.Web.Services.WebService
    {

        [WebMethod]
        public bool SirketEkle(Sirket entity)
        {
            try
            {
                using (var business = new SirketBusiness())
                {
                    business.SirketEkle(entity);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public bool SirketGuncelle(Sirket entity)
        {
            try
            {
                using (var business = new SirketBusiness())
                {
                    business.SirketGuncelle(entity);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public bool SirketIdSil(int id)
        {
            try
            {
                using (var business = new SirketBusiness())
                {
                    business.SirketIdSil(id);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public List<Sirket> SirketHepsiniSec()
        {
            try
            {
                using (var business = new SirketBusiness())
                {
                    return business.SirketHepsiniSec();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public Sirket SirketIdSec(int id)
        {
            try
            {
                using (var business = new SirketBusiness())
                {
                    return business.SirketIdSec(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
