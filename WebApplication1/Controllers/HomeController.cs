using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }


        [HttpGet]
        public ActionResult Edit(string id)
        {
            HeaderTagViewModel model = new HeaderTagViewModel();
            model.ItemTagID = "star";


            ItemTagConfigViewModel itemTagConfigView1 = new ItemTagConfigViewModel();
            var newgenders = new List<string>() { "man", "woman", "kids", "girls" };
            string selectedgender1 = "kids";
            itemTagConfigView1.Genders = newgenders.Select(x => new SelectListItem()
            {
                Text = x.ToString(),
                Value = x.ToString(),
                Selected = selectedgender1 == x.ToString()
            });
            itemTagConfigView1.Selectedgender = selectedgender1;
            model.itemTagConfigList.Add(itemTagConfigView1);

            ItemTagConfigViewModel itemTagConfigView2 = new ItemTagConfigViewModel();
            string selectedgender2 = "man";
            itemTagConfigView2.Genders = newgenders.Select(x => new SelectListItem()
            {
                Text = x.ToString(),
                Value = x.ToString(),
                Selected = selectedgender2 == x.ToString()
            });
            itemTagConfigView2.Selectedgender = selectedgender2;
            model.itemTagConfigList.Add(itemTagConfigView2);
            return View(model);
        }


        [HttpParamAction]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConf(HeaderTagViewModel model)
        {
            string selectedgender1 = "woman";
            var newgenders1 = new List<string>() { "man", "woman", "kids", "girls" };
            model.itemTagConfigList[0].Genders = newgenders1.Select(x => new SelectListItem()
            {
                Text = x.ToString(),
                Value = x.ToString(),
                Selected = selectedgender1 == x.ToString()
            });
            model.itemTagConfigList[0].Selectedgender = selectedgender1;



            string selectedgender2 = "girls";
            var newgenders2 = new List<string>() { "man", "woman", "kids", "girls" };
            model.itemTagConfigList[1].Genders = newgenders2.Select(x => new SelectListItem()
            {
                Text = x.ToString(),
                Value = x.ToString(),
                Selected = selectedgender2 == x.ToString()
            });
            model.itemTagConfigList[1].Selectedgender = selectedgender2;
            return View("Edit", model);
        }
    }
}