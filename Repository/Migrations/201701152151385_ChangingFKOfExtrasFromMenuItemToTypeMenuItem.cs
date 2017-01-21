namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingFKOfExtrasFromMenuItemToTypeMenuItem : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Extra", "MenuItemId", "dbo.MenuItem");
            DropIndex("dbo.Extra", new[] { "MenuItemId" });
            AddColumn("dbo.Extra", "TypeMenuItemId", c => c.Int(nullable: false));
            CreateIndex("dbo.Extra", "TypeMenuItemId");
            AddForeignKey("dbo.Extra", "TypeMenuItemId", "dbo.TypeMenuItem", "Id", cascadeDelete: true);
            DropColumn("dbo.Extra", "MenuItemId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Extra", "MenuItemId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Extra", "TypeMenuItemId", "dbo.TypeMenuItem");
            DropIndex("dbo.Extra", new[] { "TypeMenuItemId" });
            DropColumn("dbo.Extra", "TypeMenuItemId");
            CreateIndex("dbo.Extra", "MenuItemId");
            AddForeignKey("dbo.Extra", "MenuItemId", "dbo.MenuItem", "Id", cascadeDelete: true);
        }
    }
}
