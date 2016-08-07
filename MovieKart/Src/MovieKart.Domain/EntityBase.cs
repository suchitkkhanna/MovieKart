using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieKart.Domain
{
    public class EntityBase : IEntityBase
    {
        public int ID { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime ValidTo { get; set; }

        public string CreatedBy { get; set; }

        public override bool Equals(object obj)
        {
            var that = (EntityBase)obj;
            if (that == null) return false;

            if (this.ID != that.ID)
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 17;
                hashCode = hashCode * 21 + ID.GetHashCode();
                hashCode = hashCode * 21 + CreatedBy.GetHashCode();
                return hashCode;
            }
        }
    }
}
