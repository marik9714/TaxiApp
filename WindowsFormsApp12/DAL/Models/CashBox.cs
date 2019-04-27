namespace WindowsFormsApp12.DAL.Models
{
    public class Cashbox : BaseEntity
    {
        public virtual Driver Driver { get; set; }
        public int? DriverId { get; set; }

        public virtual Dispatcher Dispatcher { get; set; }
        public int? DispatcherId { get; set; }

        public decimal? Profit { get; set; }
    }
}
