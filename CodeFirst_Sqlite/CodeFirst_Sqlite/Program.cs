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
        private static void Main()
        {
            DBContext.DBContext x = new DBContext.DBContext();
            var s = x.EMei.Include(t => t.Students).FirstOrDefault();
            var s1 = x.WuDang.Include(t => t.Students).FirstOrDefault();
            var s2 = x.ShaoLin.Include(t => t.Students).FirstOrDefault();
            //var s3 = x.Student.Include(t => t.Courses).ThenInclude(x => x.Weapon).FirstOrDefault();
        }
    }
}
