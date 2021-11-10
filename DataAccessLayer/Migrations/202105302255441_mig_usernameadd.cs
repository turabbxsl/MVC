namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_usernameadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "UserMail", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "UserMail");
        }
    }
}
