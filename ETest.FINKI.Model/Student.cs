using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETest.FINKI.Model
{
    public class Student
    {
        private Guid _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _indexNumber;
        private Guid _createdBy;
        private Guid _modifiedBy;
        private DateTime _createdAt;
        private DateTime _modifiedAt;
        private IList<Course> _enrolledCourses;
    }
}
