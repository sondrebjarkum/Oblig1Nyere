using Oblig1Nyere.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oblig1Nyere.Controllers
{
    public class HomeController : Controller
    {
        private DB db = new DB();
        public ActionResult Index()
        {
            IEnumerable<Reise> alleReiser = db.Reise;
            //var alleReiser = db.Reise.ToList();
            return View(alleReiser);
        }
        public PartialViewResult SokReiser(string nokkelord)
        {
            DB db = new DB();
            //System.Threading.Thread.Sleep(2000);
            var data = db.Reise.Where(f =>
            f.Avgang.StartsWith(nokkelord)).ToList();
            return PartialView(data);
        }

        public class Ajaxcontroller : Controller
        {
            public ActionResult Index()
            {
                var db = new DB();
                IEnumerable<Reise> reise = db.Reise;
                return View(reise);
            }
        }

        [HttpPost]
        public ActionResult KjopBillett(FormCollection innListe)
        {
            DB db = new DB();
    
            if (innListe["fra"] == "fra")//møl
            {
                System.Diagnostics.Debug.WriteLine("Inn i første If "+ innListe["Dato"]);

                if(innListe["Dato"] == "2019-10-15")
                {
                    System.Diagnostics.Debug.WriteLine("Inn i andre If " + innListe["Tid"]);

                    if (innListe["Tid"] == "08:00")
                    {
                        System.Diagnostics.Debug.WriteLine("Inn i tredje If");

                        Reise enreise = db.Reise.FirstOrDefault(p => p.Avgang == "Oslo");
                        Billett nyBillett = new Billett
                        {
                            ReiseId = enreise.Id
                        };
                        db.Billetter.Add(nyBillett);
                        db.SaveChanges();
                    }
                }
            }

         
            var alleBilletter = db.Billetter.ToList();
            return View(alleBilletter);
        }
    }
}