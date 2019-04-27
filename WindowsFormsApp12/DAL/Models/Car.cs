namespace WindowsFormsApp12.DAL.Models
{
    public class Car : BaseEntity
    {
        public virtual Mark Mark { get; set; }
        public int? MarkId { get; set; }

        public virtual CarColor CarColor { get; set; }
        public int? CarColorId { get; set; }
    }
}
