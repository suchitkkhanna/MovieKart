using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieKart.Domain
{
    public class Genre : EntityBase
    {
        public Genre()
        {
            Movies = new List<Movie>();
        }

        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }

        public override bool Equals(object obj)
        {
            var isEqual = base.Equals(obj);

            var that = (Genre)obj;
            if(that == null) return false;

            return isEqual && string.Equals(that.Name, Name, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetHashCode();
            unchecked
            {
                hashCode = hashCode * 21 + Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
