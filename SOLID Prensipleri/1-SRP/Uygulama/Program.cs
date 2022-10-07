

public class Customer
{

}

public class Transaction
{

}

public interface IBankAccount
{
    DateTime getCreationDate();
    double getBalanca();
    double getInterestRate();
    Customer getOwner();
    void Deposit(double amount);
    void WithDraw(double amount);

}

public interface ITransactionService
{
    List<Transaction> getHistory(DateTime from, DateTime to);
}

public interface IPrinter
{
    public void Print();
}

public interface IDao
{
    public void Save();
}

public class BankAccount : IBankAccount, ITransactionService, IPrinter, IDao
{
    public DateTime getCreationDate() { return new DateTime(); }
    public double getBalanca() { return 3.5; }
    public double getInterestRate() { return 2; }
    public Customer getOwner() { return new Customer(); }
    public void Deposit(double amount) { }
    public void WithDraw(double amount) { }

    public List<Transaction> getHistory(DateTime from, DateTime to) { return null; }
    public void Print() { }
    public void Save() { }


}