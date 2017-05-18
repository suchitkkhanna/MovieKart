using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MovieKart.Business.Configurations;
using MovieKart.Domain;

namespace MovieKart.Business
{
    public class HomeCinemaContext : DbContext
    {
        public HomeCinemaContext()
            : base("HomeCinema")
        {
            Database.SetInitializer<HomeCinemaContext>(null);
        }

        public IDbSet<Customer> CustomerSet { get; set; }
        public IDbSet<Movie> MovieSet { get; set; }
        public IDbSet<Genre> GenreSet { get; set; }
        public IDbSet<Stock> StockSet { get; set; }
        public IDbSet<Rental> RentalSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new MovieConfiguration());
            modelBuilder.Configurations.Add(new MovieConfiguration());
            modelBuilder.Configurations.Add(new GenreConfiguration());
            modelBuilder.Configurations.Add(new StockConfiguration());
            modelBuilder.Configurations.Add(new RentalConfiguration());
        }
    }
}