using ecmapi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ecmapi.Controllers
{
    public class BaseController<T> : ApiController where T : class, new()
    {
        static ecomSchoolEntities ecom;
        static DbSet<T> dbset;
        public BaseController()
        {
            ecom = new ecomSchoolEntities();
            dbset = ecom.Set<T>();
        }
        public static void Save(T item)
        {
            ecom.Set<T>().Add(item);
            ecom.SaveChanges();
        }

        public static string Delete<T>(int id) where T : class
        {
            string error = "";
            var item = ecom.Set<T>().Find(id);
            if (item != null)
            {
                ecom.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                ecom.SaveChanges();
            }
            else
            {
                error = "No Record Found to Delete";
            }
            return error;
        }
        public async Task<T> UpdateAsync(T Item)
        {
            var result = ecom.Set<T>().Add(Item);
            ecom.Entry<T>(result).State = EntityState.Modified;
            return result;
        }
    }
}
