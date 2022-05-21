using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SoulMemory.DarkSouls1.Internal;

namespace SoulMemory
{
    public class SoulInjecteeClient
    {
        public SoulInjecteeClient()
        {
            _clientWebSocket = new ClientWebSocket();
            _clientWebSocket.ConnectAsync(new Uri(" ws://localhost:12345"), CancellationToken.None).GetAwaiter().GetResult();
            var bytes = new byte[]{0, 1, 2, 3};
            var segment = new ArraySegment<byte>(bytes);
            SendString("poep!");
        }

        private ClientWebSocket _clientWebSocket;

        private void SendString(string s)
        {
            var segment = new ArraySegment<byte>(Encoding.UTF8.GetBytes(s));
            _clientWebSocket.SendAsync(segment, WebSocketMessageType.Text, true, CancellationToken.None).GetAwaiter().GetResult();
        }
    }
}
