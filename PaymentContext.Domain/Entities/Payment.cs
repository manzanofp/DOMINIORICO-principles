namespace PaymentContext.Domain.Entities
{

    //essa classe é abstrata pq eu não devo instanciar um pagamento direto
    //ele está generico.. por regra ele precisa ser de um dos 3 tipos (BankSlip,CreditCard,Paypal)
    public abstract class Payment
    {
        //esses atributos são genéricos e serão utilizados para todos os tipos de pagamento.
        public string Number { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string Payer { get; set; }
        public string Document { get; set; }
        public string Address {get; set;}  //Endereço de cobrança
    }

    public class BankSlipPayment : Payment
    {
        
    }

    public class CreditCardPayment :  Payment
    {
        
    }

    public class PayPalPayment : Payment
    {

    }
}