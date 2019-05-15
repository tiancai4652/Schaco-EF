namespace CodeFirst_Sqlite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteTablePaint : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Paint", "ID", "dbo.CourseBases");
            DropIndex("dbo.Paint", new[] { "ID" });
            DropTable("dbo.Paint");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Paint",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.Paint", "ID");
            AddForeignKey("dbo.Paint", "ID", "dbo.CourseBases", "ID");
        }
    }
}
