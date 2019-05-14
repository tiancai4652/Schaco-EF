using CodeFirst_Sqlite.Model.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Sqlite.Model
{
    public interface ICourse: Iid
    {
        string Name { get; set; }
        ICollection<Student> Students { get; set; }
    }
}
