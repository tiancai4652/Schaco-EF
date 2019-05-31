using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWithFluentAPI.Model
{
    public class Student
    {
        public String id { get; set; }
        public String Key { get; set; }
        public string StudentName1 { get; set; }
        public string StudentNo { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
