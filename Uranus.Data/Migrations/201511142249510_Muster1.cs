namespace Uranus.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Muster1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(maxLength: 100, unicode: false),
                        Contact = c.String(maxLength: 100, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Company", "Address", c => c.String(maxLength: 50, unicode: false));
            AddColumn("dbo.Company", "LinkedInLink", c => c.String(maxLength: 50, unicode: false));
            AddColumn("dbo.Company", "TwitterLink", c => c.String(maxLength: 50, unicode: false));
            AddColumn("dbo.Company", "WebsiteLink", c => c.String(maxLength: 50, unicode: false));
            AddColumn("dbo.Company", "Description", c => c.String(maxLength: 1000));
            AddColumn("dbo.Company", "ImageLogo", c => c.String(maxLength: 50, unicode: false));
            AddColumn("dbo.Company", "ImageSavePath", c => c.String(maxLength: 50, unicode: false));
            AddColumn("dbo.Company", "CopyRight", c => c.String(maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Company", "CopyRight");
            DropColumn("dbo.Company", "ImageSavePath");
            DropColumn("dbo.Company", "ImageLogo");
            DropColumn("dbo.Company", "Description");
            DropColumn("dbo.Company", "WebsiteLink");
            DropColumn("dbo.Company", "TwitterLink");
            DropColumn("dbo.Company", "LinkedInLink");
            DropColumn("dbo.Company", "Address");
            DropTable("dbo.Clients");
        }
    }
}
