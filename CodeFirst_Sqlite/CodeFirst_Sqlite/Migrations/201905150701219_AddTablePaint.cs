namespace CodeFirst_Sqlite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablePaint : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Paint",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CourseBases", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Paint", "ID", "dbo.CourseBases");
            DropIndex("dbo.Paint", new[] { "ID" });
            DropTable("dbo.Paint");
        }
    }
}
