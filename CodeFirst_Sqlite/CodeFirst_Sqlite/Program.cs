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

        //https://www.nuget.org/packages/EntityFramework/6.3.0-preview5-19254-05
        //Install-Package EntityFramework -Version 6.3.0-preview5-19254-05 To Get EF6.3



        //1 对1 Student-Weapon

        //1对多 Student-SChool

        //多对多  Course - Student

        private static void Main()
        {
            DBContext.DBContext x = new DBContext.DBContext();
            x.Database.Log = (c) => { System.Diagnostics.Debug.WriteLine("0514:"+c); };
            var s = x.EMei.FirstOrDefault();
            var s1 = x.WuDang.Include(t => t.Students).FirstOrDefault();
            var s2 = x.ShaoLin.Include(t => t.Students.Select(r=>r.Weapon)).FirstOrDefault();
            //var s3 = x.Student.Include(t => t.Courses).ThenInclude(m => m.Weapon).FirstOrDefault();


            //var s3 = x.StudentWeaponView.FirstOrDefault();
        }
    }
}
