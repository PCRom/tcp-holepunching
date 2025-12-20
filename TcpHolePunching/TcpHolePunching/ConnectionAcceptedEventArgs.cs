using System.Net.Sockets;

namespace TcpHolePunching
{
    public class ConnectionAcceptedEventArgs : EventArgs
    {
        public Socket Socket { get; set; }
    }
}
