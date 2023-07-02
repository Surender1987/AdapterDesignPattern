# Adapter design pattern 
Adapter design pattern is a structural design pattern which enables two objects with incompatible interfaces works together. It converts interface of one object to another objects interface. The main components for adapter design patterns are
1. **Target** It defines the interface that client expect to interact
2. **Adapter** Adapter is a class that convert interface client expecting to be interact to interface adaptee need to work
3. **Adaptee** Adaptee is the legacy class which has interface that incompatible with client's interface

This design pattern helps when we have legacy application or code from other teams that we can not modify.

## Implementation of adapter design pattern 
Suppose we are working in an e-commerce plateform and we need to process payements using multiple payment gateways like PayPal and Stripe. Each payment gateway has its own interface, to provide a unified interface we can use adapter design pattern
1. Target - there is common interface IPaymentProcessor
```
namespace AdapterDesignPattern
{
    /// <summary>
    /// Target : target component defines unified interface for client.
    /// </summary>
    public interface IPaymentProcessor
    {
        void ProcessPayments(double amnt);
    }
}
```
2. Adapter - Classes that change one interface to another, here we have PayPalPaymentGatewayAdapter & StripePaymentGatewayAdapter which converts IProcessPayment interface to gateways interfaces
PayPalPaymentGatewayAdapter.cs
```
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
```

StripePaymentGatewayAdapter.cs
```
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
```
3.  Adaptee - legacy or third party code that is not easy to change and available with incompatible interfaces
PayPalPaymentGateway.cs
```
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
```

StripePaymentGateway.cs
```
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
```
