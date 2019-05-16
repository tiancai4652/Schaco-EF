namespace CodeFirst_Sqlite.Migrations
{
    using CodeFirst_Sqlite.Model;
    using CodeFirst_Sqlite.Model.Course;
    using CodeFirst_Sqlite.Model.Weapon;
    using SQLite.CodeFirst;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst_Sqlite.DBContext.DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //AutomaticMigrationDataLossAllowed = false;
            SetSqlGenerator("System.Data.SQLite", new SqliteMigrationSqlGenerator());
        }

        protected override void Seed(CodeFirst_Sqlite.DBContext.DBContext context)
        {
            Chinese chinese = new Chinese() { Name = "����" };
            English english = new English() { Name = "Ӣ��" };
            Sport sport = new Sport() { Name = "����" };

            Weapon hand1 = new Weapon() { Name = "������", Type = 0 };
            Weapon hand2 = new Weapon() { Name = "�ķ���", Type = 0 };

            Weapon stick1 = new Weapon() { Name = "Τ�ӹ���", Type = 1 };
            Weapon stick2 = new Weapon() { Name = "��ħ����", Type = 1 };

            Weapon sword1 = new Weapon() { Name = "̫������", Type = 2 };
            Weapon sword2 = new Weapon() { Name = "���ǽ���", Type = 2 };

            List<CourseBase> coursesList1 = new List<CourseBase>() { chinese, english };
            List<CourseBase> coursesList2 = new List<CourseBase>() { chinese, sport };
            List<CourseBase> coursesList3 = new List<CourseBase>() { chinese, english, sport };

            Student student1 = new Student() { Name = "������", Weapon = sword1, Courses = coursesList1 };
            Student student2 = new Student() { Name = "�Ŵ�ɽ", Weapon = sword2, Courses = coursesList2 };

            Student student3 = new Student() { Name = "������", Weapon = hand1, Courses = coursesList3 };
            Student student4 = new Student() { Name = "������", Weapon = hand2, Courses = coursesList1 };

            Student student5 = new Student() { Name = "һ�ƴ�ʦ", Weapon = stick1, Courses = coursesList3 };
            Student student6 = new Student() { Name = "����", Weapon = stick2, Courses = coursesList2 };

            chinese.Students = new List<Student>() { student1, student4 };
            english.Students = new List<Student>() { student1, student3, student4 };
            sport.Students = new List<Student>() { student2, student4, student5, student6 };

            EMei emei = new EMei() { Name = "��ü", Students = new List<Student> { student1, student2, student3, student4, student5, student6 } };
            ShaoLin shaolin = new ShaoLin() { Name = "����", Students = new List<Student> { student1, student3, student4, student5 } };
            WuDang wudang = new WuDang() { Name = "�䵱", Students = new List<Student> { student5, student6 } };


            context.Set<Chinese>().AddOrUpdate(chinese);
            context.Set<English>().AddOrUpdate(english);
            context.Set<Sport>().AddOrUpdate(sport);

            context.Set<Weapon>().AddOrUpdate(hand1);
            context.Set<Weapon>().AddOrUpdate(hand2);

            context.Set<Weapon>().AddOrUpdate(stick1);
            context.Set<Weapon>().AddOrUpdate(stick2);

            context.Set<Weapon>().AddOrUpdate(sword1);
            context.Set<Weapon>().AddOrUpdate(sword2);

            context.Set<Student>().AddOrUpdate(student1);
            context.Set<Student>().AddOrUpdate(student2);
            context.Set<Student>().AddOrUpdate(student3);
            context.Set<Student>().AddOrUpdate(student4);
            context.Set<Student>().AddOrUpdate(student5);
            context.Set<Student>().AddOrUpdate(student6);

            context.Set<EMei>().AddOrUpdate(emei);
            context.Set<ShaoLin>().AddOrUpdate(shaolin);
            context.Set<WuDang>().AddOrUpdate(wudang);

            int x = context.SaveChanges();

        }
    }


    /// <summary>
    /// https://stackoverflow.com/questions/10822618/confusion-over-ef-auto-migrations-and-seeding-seeding-every-program-start
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    /// <typeparam name="TMigrationsConfiguration"></typeparam>
    public class CheckAndMigrateDatabaseToLatestVersion<TContext, TMigrationsConfiguration>
    : SqliteMigrateDatabaseToLatestVersion<TContext, TMigrationsConfiguration>
    where TContext : DbContext
    where TMigrationsConfiguration : DbMigrationsConfiguration<TContext>, new()
    {
        public CheckAndMigrateDatabaseToLatestVersion(DbModelBuilder modelBuilder,bool useSuppliedContext) : base(modelBuilder,useSuppliedContext)
        {

        }
        public override void InitializeDatabase(TContext context)
        {
            var migratorBase = ((MigratorBase)new DbMigrator(Activator.CreateInstance<TMigrationsConfiguration>()));
            if (migratorBase.GetPendingMigrations().Any())
                migratorBase.Update();
        }
    }
}
