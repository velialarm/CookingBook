namespace CookingService.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<CookingDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CookingDbContext context)
        {
            //TODO must change database colation ???? 
            //ALTER DATABASE [db7220b6c04d624ad6874fa3b200a349d9] COLLATE Cyrillic_General_CI_AS
        }
    }
}
