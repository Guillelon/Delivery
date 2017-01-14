namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Extra",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MenuItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MenuItem", t => t.MenuItemId, cascadeDelete: true)
                .Index(t => t.MenuItemId);
            
            CreateTable(
                "dbo.ExtraSaleDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        SaleDetailId = c.Int(nullable: false),
                        ExtraId = c.Int(nullable: false),
                        MenuItem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Extra", t => t.ExtraId, cascadeDelete: true)
                .ForeignKey("dbo.SaleDetail", t => t.SaleDetailId, cascadeDelete: true)
                .ForeignKey("dbo.MenuItem", t => t.MenuItem_Id)
                .Index(t => t.SaleDetailId)
                .Index(t => t.ExtraId)
                .Index(t => t.MenuItem_Id);
            
            CreateTable(
                "dbo.SaleDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        SaleId = c.Int(nullable: false),
                        MenuItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MenuItem", t => t.MenuItemId, cascadeDelete: true)
                .ForeignKey("dbo.Sale", t => t.SaleId, cascadeDelete: true)
                .Index(t => t.SaleId)
                .Index(t => t.MenuItemId);
            
            CreateTable(
                "dbo.MenuItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TypeMenuItemId = c.Int(nullable: false),
                        MenuId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menu", t => t.MenuId, cascadeDelete: true)
                .ForeignKey("dbo.TypeMenuItem", t => t.TypeMenuItemId, cascadeDelete: true)
                .Index(t => t.TypeMenuItemId)
                .Index(t => t.MenuId);
            
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeMenuItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sale",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleDetail", "SaleId", "dbo.Sale");
            DropForeignKey("dbo.SaleDetail", "MenuItemId", "dbo.MenuItem");
            DropForeignKey("dbo.MenuItem", "TypeMenuItemId", "dbo.TypeMenuItem");
            DropForeignKey("dbo.MenuItem", "MenuId", "dbo.Menu");
            DropForeignKey("dbo.ExtraSaleDetail", "MenuItem_Id", "dbo.MenuItem");
            DropForeignKey("dbo.Extra", "MenuItemId", "dbo.MenuItem");
            DropForeignKey("dbo.ExtraSaleDetail", "SaleDetailId", "dbo.SaleDetail");
            DropForeignKey("dbo.ExtraSaleDetail", "ExtraId", "dbo.Extra");
            DropIndex("dbo.MenuItem", new[] { "MenuId" });
            DropIndex("dbo.MenuItem", new[] { "TypeMenuItemId" });
            DropIndex("dbo.SaleDetail", new[] { "MenuItemId" });
            DropIndex("dbo.SaleDetail", new[] { "SaleId" });
            DropIndex("dbo.ExtraSaleDetail", new[] { "MenuItem_Id" });
            DropIndex("dbo.ExtraSaleDetail", new[] { "ExtraId" });
            DropIndex("dbo.ExtraSaleDetail", new[] { "SaleDetailId" });
            DropIndex("dbo.Extra", new[] { "MenuItemId" });
            DropTable("dbo.Sale");
            DropTable("dbo.TypeMenuItem");
            DropTable("dbo.Menu");
            DropTable("dbo.MenuItem");
            DropTable("dbo.SaleDetail");
            DropTable("dbo.ExtraSaleDetail");
            DropTable("dbo.Extra");
        }
    }
}
