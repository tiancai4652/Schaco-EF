using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst_Sqlite.DBContext;
using CodeFirst_Sqlite.Model;

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
            DBContext.DBContext content = new DBContext.DBContext();
            //x.Database.Log = (c) => { System.Diagnostics.Debug.WriteLine("0514:"+c); };

            //Find
            var s = content.EMei.FirstOrDefault();
            //var s1 = content.WuDang.Include(t => t.Students).FirstOrDefault();
            //var s2 = content.ShaoLin.Include(t => t.Students.Select(r => r.Weapon)).FirstOrDefault();

            //Delete
            if (s != null)
            {
                content.EMei.Remove(s);
                content.SaveChanges();
            }

            //Add/Update
            Student a = new Student();
            content.Student.AddOrUpdate(a);
            content.SaveChanges();


        }
    }
}
