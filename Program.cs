using challengeEmprestimo.Entities;

List <Loan> loans = new List<Loan>();

var valueLoanAmount = 1000.0m;
loans.Add(new LoanNubank("João Pedro", valueLoanAmount));
loans.Add(new LoanBradesco("Maria Helena", valueLoanAmount));
loans.Add(new LoanPicPay("Carlos Miguel", valueLoanAmount));
loans.Add(new LoanItau("Ana Beatriz", valueLoanAmount));

foreach(var loan in loans)
{
    loan.CalculateValueInterest();
    loan.GetTotalToPay();
    Console.WriteLine(loan);
}