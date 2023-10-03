namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Document { get; set; }
        public List<Subscription> Subscriptions { get; set; }
        public string Address {get; set;} //Endereço de entrega do "Produto"
    }
}