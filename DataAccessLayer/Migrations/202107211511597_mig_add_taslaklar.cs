namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_taslaklar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Taslaklars",
                c => new
                    {
                        TaslakID = c.Int(nullable: false, identity: true),
                        Kime = c.String(maxLength: 50),
                        Konu = c.String(maxLength: 100),
                        Icerik = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.TaslakID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Taslaklars");
        }
    }
}
