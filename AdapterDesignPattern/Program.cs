// Client code with uniform interface
using AdapterDesignPattern;

var payPalPaymentGateway = new PayPalPaymentGateway();
IPaymentProcessor paymentProcessor = new PayPalPaymentGatewayAdapter(payPalPaymentGateway);
paymentProcessor.ProcessPayments(34.56);

var stripePaymentGateway = new StripePaymentGateway();
IPaymentProcessor paymentPro = new StripePaymentGatewayAdapter(stripePaymentGateway);
paymentPro.ProcessPayments(65.23);

Console.ReadLine();