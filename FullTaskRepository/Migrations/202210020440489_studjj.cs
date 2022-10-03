namespace FullTaskRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studjj : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
