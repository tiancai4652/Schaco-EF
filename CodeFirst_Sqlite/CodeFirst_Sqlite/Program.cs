using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst_Sqlite.DBContext;

namespace CodeFirst_Sqlite
{
    public static class Program
    {
        //1 对1 Student-Weapon

        //1对多 Student-SChool

        //多对多  Course - Student

        private static void Main()
        {
            DBContext.DBContext x = new DBContext.DBContext();
            var s = x.EMei.FirstOrDefault();
            var s1 = x.WuDang.Include(t => t.Students).FirstOrDefault();
            var s2 = x.ShaoLin.Include(t => t.Students).FirstOrDefault();
            //var s3 = x.Student.Include(t => t.Courses).ThenInclude(m => m.Weapon).FirstOrDefault();
        }
    }
}
