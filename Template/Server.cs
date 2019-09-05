using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Template
{
    class Server
    {
        private static Object l = new Object();
        private static TcpListener _server;
        private static Boolean _isRunning;

        public static string posX;
        public static string posY;

        public static void TcpServer(int port)
        {
            _server = new TcpListener(IPAddress.Any, port);
            _server.Start();
            _isRunning = true;
            
            //Starting thread to run LoopClient
            Thread t2 = new Thread(LoopClients);
            t2.Start();
        }

        public static void LoopClients()
        {
            while (_isRunning)
            {
                // wait for client connection
                TcpClient newClient = _server.AcceptTcpClient();

                // client found

                // create a thread to handle communication
                Thread t = new Thread(new ParameterizedThreadStart(HandleClient));
                t.Start(newClient);
            }
        }

        public static void HandleClient(object obj)
        {
            // retrieve client from parameter passed to thread
            TcpClient client = (TcpClient)obj;

            // sets two streams
            StreamWriter sWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);
            StreamReader sReader = new StreamReader(client.GetStream(), Encoding.ASCII);

            // you could use the NetworkStream to read and write, 
            // but there is no forcing flush, even when requested
            bool bClientConnected = true;
            string sData = null;
            Random r = new Random();
            IPEndPoint endPoint = (IPEndPoint)client.Client.RemoteEndPoint;
            IPEndPoint localPoint = (IPEndPoint)client.Client.LocalEndPoint;
            while (bClientConnected)
            {
                // reads from stream
                try
                {
                    //sData = sReader.ReadLine();
                }
                catch (Exception e)
                {
                    Thread.CurrentThread.Abort();
                }

                posX = BlackPixel.cPosX.ToString();
                posY = BlackPixel.cPosY.ToString();

                //Data send to clients
                Thread.Sleep(10);
                lock (l)
                {
                    sWriter.WriteLine(posX);
                    sWriter.Flush();
                    posX = string.Empty;

                    sWriter.WriteLine(posY);
                    sWriter.Flush();
                    posY = string.Empty;
                }
            }
        }
    }
}
