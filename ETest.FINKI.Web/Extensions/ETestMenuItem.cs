using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETest.FINKI.Web.Extensions
{
    public class ETestMenuItem
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public List<ETestRoles> AllowedRoles { get; set; }
        public object Extra { get; set; }
        public bool? HideInNavigation { get; set; }
        public List<ETestMenuItem> SubNodes { get; set; }
    }

    public enum ETestRoles
    {
        ETestAdministrator = 0,
        ETestTeacher = 1,
        ETestStudent = 2
    }
}