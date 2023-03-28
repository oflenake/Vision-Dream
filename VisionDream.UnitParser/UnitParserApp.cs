using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using AwesomeSockets.Sockets;
using FlexibleParser;

namespace VisionDream.UnitParser
{
    class UnitParserApp
    {
        // Server-side code
        // static string ipAddress = "1.2.3.4";
        // static int portNumber = 14804;
        static string ipAddress = "127.0.0.0";
        static int portNumber = 8080;
        static AwesomeSockets.Domain.Sockets.ISocket listenSocket = AweSock.TcpListen(portNumber);
        // static AwesomeSockets.Domain.Sockets.ISocket client = AweSock.TcpAccept(listenSocket);
        // static AwesomeSockets.Domain.Sockets.ISocket MACS_Server = AweSock.TcpAccept(listenSocket);

        // Client-side code
        // static AwesomeSockets.Domain.Sockets.ISocket server = AweSock.TcpConnect(ipAddress, portNumber);
        // static AwesomeSockets.Domain.Sockets.ISocket MACS_Client = AweSock.TcpConnect(ipAddress, portNumber);

        // Once you've connected, you need to construct and populate at least two Buffer objects;
        // One for receiving and one for sending:

        static AwesomeSockets.Buffers.Buffer inBuf = AwesomeSockets.Buffers.Buffer.New();
        static AwesomeSockets.Buffers.Buffer outBuf = AwesomeSockets.Buffers.Buffer.New();

        static void Main(string[] args)
        {
            try
            {
                AwesomeSockets.Domain.Sockets.ISocket MACS_Server = AweSock.TcpAccept(listenSocket);
                AwesomeSockets.Domain.Sockets.ISocket MACS_Client = AweSock.TcpConnect(ipAddress, portNumber);
                Console.WriteLine("listenSocket is: " + listenSocket + Environment.NewLine);
                Console.WriteLine("MACS_Server is: " + MACS_Server + Environment.NewLine);
                Console.WriteLine("MACS_Client is: " + MACS_Client + Environment.NewLine);
                Console.WriteLine("inBuf BEFORE is: " + inBuf + Environment.NewLine);
                Console.ReadLine();

                // Lets send some data to the server! Make a Buffer object and populate it with some data like so:
                AwesomeSockets.Buffers.Buffer.ClearBuffer(outBuf);
                AwesomeSockets.Buffers.Buffer.Add(outBuf, 42);
                AwesomeSockets.Buffers.Buffer.Add(outBuf, "Is the ultimate answer");
                AwesomeSockets.Buffers.Buffer.Add(outBuf, 'N');
                AwesomeSockets.Buffers.Buffer.FinalizeBuffer(outBuf);
                Console.WriteLine("outBuf AFTER is: " + outBuf + Environment.NewLine);

                // Now lets send it to the server!
                int bytesSent = AweSock.SendMessage(MACS_Client, outBuf);
                Console.WriteLine("bytesSent is: " + bytesSent + Environment.NewLine);

                // And receive any inbound messages as well. Received data will be stored in inBuf. 
                Tuple<int, EndPoint> received = AweSock.ReceiveMessage(MACS_Server, inBuf);
                Console.WriteLine("inBuf is: " + inBuf + Environment.NewLine);
                Console.WriteLine("received is: " + received + Environment.NewLine);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
