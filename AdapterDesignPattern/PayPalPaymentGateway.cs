namespace AdapterDesignPattern
{
    /// <summary>
    /// Adaptee: PayPal payment gateway which requires interface different from client 
    /// </summary>
    public class PayPalPaymentGateway
    {
        /// <summary>
        /// Method to make payments
        /// </summary>
        /// <param name="amount"></param>
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Payment of amount {amount} processed successfully.");
        }
    }
}
