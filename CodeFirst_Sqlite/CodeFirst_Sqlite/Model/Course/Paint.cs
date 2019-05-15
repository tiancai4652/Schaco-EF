using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Sqlite.Model.Course
{
    [Table("Paint")]
    public class Paint : CourseBase
    {
        public Paint()
        {
            ID = Guid.NewGuid().ToString("N");
        }

    }
}
