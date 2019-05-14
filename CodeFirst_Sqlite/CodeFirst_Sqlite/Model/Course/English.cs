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
    [Table("English")]
    public class English : CourseBase
    {
        public English()
        {
            ID = Guid.NewGuid().ToString("N");
        }
        //public string Name { get  ; set  ; }
        //[Key]
        //public string ID { get  ; set  ; }
        //public  IEnumerable<Student> Students { get; set; }
        public string Extend { get; set; }
    }
}
