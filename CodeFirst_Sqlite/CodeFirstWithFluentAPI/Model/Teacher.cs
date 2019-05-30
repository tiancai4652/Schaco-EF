using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWithFluentAPI.Model
{
    public class Teacher
    {
        public String Key { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public string Name { get; set; }
    }
}
