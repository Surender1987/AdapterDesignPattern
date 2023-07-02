namespace AdapterDesignPattern
{
    /// <summary>
    /// Adaptee: Stripe payment gateway which requires interface different from client 
    /// </summary>
    public class StripePaymentGateway
    {
        /// <summary>
        /// Method to make payments
        /// </summary>
        /// <param name="amount"></param>
        public void Change(double amount)
        {
            Console.WriteLine($"Payment of amount {amount} processed successfully by Stripe payment gateway.");
        }
    }
}
