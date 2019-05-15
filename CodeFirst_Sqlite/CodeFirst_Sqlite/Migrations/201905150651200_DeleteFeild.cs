namespace CodeFirst_Sqlite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteFeild : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Chinese", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Chinese", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
    }
}
