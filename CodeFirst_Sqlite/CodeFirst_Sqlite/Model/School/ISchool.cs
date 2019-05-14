using CodeFirst_Sqlite.Model.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Sqlite.Model
{
    public interface ISchool: Iid
    {
        string Name { get; set; }
        List<Student> Students { get; set; }
    }
}
