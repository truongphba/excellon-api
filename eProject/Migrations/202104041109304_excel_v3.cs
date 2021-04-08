namespace eProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class excel_v3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Payments", "CreatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Payments", "CreatedAt", c => c.DateTime());
        }
    }
}
