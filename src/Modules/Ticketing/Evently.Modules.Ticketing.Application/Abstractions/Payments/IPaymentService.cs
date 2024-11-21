namespace Evently.Modules.Ticketing.Application.Abstractions.Payments;
public interface IPaymentService
{
    Task<PaymentResponse> ChargeAsync(decimal amount, string currency);

    Task RefundAsync(Guid transactionId, decimal amount);
}

public sealed record PaymentResponse(
    Guid TransactionId, 
    decimal Amount, 
    string Currency);
