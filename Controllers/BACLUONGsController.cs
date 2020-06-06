using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using qlthpt.Models;

namespace QLTHPT.Controllers
{
    public class BACLUONGsController : Controller
    {
        private acomptec_qlthptContext db = new acomptec_qlthptContext();

        // GET: BACLUONGs
        public ActionResult Index()
        {
            return View(db.Bacluong.ToList());
        }


    }
}
