using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWithFluentAPI.Model
{
    public class Grade
    {
        public String Key { get; set; }
        public string GradeName { get; set; }
        public virtual ICollection<Student> Students { get; set; }


    }
}
