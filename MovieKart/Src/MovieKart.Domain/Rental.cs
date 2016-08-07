using System;

namespace MovieKart.Domain
{
    public class Rental : EntityBase
    {
        public int CustomerID { get; set; }

        public int StockID { get; set; }

        public DateTime RentalDate { get; set; }

        public Nullable<DateTime> ReturnedDate { get; set; }

        public string Status { get; set; }

        public virtual Stock Stock { get; set; }
    }
}
