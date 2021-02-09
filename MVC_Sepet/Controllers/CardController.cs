﻿using MVC_Sepet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Sepet.Controllers
{
    public class CardController : Controller
    {
        NorthwindEntities1 db = new NorthwindEntities1();
        // GET: Card
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RemoveProduct(int productId)
        {
            var product = db.Products.Find(productId);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult UpdateProduct(int productId)
        {
            var product = db.Products.Find(productId);
            return View(product);
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            var updated = db.Products.Find(product.ProductID);
            updated.ProductName = product.ProductName;
            updated.UnitPrice = product.UnitPrice;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
    
