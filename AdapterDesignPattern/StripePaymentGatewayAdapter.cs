namespace AdapterDesignPattern
{
    /// <summary>
    /// Adapter: adapter for Stripe payment gateway that convert target interface to interface supported by Stripe
    /// </summary>
    public class StripePaymentGatewayAdapter : IPaymentProcessor
    {
        private readonly StripePaymentGateway stripePaymentGateway;

        /// <summary>
        /// Initialize instance for <see cref="StripePaymentGatewayAdapter"/>
        /// </summary>
        /// <param name="stripePaymentGateway"></param>
        public StripePaymentGatewayAdapter(StripePaymentGateway stripePaymentGateway)
        {
            this.stripePaymentGateway = stripePaymentGateway;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amnt"></param>
        public void ProcessPayments(double amnt)
        {
            this.stripePaymentGateway.Change(amnt);
        }
    }
}
