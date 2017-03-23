using ETest.FINKI.Model;
using FluentNHibernate.Mapping;

namespace ETest.FINKI.Data
{
    public class CourseMap : ClassMap<Course>
    {
        public CourseMap()
        {
            Schema("dbo");
            Table("Courses");

            Id(x => x.Id).Column("Id");

            Map(x => x.Name)
                .Access.CamelCaseField(Prefix.Underscore)
                .Not.Nullable()
                .Column("Name");

            References(x => x.CreatedBy)
                .Access.CamelCaseField(Prefix.Underscore)
                .Not.Nullable()
                .Column("CreatedBy");

            References(x => x.ModifiedBy)
                .Access.CamelCaseField(Prefix.Underscore)
                .Not.Nullable()
                .Column("ModifiedBy");

            Map(x => x.CreatedAt)
                .Access.CamelCaseField(Prefix.Underscore)
                .Not.Nullable()
                .Column("CreatedAt");

            Map(x => x.ModifiedAt)
                .Access.CamelCaseField(Prefix.Underscore)
                .Not.Nullable()
                .Column("ModifiedAt");
        }
    }
}
