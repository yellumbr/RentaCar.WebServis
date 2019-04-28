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
    /// Summary description for MusterilerWebServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CustomerWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public bool MusteriEkle(Musteriler entity)
        {
            try
            {
                using (var business = new MusterilerBusiness())
                {
                    business.MusteriEkle(entity);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public bool MusteriGuncelle(Musteriler entity)
        {
            try
            {
                using (var business = new MusterilerBusiness())
                {
                    business.MusteriGuncelle(entity);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public bool MusteriIdSil(int id)
        {
            try
            {
                using (var business = new MusterilerBusiness())
                {
                    business.MusteriIdSil(id);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public Musteriler[] MusteriHepsiniSec()
        {
            try
            {
                using (var business = new MusterilerBusiness())
                {
                    return business.MusteriHepsiniSec().ToArray();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public Musteriler MusteriIdSec(int id)
        {
            try
            {
                using (var business = new MusterilerBusiness())
                {
                    return business.MusteriIdSec(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
