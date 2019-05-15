namespace CodeFirst_Sqlite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablePaint : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Chinese", "Discriminator", c => c.String(nullable: true, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Chinese", "Discriminator");
        }
    }
}
