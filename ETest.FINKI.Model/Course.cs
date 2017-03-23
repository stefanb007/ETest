using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETest.FINKI.Model
{
    public class Course
    {
        private Guid _id;
        private string _name;
        private Staff _createdBy;
        private Staff _modifiedBy;
        private DateTime _createdAt;
        private DateTime _modifiedAt;

        #region Constructors

        protected Course() {}

        public Course(string name, Staff createdBy, Staff modifiedBy, DateTime createdAt, DateTime modifiedAt, int semester)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (createdBy == null) throw new ArgumentNullException(nameof(createdBy));
            if (modifiedBy == null) throw new ArgumentNullException(nameof(modifiedBy));
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (createdBy == null) throw new ArgumentNullException(nameof(createdBy));
            if (semester > 8 || semester < 1)
                throw new ArgumentOutOfRangeException(nameof(semester));

            _name = name;
            _createdBy = createdBy;
            _createdAt = createdAt;
            _modifiedAt = modifiedAt;
            _modifiedBy = modifiedBy;
        }

        #endregion Constructors


        #region Properties

        public virtual Guid Id {
            get { return _id; }
            set { _id = value; }
        }

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual Staff CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public virtual DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }

        public virtual Staff ModifiedBy
        {
            get { return _modifiedBy; }
            set { _modifiedBy = value; }
        }

        public virtual DateTime ModifiedAt
        {
            get { return _modifiedAt; }
            set { _modifiedAt = value; }
        }

        public virtual int Semester { get; set; }

        #endregion Properties
    }
}
