using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieKart.Domain
{
    public interface IEntityBase
    {
        int ID { get; set; }

        DateTime ValidFrom { get; set; }

        DateTime ValidTo { get; set; }

        string CreatedBy { get; set; }

    }
}
