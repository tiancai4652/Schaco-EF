using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Sqlite.Model.Course
{
    public class CourseBase : ICourse
    {
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public string ID { get; set ; }
    }
}
