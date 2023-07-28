namespace Logger
{
    internal class PaymentManager
    {
        private readonly ILogger _logger;
        public PaymentManager(ILogger logger)
        {
            _logger = logger;
        }

        public void ProcessPayment(double amount, string creditCardNumber)
        {
            if (creditCardNumber != null && creditCardNumber.Length == 16)
            {
                _logger.LogInformation($"Processing payment of {amount} on this card: {creditCardNumber}");
                return;
            }
            _logger.LogError($"Error when processing payment of {amount} on this card: {creditCardNumber}");
        }

        public void RefundPayment(double amount, string transactionId)
        {
            if (transactionId != null)
            {
                _logger.LogInformation($"Refund of {amount} with transaction id: {transactionId}");
                return;
            }
            _logger.LogError($"Error when refunding payment of {amount} with transaction id: {transactionId}");
        }

        public void ProcessRefund(double amount, string transactionId)
        {
            if (transactionId != "")
            {
                _logger.LogInformation($"Processing refund of {amount} with transaction id: {transactionId}");
                return;
            }
            _logger.LogError($"Error when processing payment refund of {amount} with transaction id: {transactionId}");
        }
    }
}