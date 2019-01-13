using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication19.Models;

namespace WebApplication19.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        santisar_Entities db =new santisar_Entities();
        public ActionResult Index()
        {
            return View(db.STUDENTS.ToList());
        }
    }
}