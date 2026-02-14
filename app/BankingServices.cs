namespace ATMApp.Service
{
    public class BankingService
    {
        private double lastAmount = 0;

        public double GetBalance(double balance)
        {
            return balance;
        }

        public void Deposit(ref double balance, double amount)
        {
            balance = balance + amount;
            lastAmount = amount;
        }

        public void Withdraw(ref double balance, double amount, out bool isSuccessful)
        {
            if (amount <= balance)
            {
                balance = balance - amount;
                lastAmount = amount;
                isSuccessful = true;
            }
            else
            {
                isSuccessful = false;
            }
        }

        public double GetLastTransaction()
        {
            return lastAmount;
        }
    }
}
