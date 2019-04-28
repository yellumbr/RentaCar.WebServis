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
    /// Summary description for YoneticiWebServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class YoneticiWebServis : System.Web.Services.WebService
    {

        [WebMethod]
        public bool YoneticiEkle(Yonetici entity)
        {
            try
            {
                using (var business = new YoneticiBusiness())
                {
                    business.YoneticiEkle(entity);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public bool YoneticiGuncelle(Yonetici entity)
        {
            try
            {
                using (var business = new YoneticiBusiness())
                {
                    business.YoneticiGuncelle(entity);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public bool YoneticiIdSil(int id)
        {
            try
            {
                using (var business = new YoneticiBusiness())
                {
                    business.YoneticiIdSil(id);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public Yonetici[] YoneticiHepsiniSec()
        {
            try
            {
                using (var business = new YoneticiBusiness())
                {
                    return business.YoneticiHepsiniSec().ToArray();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public Yonetici YoneticiIdSec(int id)
        {
            try
            {
                using (var business = new YoneticiBusiness())
                {
                    return business.YoneticiIdSec(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
