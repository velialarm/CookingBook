namespace CookingService.Data
{
    using System.Data.Entity;
    using Migrations;
    using Model;

    public class CookingDbContext : DbContext, ICookingDbContext
    {
        public CookingDbContext()
            : base("CookingConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CookingDbContext, Configuration>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<CookingDbContext>());
        }

        public IDbSet<Receipt> Receipts { get; set; }

        public IDbSet<Nationality> Nationalities { get; set; }

        public IDbSet<Product> Products { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Measure> Measures { get; set; }

        public IDbSet<Schedule> Schedules { get; set; }

        public IDbSet<SourceReceipt> SourceReceipts { get; set; }

        public IDbSet<Holiday> Holidays { get; set; }

        public IDbSet<ProductType> ProductTypes { get; set; }

        public IDbSet<Media> Medies { get; set; }
    }
}
