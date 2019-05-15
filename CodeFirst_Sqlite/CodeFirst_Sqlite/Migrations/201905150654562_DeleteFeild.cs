namespace CodeFirst_Sqlite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteFeild : DbMigration
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
            
            DropColumn("dbo.Chinese", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Chinese", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.Paint", "ID", "dbo.CourseBases");
            DropIndex("dbo.Paint", new[] { "ID" });
            DropTable("dbo.Paint");
        }
    }
}
