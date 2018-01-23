
using System.Threading;

public interface IDatabaseConnection
{
    bool CanCalculate();
}

public class RemoteDatbaseConnection : IDatabaseConnection
{
    public bool CanCalculate()
    {
        Thread.Sleep(5000);
        return true;
    }
}


public class PrimeService
{
    private readonly IDatabaseConnection conn;
    public PrimeService(IDatabaseConnection conn)
    {
        this.conn = conn;        
    }

    public bool IsPrime(int number){
        this.conn.CanCalculate();
        
        if(number == 1 ) return false;
        if(number % 2 == 0 ) return false;
        if(number > 3 && number % 3 == 0 ) return false;
        else return true;
    }
}