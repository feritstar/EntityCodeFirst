namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameCustomerSurNameToCustomerTitleInCustomerTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerTitle", c => c.String());
            DropColumn("dbo.Customers", "CustomerSurName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CustomerSurName", c => c.String());
            DropColumn("dbo.Customers", "CustomerTitle");
        }
    }
}
