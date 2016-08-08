using MovieKart.Domain;

namespace MovieKart.Business.Configurations
{
    public class MovieConfiguration : EntityBaseConfiguration<Movie>
    {
        public MovieConfiguration()
        {
            Property(c => c.Title).IsRequired().HasMaxLength(100);
            Property(c => c.GenreID).IsRequired();
            Property(c => c.Director).IsRequired().HasMaxLength(100);
            Property(c => c.Writer).IsRequired().HasMaxLength(50);
            Property(c => c.Producer).IsRequired().HasMaxLength(50);
            Property(c => c.Rating).IsRequired();
            Property(c => c.Description).IsRequired().HasMaxLength(2000);
            Property(c => c.TrailerURI).HasMaxLength(200);
            HasMany(c => c.Stocks).WithRequired().HasForeignKey(c => c.MovieID);
        }
    }
}
