using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppStudent1.Models;

namespace WebAppStudent1.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            List<Student> studList = new List<Student>()
            {
                new Student(){SId=101,SName="Reshma",SDob=DateTime.Parse("22/11/1998"),SContact=9875641230},
                new Student(){SId=102,SName="Sahil",SDob=DateTime.Parse("14/02/1997"),SContact=8256397410},
                new Student(){SId=103,SName="Abeer",SDob=DateTime.Parse("02/11/2000"),SContact=7458963021},
                new Student(){SId=104,SName="Koyal",SDob=DateTime.Parse("15/12/1996"),SContact=9876541230},
                new Student(){SId=105,SName="Sameeksha",SDob=DateTime.Parse("01/01/2000"),SContact=8527401963}
            };
            ViewBag.Students = studList;
            ViewBag.TotalStudents = studList.Count();
            return View();
        }
    }
}