using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsDemo.Controllers
{
    public class StudentController : Controller
    {
        //StatusCodes
        //100
        //200 success
        //203 success NoContent
        //400 BadRequest /students?start=-10&limit=
        //401 Unauthenticated -> Unauthorized
        //403 UnAuthorized -> Forbidden
        //500 forgotten try-catch

        public ActionResult Info()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        [ActionName("view")]
        //[Route("design/view/{id}")]
        public ViewResult ViewResult(int id)
        {
            return View("~/Views/Student/View.cshtml");
        }

        [ActionName("partialview")]
        public PartialViewResult PartialViewResult()
        {
            return PartialView();
        }

        [ActionName("json")]
        public JsonResult JsonResult()
        {
            var anonymous = new
            {
                age = 2,
                firstName = "dzevo",
                lastName = "ibraimi"
            };

            return Json(anonymous, JsonRequestBehavior.AllowGet);
        }

        [ActionName("toindex")]
        public ActionResult RedirectToIndex()
        {
            return RedirectToAction("Index");
        }

    }
}