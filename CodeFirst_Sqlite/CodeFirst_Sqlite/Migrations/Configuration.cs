namespace CodeFirst_Sqlite.Migrations
{
    using CodeFirst_Sqlite.Model;
    using CodeFirst_Sqlite.Model.Course;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.SQLite.EF6.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst_Sqlite.DBContext.DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(CodeFirst_Sqlite.DBContext.DBContext context)
        {
            Chinese chinese = new Chinese() { Name = "����" };
            English english = new English() { Name = "Ӣ��" };
            Sport sport = new Sport() { Name = "����" };

            Hand hand1 = new Hand() { Name = "������" };
            Hand hand2 = new Hand() { Name = "�ķ���" };

            Stick stick1 = new Stick() { Name = "Τ�ӹ���" };
            Stick stick2 = new Stick() { Name = "��ħ����" };

            Sword sword1 = new Sword() { Name = "̫������" };
            Sword sword2 = new Sword() { Name = "���ǽ���" };

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

            int x = context.SaveChanges();
        }
    }
}
