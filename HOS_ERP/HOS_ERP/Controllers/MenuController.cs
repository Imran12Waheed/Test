using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HOS_ERP.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public PartialViewResult GenerateMenu()
        {
            return PartialView();
        }
    }
}