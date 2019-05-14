using CodeFirst_Sqlite.Model.Course;
using CodeFirst_Sqlite.Model.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Sqlite.Model
{
    public class Student:Iid
    {
        public Student()
        {
            ID = Guid.NewGuid().ToString("N");
        }
        public string Name { get; set; }
        public IWeapon Weapon { get; set; }
        public string ID { get; set; }
        public virtual ICollection<CourseBase> Courses { get; set; }
    }
}
