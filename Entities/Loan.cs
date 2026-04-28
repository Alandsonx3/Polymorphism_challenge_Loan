
namespace challengeEmprestimo.Entities
{
    public class Loan
    {
        public string? ClientName {get; set;}
        public decimal LoanAmount;
        public decimal InterestValue;

        public Loan(string clientName, decimal loanAmount)
        {
            ClientName = clientName;
            LoanAmount = loanAmount;
        }

        public virtual void CalculateValueInterest ()
        {            
            decimal InterestRate = 0.20m; // Standard interest rate 20%
            InterestValue = LoanAmount * InterestRate;
        }

        public decimal GetTotalToPay ()
        {
            return LoanAmount + InterestValue;
        }

        public override string ToString()
        {
            return $"Total a Pagar = {GetTotalToPay():c2} ({InterestValue:c2})";
        }
    }
}