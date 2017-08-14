namespace AnswerQuestion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTechnologyName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.QAs", "TechnologyType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.QAs", "TechnologyType");
        }
    }
}
