using System.Net;
using System.Net.NetworkInformation;

var ip = "192.168.1.113";

var ping = new Ping();

var roundTrips = new List<long>();

while (true)
{
    var result = await ping.SendPingAsync(IPAddress.Parse(ip));
    if (result.Status == IPStatus.Success)
    {
        roundTrips.Add(result.RoundtripTime);
    }

    Console.WriteLine($"Current roundtrip time: {result.RoundtripTime:000}, Average: {roundTrips.Average():0.00}");
    
    await Task.Delay(1);
}
