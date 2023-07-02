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
