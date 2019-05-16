namespace CodeFirst_Sqlite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddView : DbMigration
    {
        public override void Up()
        {
            string script =
        @"
        CREATE VIEW [StudentWeaponView]
        AS SELECT p.ID AS StudentID, p.Name AS StudentName,u.ID AS WeaponID,u.Name AS WeaponName
        FROM [Students] p
        INNER JOIN [Weapon] u ON u.Id = p.Id";
            DBContext.DBContext ctx = new DBContext.DBContext();
            ctx.Database.ExecuteSqlCommand(script);
        }

        public override void Down()
        {
            DropTable("dbo.StudentWeaponView");
        }
    }
}
