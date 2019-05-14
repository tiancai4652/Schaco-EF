using CodeFirst_Sqlite.Model;
using CodeFirst_Sqlite.Model.Course;
using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Sqlite.DBContext
{
    public class DBContext: DbContext
    {
        public IDbSet<Chinese> Chinese { get; set; }
        public IDbSet<English> English { get; set; }
        public IDbSet<Sport> Sport { get; set; }

        public IDbSet<EMei> EMei { get; set; }
        public IDbSet<ShaoLin> ShaoLin { get; set; }
        public IDbSet<WuDang> WuDang { get; set; }

        public IDbSet<Hand> Hand { get; set; }
        public IDbSet<Stick> Stick { get; set; }
        public IDbSet<Sword> Sword { get; set; }

        public IDbSet<Student> Student { get; set; }

        public DBContext() : base("name=SqliteConnectionString")
        {
           
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<DBContext>(modelBuilder);
            //var sqliteConnectionInitializer = new SqliteDropCreateDatabaseWhenModelChanges<DBContext>(modelBuilder);
            var sqliteConnectionInitializer = new MyDbContextInitializer(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

            //modelBuilder.Entity<Student>()
            //    .HasMany<CourseBase>(s => s.Courses)
            //    .WithMany(c => c.Students);
            //.Map(cs =>
            //{
            //    cs.MapLeftKey("StudentRefId");
            //    cs.MapRightKey("CourseRefId");
            //    cs.ToTable("StudentCourse");
            //});
        }


    }

    public class MyDbContextInitializer : SqliteDropCreateDatabaseWhenModelChanges<DBContext>
    {
        public MyDbContextInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder) { }

        protected override void Seed(DBContext context)
        {
            Chinese chinese = new Chinese() { Name = "语文" };
            English english = new English() { Name = "英语" };
            Sport sport = new Sport() { Name = "体育" };

            Hand hand1 = new Hand() { Name = "金顶绵掌" };
            Hand hand2 = new Hand() { Name = "心佛掌" };

            Stick stick1 = new Stick() { Name = "韦陀棍法" };
            Stick stick2 = new Stick() { Name = "伏魔棍法" };

            Sword sword1 = new Sword() { Name = "太极剑法" };
            Sword sword2 = new Sword() { Name = "两仪剑法" };

            List<CourseBase> coursesList1 = new List<CourseBase>() { chinese ,english};
            List<CourseBase> coursesList2 = new List<CourseBase>() { chinese, sport };
            List<CourseBase> coursesList3 = new List<CourseBase>() { chinese, english,sport };

            Student student1 = new Student() { Name = "张三丰", Weapon = sword1, Courses = coursesList1 };
            Student student2 = new Student() { Name = "张翠山", Weapon = sword2, Courses = coursesList2 };

            Student student3 = new Student() { Name = "周芷若", Weapon = hand1, Courses = coursesList3 };
            Student student4 = new Student() { Name = "丁敏君", Weapon = hand2, Courses = coursesList1 };

            Student student5 = new Student() { Name = "一灯大师", Weapon = stick1, Courses = coursesList3 };
            Student student6 = new Student() { Name = "虚竹", Weapon = stick2, Courses = coursesList2 };

            chinese.Students = new List<Student>() { student1,student4};
            english.Students = new List<Student>() { student1, student3,student4 };
            sport.Students = new List<Student>() { student2, student4, student5, student6 };

            EMei emei = new EMei() { Name = "峨眉", Students=new List<Student> { student1, student2 , student3, student4, student5, student6} };
            ShaoLin shaolin = new ShaoLin() { Name = "少林", Students = new List<Student> { student1,student3, student4 , student5 } };
            WuDang wudang = new WuDang() { Name = "武当", Students = new List<Student> { student5, student6 } };


            context.Set<Chinese>().Add(chinese);
            context.Set<English>().Add(english);
            context.Set<Sport>().Add(sport);

            context.Set<Hand>().Add(hand1);
            context.Set<Hand>().Add(hand2);

            context.Set<Stick>().Add(stick1);
            context.Set<Stick>().Add(stick2);

            context.Set<Sword>().Add(sword1);
            context.Set<Sword>().Add(sword2);

            context.Set<Student>().Add(student1);
            context.Set<Student>().Add(student2);
            context.Set<Student>().Add(student3); 
            context.Set<Student>().Add(student4);
            context.Set<Student>().Add(student5);
            context.Set<Student>().Add(student6);

            context.Set<EMei>().Add(emei);
            context.Set<ShaoLin>().Add(shaolin);
            context.Set<WuDang>().Add(wudang);

            int x= context.SaveChanges();

        }
    }
}
