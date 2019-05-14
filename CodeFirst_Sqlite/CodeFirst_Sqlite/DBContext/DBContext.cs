using CodeFirst_Sqlite.Model;
using CodeFirst_Sqlite.Model.Course;
using CodeFirst_Sqlite.Model.Weapon;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Sqlite.DBContext
{
    public class DBContext : DbContext
    {
        public IDbSet<Chinese> Chinese { get; set; }
        public IDbSet<English> English { get; set; }
        public IDbSet<Sport> Sport { get; set; }

        public IDbSet<EMei> EMei { get; set; }
        public IDbSet<ShaoLin> ShaoLin { get; set; }
        public IDbSet<WuDang> WuDang { get; set; }

        public IDbSet<Weapon> Weapon { get; set; }


        public IDbSet<Student> Student { get; set; }

        public DBContext() : base("name=SqliteConnectionString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DBContext, Migrations.Configuration>(true));
        }




    }


}
