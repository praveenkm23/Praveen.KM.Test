using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotNetTechChallenge.Controllers
{
    public class TechChallengeController : Controller
    {
        // GET: TechChallenge
        public ActionResult Index()
        {
            ViewBag.Title = "Tech Challenge Page";

            return View();
        }
    }
}