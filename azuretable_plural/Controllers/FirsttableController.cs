using azuretable_plural.Models;
using ConnectingAzTable_plural.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace azuretable_plural.Controllers
{
    public class FirsttableController : Controller
    {
        // GET: Firsttable
        public ActionResult Index()
        {
            var repository = new Firsttable();

            var entities = repository.All();

            var models = entities.Select(x => new FirsttableModel
            {
                Email = x.RowKey,
                Name = x.PartitionKey,
                PhoneNum = x.PhoneNum,
                timestamp= x.Timestamp

            });
            
            return View(models);
        }
    }
}