using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing.Imaging;

namespace MvcApplication4.Controllers
{
    public class Cars
            {
                public string model { get; set;}
                public string color {get; set;}
                public string number{get; set;}
                BitmapData image;
                public Cars(string mod, string col, string num) 
                {
                    this.model = mod;
                    this.color = col;
                    this.number = num;
                }   
                public string getColor()
                {
                    return this.color;
                }
            }
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Cars Cars = new Cars("VAZ21044", "Blue", "695");
            Cars Car1 = new Cars("Renault", "Yellow", "001");
            Cars Car2 = new Cars("Ferrari", "Red", "002");
            Cars Car3 = new Cars("BMW", "Blue", "003");
            Cars Car4 = new Cars("Mersedes", "Lightgrey", "004");
            Cars Car5 = new Cars("Audi", "Gray", "005");
            var myCars = new List<Cars>();
            myCars.Add(Car1);
            myCars.Add(Car2);
            myCars.Add(Car3);
            myCars.Add(Car4);
            myCars.Add(Car5);
            
            ViewBag.Meage = "Modify this template to jump-start your ASP.NET MVC application.";
            return View(myCars);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
