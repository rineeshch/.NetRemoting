using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using SharedLibrary1;

namespace RemotingClient1
{
    class Client
    {
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);

            Calculator calculator = (Calculator)Activator.GetObject(
                typeof(Calculator),
                "tcp://localhost:8080/CalculatorService"
            );

            int result = calculator.Add(100, 20);
            Console.WriteLine("Result from server: " + result);

        }
    }
}
