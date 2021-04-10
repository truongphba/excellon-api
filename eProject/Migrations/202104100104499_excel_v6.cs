namespace eProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class excel_v6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        CompanyName = c.String(),
                        Description = c.String(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Clients", "TaxCode", c => c.String());
            AddColumn("dbo.Clients", "ClientCode", c => c.String());
            AddColumn("dbo.Clients", "Career", c => c.String());
            AddColumn("dbo.Clients", "Email", c => c.String());
            AddColumn("dbo.Clients", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "Description");
            DropColumn("dbo.Clients", "Email");
            DropColumn("dbo.Clients", "Career");
            DropColumn("dbo.Clients", "ClientCode");
            DropColumn("dbo.Clients", "TaxCode");
            DropTable("dbo.Contacts");
        }
    }
}
