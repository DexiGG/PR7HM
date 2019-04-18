namespace PR7HW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExampleMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VisitProperties",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EntryTime = c.DateTime(nullable: false),
                        ExitTime = c.DateTime(nullable: false),
                        Name = c.String(),
                        VisitCause = c.String(),
                        NumberIdentity = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VisitProperties");
        }
    }
}
