namespace CodeFirst_Sqlite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteFeild : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Chinese", "Extend1", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Chinese", "Extend1", c => c.String(maxLength: 2147483647));
        }
    }
}
