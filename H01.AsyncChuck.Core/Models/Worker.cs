using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using H01.AsyncChuck.Core.Models;

public class Worker
{
    public async Task DoWork()
    {
        string numbersOutput = await GenerateNumbersAsync();
        Console.WriteLine(numbersOutput);

        var quote = await GetNorrisQuote();
        Console.WriteLine($"Chuck says: {quote.Value}");
    }

    public Task<string> GenerateNumbersAsync()
    {
        return Task.Run(() => GenerateNumbers());
    }

    private string GenerateNumbers()
    {
        return "Numbers generated!";
    }

    public async Task<NorrisQuoteDto> GetNorrisQuote()
    {
        string ApiUrl = "https://api.chucknorris.io/jokes/random";
        var client = new HttpClient();

        var response = await client.GetAsync(ApiUrl);
        var content = await response.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<NorrisQuoteDto>(content);
    }
}
