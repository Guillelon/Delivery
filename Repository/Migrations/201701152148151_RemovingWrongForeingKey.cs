namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingWrongForeingKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ExtraSaleDetail", "MenuItem_Id", "dbo.MenuItem");
            DropIndex("dbo.ExtraSaleDetail", new[] { "MenuItem_Id" });
            DropColumn("dbo.ExtraSaleDetail", "MenuItem_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ExtraSaleDetail", "MenuItem_Id", c => c.Int());
            CreateIndex("dbo.ExtraSaleDetail", "MenuItem_Id");
            AddForeignKey("dbo.ExtraSaleDetail", "MenuItem_Id", "dbo.MenuItem", "Id");
        }
    }
}
