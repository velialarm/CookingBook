namespace CookingService.Data
{
    using System.Data.Entity;
    using Model;
    public interface ICookingDbContext
    {
        IDbSet<Receipt> Receipts { get; set; }

        IDbSet<Nationality> Nationalities { get; set; }

        IDbSet<Product> Products { get; set; }

        IDbSet<Category> Categories { get; set; }

        IDbSet<Measure> Measures { get; set; }

        IDbSet<Schedule> Schedules { get; set; }

        IDbSet<SourceReceipt> SourceReceipts { get; set; }

        IDbSet<Holiday> Holidays { get; set; }

        IDbSet<ProductType> ProductTypes { get; set; }
    }
}
