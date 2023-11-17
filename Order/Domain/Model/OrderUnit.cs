
namespace Domain.Model
{
    public class OrderUnit : EntityBase
    {
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public virtual Provider Provider { get; set; }
        public int ProviderId { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }
    }
}