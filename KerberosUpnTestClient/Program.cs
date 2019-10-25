using System;
using System.ServiceModel;
using ServiceReference1;

namespace KerberosUpnTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ServiceReference1.Service1Client(
                Service1Client.EndpointConfiguration.NetTcpEndpoint,
                new EndpointAddress(new Uri("net.tcp://tpainvwaxpxy02.corp.temp.lcl/Service1.svc/netTcpTest"),
                    new UpnEndpointIdentity("svcAXBCPIN@corp.temp.lcl")));
            var result = client.GetDataAsync(1).Result;
            Console.WriteLine(result);
        }
    }
}
