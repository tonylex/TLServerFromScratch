using System.Net;
using System.Net.Sockets;

namespace TLServerFromScratch;
class Program
{
    static void Main(string[] args)
    {
        TcpListener listner = new TcpListener(IPAddress.Any, 80);
    }
}

