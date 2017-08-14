using System.Data.Entity.Migrations;
using AnswerQuestion.DAL;

namespace AnswerQuestion.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AnsweQuestionContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }
    }
}