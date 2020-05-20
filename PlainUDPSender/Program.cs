using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace PlainUDPSender
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World press enter to start prepare sending environment!");
            Console.ReadLine();
            Random rvalue = new Random();
            Measurement.Measurement measure;

            UdpClient udpSender = new UdpClient(0);
            udpSender.EnableBroadcast = true;
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, 11111);

            Console.WriteLine("ready to start press enter again");
            Console.ReadLine();
            string dateToday = DateTime.Now.Date.ToString();

            while (true)
            {
                measure = new Measurement.Measurement(10, 15, 20);

                byte[] sendBytes = Encoding.ASCII.GetBytes(measure.ToString());

                try
                {
                    Console.WriteLine("sending :" + measure.ToString());
                    udpSender.Send(sendBytes, sendBytes.Length, endPoint);
                    Thread.Sleep(3000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

        }
    }
}
