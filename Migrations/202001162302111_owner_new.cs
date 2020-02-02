namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class owner_new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        ownerID = c.Int(nullable: false, identity: true),
                        ownerFname = c.String(),
                        ownerLname = c.String(),
                        ownerPhone = c.Int(nullable: false),
                        ownerAddress = c.String(),
                        ownerEmail = c.String(),
                    })
                .PrimaryKey(t => t.ownerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Owners");
        }
    }
}
