using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using demo.Models;
using MongoDB.Driver;

namespace demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = collection.Find
            (FilterDefinition<ThietBi>.Empty).ToList();

            return View(model);
        }


        //public ActionResult Details(int id)
        //{
        //    var model = CTTB.Find
        //    (FilterDefinition<ChiTietTB>.Empty).ToList().Where(n=>n.MATB==id);

        //    return View(model);
        //}
        private IMongoCollection<ThietBi> collection;
        //private IMongoCollection<ChiTietTB> CTTB;

        public HomeController()
        {
            //code keets noi
            var client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase db = client.GetDatabase("test");
            this.collection = db.GetCollection<ThietBi>("THIETBI");
            //this.CTTB= db.GetCollection<ChiTietTB>("CHITIETTB");
        }
    }
}