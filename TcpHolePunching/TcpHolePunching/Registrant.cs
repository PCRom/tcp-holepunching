using System.Net;

namespace TcpHolePunching
{
    public class Registrant
    {
        public IPEndPoint InternalEndPoint { get; set; }
        public IPEndPoint ExternalEndPoint { get; set; }
    }
}
