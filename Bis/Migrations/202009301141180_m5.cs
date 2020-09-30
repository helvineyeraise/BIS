namespace Bis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "companyId", c => c.Int());
            CreateIndex("dbo.Employee", "companyId");
            AddForeignKey("dbo.Employee", "companyId", "dbo.Company", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "companyId", "dbo.Company");
            DropIndex("dbo.Employee", new[] { "companyId" });
            DropColumn("dbo.Employee", "companyId");
        }
    }
}
