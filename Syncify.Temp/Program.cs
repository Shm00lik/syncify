using System.Net;
using System.Net.NetworkInformation;

var ip = "192.168.1.45";

var ping = new Ping();

var result = await ping.SendPingAsync(IPAddress.Parse(ip));

Console.WriteLine(result.RoundtripTime);