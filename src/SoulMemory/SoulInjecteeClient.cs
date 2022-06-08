using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SoulMemory.DarkSouls1.Internal;

namespace SoulMemory
{
    public class SoulInjecteeClient : IDisposable
    {
        public SoulInjecteeClient()
        {
            _clientWebSocket = new ClientWebSocket();
            _clientWebSocket.ConnectAsync(new Uri("ws://localhost:12345"), CancellationToken.None).GetAwaiter().GetResult();
        }

        private ClientWebSocket _clientWebSocket;

        //private void SendString(string s)
        //{
        //    var segment = new ArraySegment<byte>(Encoding.UTF8.GetBytes(s));
        //    _clientWebSocket.SendAsync(segment, WebSocketMessageType.Text, true, CancellationToken.None).GetAwaiter().GetResult();
        //}

        public void Send(Message message)
        {
            var json = JsonConvert.SerializeObject(message);
            var segment = new ArraySegment<byte>(Encoding.UTF8.GetBytes(json));
            _clientWebSocket.SendAsync(segment, WebSocketMessageType.Text, true, CancellationToken.None).GetAwaiter().GetResult();
        }

        public void Dispose()
        {
            if (_clientWebSocket != null && _clientWebSocket.State != WebSocketState.Closed)
            {
                _clientWebSocket.CloseAsync(WebSocketCloseStatus.Empty, null, CancellationToken.None).GetAwaiter().GetResult();
            }
        }
    }


    public class Message
    {
        public string MessageType;

        public DarkSouls3ReadEventFlagMessage DarkSouls3ReadEventFlagMessage = null;
    }

    public class DarkSouls3ReadEventFlagMessage
    {
        public long SprjEventFlagManager;
        public uint EventFlagId;
        public bool State;
    }
}
