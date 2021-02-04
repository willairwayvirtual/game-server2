using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace game_server2
{
    class server
    {

        public static int maxplayers { get; private set }
        public static int por{ get; private set }
        public static TcpListener tcpListener;
        public static void Start(int _maxPlayers, int _port)
        {
          maxplayers,= _maxPlayers;
            _port = _port;

            Console.WriteLine("Starting server...");

             tcpListener = new TcpListener(IPAddress.Any, port);
            Console.WriteLine($"Server started on port {Port}.);

            private  static void TCPConnectCallback(IAsyncResult _result)
            {
                TcpClient _client = tcpListener.EndAcceptTcpClient(_result);
                tcpListener.BeginAcceptTcpClient(TCPConnectCallback, null);
                Console.WriteLine($"Incoming connection from {_client.Client.RemoteEndPoint}...");

            }
        }
