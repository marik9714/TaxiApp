namespace WindowsFormsApp12.DAL.Models
{
    public class Client : BaseEntity
    {
        public string ClientName { get; set; }

        public virtual Street Street { get; set; }
        public int? StreetId { get; set; }

        public int? HomeNumber { get; set; }
        public int? FlatNumber { get; set; }
        public string PhoneNumber { get; set; }
    }
}
