// See https://aka.ms/new-console-template for more information
using System.Text.Json;


Console.WriteLine("Hello, World!");
var httpClient = new HttpClient();
async Task<string> GetCountry(string name)
{
 var response = await httpClient.GetAsync($"https://restcountries.com/v3.1/name/{name}");
 var body = await response.Content.ReadAsStringAsync();
 return body;
}

async Task<Country[]> GetCountryObject(string name)
{
 var response = await httpClient.GetAsync($"https://restcountries.com/v3.1/name/{name}");
 var body = await response.Content.ReadAsStringAsync();
 var result = JsonSerializer.Deserialize<Country[]>(body, new JsonSerializerOptions(JsonSerializerDefaults.Web));
 if (result == null)
 {
  throw new Exception("Failed to deserialize country data.");
 }
 return result;
}


//var json = await GetCountry("Finland");
var countries = await GetCountryObject("finland");
Console.WriteLine(countries[0].Population);
try
{
 using (var stream = new StreamReader(@"C:\Users\fakir\OneDrive\Desktop\Document\emp\\json.txt"))
 {
  var body = await stream.ReadToEndAsync();
  Console.WriteLine(body);
 }
}
catch (IOException ex)
{
 Console.WriteLine(ex.Message);


}
