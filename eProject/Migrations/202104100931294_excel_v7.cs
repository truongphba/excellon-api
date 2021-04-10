namespace eProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class excel_v7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "ClientSource", c => c.String());
            AddColumn("dbo.Clients", "PointOfContact", c => c.String());
            AddColumn("dbo.Clients", "position", c => c.String());
            AddColumn("dbo.Contacts", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Contacts", "UpdatedAt", c => c.DateTime());
            AlterColumn("dbo.Clients", "CreatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "CreatedAt", c => c.DateTime());
            DropColumn("dbo.Contacts", "UpdatedAt");
            DropColumn("dbo.Contacts", "CreatedAt");
            DropColumn("dbo.Clients", "position");
            DropColumn("dbo.Clients", "PointOfContact");
            DropColumn("dbo.Clients", "ClientSource");
        }
    }
}
