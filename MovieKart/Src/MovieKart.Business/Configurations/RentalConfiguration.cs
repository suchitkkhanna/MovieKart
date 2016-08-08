using MovieKart.Domain;

namespace MovieKart.Business.Configurations
{
    public class RentalConfiguration : EntityBaseConfiguration<Rental>
    {
        public RentalConfiguration()
        {
            Property(c => c.CustomerID).IsRequired();
            Property(c => c.StockID).IsRequired();
            Property(c => c.Status).IsRequired().HasMaxLength(10);
            Property(c => c.ReturnedDate).IsOptional();
        }
    }
}
