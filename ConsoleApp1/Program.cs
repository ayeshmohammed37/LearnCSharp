namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {

        using (CurrencyService currencyService = new CurrencyService())
        {
            var result = currencyService.GetCurrencies();
            Console.WriteLine(result);
        }
    }
}

public class CurrencyService : IDisposable
{
    private readonly HttpClient httpClient;
    private bool _disposed = false;
    public CurrencyService()
    {
        httpClient = new HttpClient();
    }

    ~CurrencyService()
    {
        Dispose(false);
    }

    public string GetCurrencies()
    {
        string url = "https://coinbase.com/api/v2/currencies";
        var result = httpClient.GetStringAsync(url).Result;

        return result;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
            return;

        if (disposing)
        {
            httpClient.Dispose();
        }

        _disposed = true;
    }
}