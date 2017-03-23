using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETest.FINKI.Model;

namespace ETest.FINKI.Business
{
    public class CourseService : ICourseService
    {
        public Course GetCourseById(Guid courseId)
        {
            return new Course("Course #1", new Staff(), new Staff(), new DateTime(), new DateTime(), 4);
        }

        public List<Course> GetAllCourses()
        {
            var list = new List<Course>
            {
                new Course("Course #1", new Staff(), new Staff(), new DateTime(), new DateTime(), 4),
                new Course("Course #2", new Staff(), new Staff(), new DateTime(), new DateTime(), 2),
                new Course("Course #3", new Staff(), new Staff(), new DateTime(), new DateTime(), 8),
                new Course("Course #4", new Staff(), new Staff(), new DateTime(), new DateTime(), 9)
            };

            return list;
        }

    }

    public interface ICourseService
    {
        Course GetCourseById(Guid courseId);
        List<Course> GetAllCourses();
    }
}
