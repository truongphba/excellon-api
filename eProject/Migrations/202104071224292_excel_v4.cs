namespace eProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class excel_v4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PaymentDetails", "CreatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PaymentDetails", "CreatedAt", c => c.DateTime());
        }
    }
}
