using CodeFirst_Sqlite.Model.Course;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Sqlite.Model
{
    [Table("Chinese")]
    public class Chinese : CourseBase
    {
        public Chinese()
        {
            ID = Guid.NewGuid().ToString("N");
        }

        //public string Name { get  ; set  ; }
        //[Key]
        //public string ID { get  ; set  ; }

        //public virtual IEnumerable<Student> Students { get; set; }

        public string Extend { get; set; }
    }
}
