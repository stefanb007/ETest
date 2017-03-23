using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ETest.FINKI.Business;
using System.Web.Script.Serialization;


namespace ETest.FINKI.Web.Controllers.Api
{
    public class CoursesController : Controller
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public ActionResult GetAllCourses()
        {
            var courses =  _courseService.GetAllCourses();
            return Json(courses);
        }

        public ActionResult GetCourseById(Guid id)
        {
            id = Guid.NewGuid();
            var course = _courseService.GetCourseById(id);
            return Json(course);
        }
    }
}