// See https://aka.ms/new-console-template for more information

using localisation;
using System.Net.Http;
using System.Net.Http.Json;

while (true) {
    HttpClient httpClient = new();
    Console.Write("Enter an IP address: ");
    var ip = Console.ReadLine();
    if (String.IsNullOrWhiteSpace(ip))
    {
        break;
    }
var uri = $"http://ip-api.com/json/{ip}";
var info = httpClient.GetFromJsonAsync<GeoInfo>(uri).Result;
    Console.WriteLine($" Status: {info.Status}\r\n Country: {info.Country}\r\n City: {info.City}\r\n ZIP: {info.ZIP}\r\n Query: {info.Query} \r\n");
}    