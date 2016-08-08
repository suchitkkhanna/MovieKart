using MovieKart.Domain;

namespace MovieKart.Business.Configurations
{
    public class StockConfiguration : EntityBaseConfiguration<Stock>
    {
        public StockConfiguration()
        {
            Property(c => c.MovieID).IsRequired();
            Property(c => c.UniqueKey).IsRequired();
            Property(c => c.IsAvailable).IsRequired();
            HasMany(c => c.Rentals).WithRequired(r => r.Stock).HasForeignKey(r => r.StockID);
        }
    }
}
