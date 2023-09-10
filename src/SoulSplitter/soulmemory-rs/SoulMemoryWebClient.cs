// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using SoulMemory;

namespace SoulSplitter.soulmemory_rs
{
    public interface ISoulMemoryWebClient
    {
        Result<List<(DateTime, uint, bool)>, Exception> GetEventFlags();
    }

    public class SoulMemoryWebClient : ISoulMemoryWebClient
    {
        public static HttpClient HttpClient = new HttpClient()
        {
            BaseAddress = new Uri("http://127.0.0.1:2345")
        };

        [DataContract]
        internal class EventFlag
        {
            [DataMember(Name = "time")]
            public string Time = "";

            [DataMember(Name = "flag")]
            public uint Flag = 0;

            [DataMember(Name = "state")]
            public bool State = false;
        }

        public Result<List<(DateTime, uint, bool)>, Exception> GetEventFlags()
        {
            try
            {
                var stream = HttpClient.GetStreamAsync("/event_flags").Result;

                byte[] buffer = new byte[0];
                using (var memoryStream = new MemoryStream())
                {
                    stream.CopyTo(memoryStream);
                    buffer = memoryStream.GetBuffer();

                    var str = Encoding.UTF8.GetString(buffer);

                    memoryStream.Seek(0, SeekOrigin.Begin);
                    var serializer = new DataContractJsonSerializer(typeof(List<EventFlag>));
                    var serializeResult = serializer.ReadObject(memoryStream) as List<EventFlag>;
                    return Result.Ok(serializeResult?.Select(i => (DateTime.Parse(i.Time), i.Flag, i.State)).ToList());
                }
            }
            catch (Exception ex)
            {
                return Result.Err(ex);
            }
        }
    }
}
