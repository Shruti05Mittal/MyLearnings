using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GaneshAlmirah.Models;

namespace GaneshAlmirah.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        GaneshAlmirahEntities db = new GaneshAlmirahEntities();
        public ActionResult GetDesigination()
        {
            List<WorkType> lstWorkTypes = new List<WorkType>();
            List<Desgination>lstDesginations = db.Desginations.ToList();
            fo
           
            return View(); 
        }
        public ActionResult SaveEmployee()
        {
            return View(); 
        }
    }
}