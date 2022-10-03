namespace FullTaskRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tests", "Names", c => c.String());
            DropColumn("dbo.Tests", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tests", "Name", c => c.String());
            DropColumn("dbo.Tests", "Names");
        }
    }
}
