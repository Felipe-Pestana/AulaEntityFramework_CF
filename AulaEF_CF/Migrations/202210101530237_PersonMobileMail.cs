namespace AulaEF_CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonMobileMail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Mail", c => c.String());
            AddColumn("dbo.People", "Mobile", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Mobile");
            DropColumn("dbo.People", "Mail");
        }
    }
}
