﻿using System;
using System.Net.Sockets;

namespace Cookie.Extensions
{
    public static class SocketExtensions
    {
        public static bool IsConnected(this Socket socket)
        {
            try
            {
                if (socket.Connected)
                    return !(socket.Poll(1, SelectMode.SelectRead) && socket.Available == 0);
                else
                    return false;
            }
            catch (Exception)
            { return false; }
        }
    }
}
