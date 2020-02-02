namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class groomer_new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groomers",
                c => new
                    {
                        groomerID = c.Int(nullable: false, identity: true),
                        groomerFname = c.String(),
                        groomerLname = c.String(),
                        groomerEmpno = c.Int(nullable: false),
                        groomerPhone = c.Int(nullable: false),
                        groomerDOB = c.DateTime(nullable: false),
                        groomerExp = c.Int(nullable: false),
                        groomerRate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.groomerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Groomers");
        }
    }
}
