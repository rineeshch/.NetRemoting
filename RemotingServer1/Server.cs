using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using SharedLibrary1;

namespace RemotingServer
{
    class Server
    {
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(8080);
            ChannelServices.RegisterChannel(channel, false);

            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(Calculator),
                "CalculatorService",
                WellKnownObjectMode.Singleton
            );

            Console.WriteLine("Remoting Server started...");
            Console.WriteLine("Listening on tcp://localhost:8080/CalculatorService");
            Console.ReadLine(); // keep server alive
        }
    }
}
