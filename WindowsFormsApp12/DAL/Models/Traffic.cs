using System;
using WindowsFormsApp12.DAL.Enums;

namespace WindowsFormsApp12.DAL.Models
{
    public class Traffic : BaseEntity
    {
        public DateTime? OrderCreationTime { get; set; } = DateTime.Now;

        public virtual Car Car { get; set; }
        public int? CarId { get; set; }

        public virtual Driver Driver { get; set; }
        public int? DriverId { get; set; }

        public virtual Client Client { get; set; }
        public int? ClientId { get; set; }

        public virtual Dispatcher Dispatcher { get; set; }
        public int? DispatcherId { get; set; }

        public string Note { get; set; }

        public decimal OrederCost { get; set; }

        public OrderType? OrderType { get; set; }
    }
}
