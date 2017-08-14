namespace AnswerQuestion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletetypeoftechnologycolumn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QAs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answer = c.String(),
                        Question = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.QAs");
        }
    }
}
