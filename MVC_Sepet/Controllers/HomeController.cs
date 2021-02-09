using MVC_Sepet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Sepet.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities1 db = new NorthwindEntities1();
        public ActionResult Index()
        {
            ViewBag.Categories = db.Categories.ToList();
            return View(db.Products.ToList());
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
        public ActionResult AddToCart(int id)//
        {
            Product eklenecek = db.Products.Find(id);

            
            Card c = Session["cart"] == null ? new Card() : Session["cart"] as Card;

            CardItem cartItem = new CardItem();
            cartItem.ID = eklenecek.ProductID;
            cartItem.UnitPrice = eklenecek.UnitPrice;
            cartItem.Name = eklenecek.ProductName;

            c.AddItem(cartItem);
            Session["cart"] = c;



            return RedirectToAction("Index");
        }
    }
}
    
