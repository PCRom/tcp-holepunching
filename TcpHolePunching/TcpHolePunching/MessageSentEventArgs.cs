using System.Net;

namespace TcpHolePunching
{
    public class MessageSentEventArgs : EventArgs
    {
        public EndPoint To { get; set; }
        public int Length { get; set; }
    }
}
