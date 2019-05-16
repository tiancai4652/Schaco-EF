namespace CodeFirst_Sqlite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteView : DbMigration
    {
        public override void Up()
        {
            string script =
       @"
        Drop View If Exists [StudentWeaponView];";
            DBContext.DBContext ctx = new DBContext.DBContext();
            ctx.Database.ExecuteSqlCommand(script);
        }

        public override void Down()
        {
            CreateTable(
                "dbo.StudentWeaponView",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128),
                        StudentName = c.String(maxLength: 2147483647),
                        WeaponID = c.String(maxLength: 2147483647),
                        WeaponName = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
    }
}
