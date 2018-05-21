using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewsDemo.Models;

namespace ViewsDemo.Controllers
{
    

    public class PictureController : Controller
    {
        
    

        

        public ActionResult Index()
        {
            SedcDatabase database = new SedcDatabase();
            List<Picture> pictures = database.Pictures
                .ToList();
            return View(pictures);
        }

        public ActionResult Create()
        {

            //string path =  Directory.GetCurrentDirectory();
            return View("~/Views/Picture/CreateWithHelpers.cshtml");
        }

        [HttpPost]
        public ActionResult Create(Picture picture)
        {
            if (ModelState.IsValid)
            {
                var db = new SedcDatabase();
                db.Pictures.Add(picture);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("~/Views/Picture/CreateWithHelpers.cshtml", picture);
        }

        // GET: Image/Details/5
        public ActionResult Details(int id)
        {
            var db = new SedcDatabase();
            var image = db.Pictures.FirstOrDefault(i => i.Id == id);
            return View(image);
        }

        // GET: Image/Edit/5
        public ActionResult Edit(int id)
        {
            var db = new SedcDatabase();
            var image = db.Pictures.FirstOrDefault(i => i.Id == id);
            return View(image);
        }

        // POST: Image/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Picture image)
        {

            var db = new SedcDatabase();
            
        
            var img = db.Pictures.FirstOrDefault(x => x.Id == id);
            
            if (img == null)
            {
                return RedirectToAction("Index");
            }

            image.DisplayName = image.DisplayName;
            image.Id = image.Id;
            image.Url = image.Url;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Image/Delete/5
        public ActionResult Delete(int id)
        {
            var db = new SedcDatabase();
            var image = db.Pictures.FirstOrDefault(i => i.Id == id);
            return View(image);

        }

        // POST: Image/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Picture image)
        {
            var db = new SedcDatabase();
            var imageId = db.Pictures.FirstOrDefault(c => c.Id == id);
            db.Pictures.Remove(imageId);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}