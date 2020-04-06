using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HiSpaceListingWeb.Controllers
{
    public class ListingController : Controller
    {

        public ActionResult ListerDetail()
        {
            return View();
        }

        public ActionResult ListerProperty()
        {
            return View();
        }

        public ActionResult ListerProfile()
        {
            return View();
        }

        public ActionResult ListerManagement()
        {
            return View();
        }

        public ActionResult ListingForm()
        {
            return View();
        }
    }
}