using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SoulMemory.DarkSouls1_Old.Internal;

namespace SoulMemory
{
    public class SoulInjecteeClient : IDisposable
    {
        private ClientWebSocket _clientWebSocket;

        public SoulInjecteeClient()
        {
            _clientWebSocket = new ClientWebSocket();
            TryConnect();
        }

        public bool TryConnect()
        {
            try
            {
                if (_clientWebSocket == null)
                {
                    _clientWebSocket = new ClientWebSocket();
                }
                _clientWebSocket.ConnectAsync(new Uri("ws://localhost:54345"), CancellationToken.None).GetAwaiter().GetResult();
            }
            catch(Exception e)
            {
                _clientWebSocket = null;
            }
            return IsConnected;
        }

        public bool IsConnected => _clientWebSocket?.State == WebSocketState.Open;

        
        private void Send(Message message)
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
                _clientWebSocket = null;
            }
        }


        public void Unload()
        {
            var message = new Message("unload");
            Send(message);
            _clientWebSocket.Dispose();
            _clientWebSocket = null;
        }

        #region EventFlags

        public void EventFlagSetLogMode(EventFlagLogMode eventFlagLogMode)
        {
            var message = new Message("EventFlagSetLogMode");
            message.EventFlagLogMode = (int)eventFlagLogMode;
            Send(message);
        }
        
        public void EventFlagSetExclusions(List<uint> eventFlags)
        {
            var message = new Message("EventFlagSetExclusions");
            message.EventFlags = eventFlags;
            Send(message);
        }

        #endregion

        #region TAS

        public void TasStart()
        {
            Send(new Message("TasStart"));
        }

        public void TasStop()
        {
            Send(new Message("TasStop"));
        }

        public void TasReadInputFromFile(string filepath)
        {
            var m = new Message("TasReadInputFromFile");
            m.TasInputsFilePath = filepath;
            Send(m);
        }
        #endregion
    }

    public enum EventFlagLogMode
    {
        Unique = 0,
        Exclude = 1,
        Include = 2,
    }
    

    public class Message
    {
        public Message(string messageType)
        {
            MessageType = messageType;
        }

        public string MessageType;

        public DarkSouls3ReadEventFlagMessage DarkSouls3ReadEventFlagMessage = null;

        public int EventFlagLogMode = 0;
        public List<uint> EventFlags = new List<uint>();
        public string TasInputsFilePath =  "";
    }

    public class DarkSouls3ReadEventFlagMessage
    {
        public long SprjEventFlagManager;
        public uint EventFlagId;
        public bool State;
    }
}
