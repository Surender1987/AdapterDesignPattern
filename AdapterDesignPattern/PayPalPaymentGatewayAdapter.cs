namespace AdapterDesignPattern
{
    /// <summary>
    /// Adapter: PayPal gateway adapter, it will convert client interface to PayPal's interface
    /// </summary>
    public class PayPalPaymentGatewayAdapter : IPaymentProcessor
    {
        private readonly PayPalPaymentGateway payPalPaymentGateway;

        /// <summary>
        /// Create instance for <see cref="PayPalPaymentGateway"/>
        /// </summary>
        /// <param name="payPalPaymentGateway"></param>
        public PayPalPaymentGatewayAdapter(PayPalPaymentGateway payPalPaymentGateway)
        {
            this.payPalPaymentGateway = payPalPaymentGateway;
        }

        /// <summary>
        /// Process payments
        /// </summary>
        /// <param name="amnt"></param>
        public void ProcessPayments(double amnt)
        {
            this.payPalPaymentGateway.MakePayment(amnt);
        }
    }
}
