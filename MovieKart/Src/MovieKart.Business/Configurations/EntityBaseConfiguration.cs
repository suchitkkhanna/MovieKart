using MovieKart.Domain;
using System.Data.Entity.ModelConfiguration;

namespace MovieKart.Business.Configurations
{
    public class EntityBaseConfiguration<T> : EntityTypeConfiguration<T> where T : class, IEntityBase
    {
        public EntityBaseConfiguration()
        {
            HasKey(c => c.ID);
            Property(c => c.ValidFrom).IsRequired();
            Property(c => c.ValidTo).IsRequired();
            Property(c => c.CreatedBy).IsRequired().HasMaxLength(100);
        }
    }
}
