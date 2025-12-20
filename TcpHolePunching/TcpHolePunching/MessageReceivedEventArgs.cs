using System.Net;
using TcpHolePunching.Messages;

namespace TcpHolePunching
{
    public class MessageReceivedEventArgs : EventArgs
    {
        public IPEndPoint From { get; set; }
        public MessageType MessageType { get; set; }
        public IValueReader MessageReader { get; set; }
    }
}
