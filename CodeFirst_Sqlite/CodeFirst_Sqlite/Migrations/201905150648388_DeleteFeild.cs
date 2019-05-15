namespace CodeFirst_Sqlite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteFeild : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Chinese", "Extend1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Chinese", "Extend1", c => c.String(maxLength: 2147483647));
        }
    }
}
