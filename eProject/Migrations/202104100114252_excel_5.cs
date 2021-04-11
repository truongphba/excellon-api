namespace eProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class excel_5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PaymentDetails", "PaymentId", "dbo.Payments");
            AddForeignKey("dbo.PaymentDetails", "PaymentId", "dbo.Payments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PaymentDetails", "PaymentId", "dbo.Payments");
            AddForeignKey("dbo.PaymentDetails", "PaymentId", "dbo.Payments", "Id");
        }
    }
}
