namespace CodeFirst_Sqlite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddChineseExtend1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Chinese", "Extend1", c => c.String(maxLength: 2147483647));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Chinese", "Extend1");
        }
    }
}
