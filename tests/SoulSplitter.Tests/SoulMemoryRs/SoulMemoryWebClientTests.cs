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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoulSplitter.soulmemory_rs;
using System.Net.Http;
using NSubstitute;
using System.Net;
using System.Threading.Tasks;
using System.Threading;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace SoulSplitter.Tests.SoulMemoryRs
{
    public class MockHttpMessageHandler : HttpMessageHandler
    {
        private readonly string _response;

        public MockHttpMessageHandler(string response)
        {
            _response = response;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            return new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(_response)
            };
        }
    }


    [TestClass]
    public class SoulMemoryWebClientTests
    {
        [TestMethod]
        public void GetEventFlags_Invalid_Json()
        {
            SoulMemoryWebClient.HttpClient = new HttpClient(new MockHttpMessageHandler("test"))
            {
                BaseAddress = new Uri("http://127.0.0.1:2345")
            };
           
            var client = new SoulMemoryWebClient();
            var result = client.GetEventFlags();
            Assert.IsTrue(result.IsErr);
        }

        private const string ExampleJson = @"[{""time"":""2023-09-10T14:24:27.150560800+02:00"",""flag"":2300,""state"":false},{""time"":""2023-09-10T14:24:27.162572500+02:00"",""flag"":2000,""state"":false},{""time"":""2023-09-10T14:24:27.162582+02:00"",""flag"":2001,""state"":true},{""time"":""2023-09-10T14:24:27.162583500+02:00"",""flag"":2010,""state"":false},{""time"":""2023-09-10T14:24:27.162584900+02:00"",""flag"":2011,""state"":false},{""time"":""2023-09-10T14:24:27.162588800+02:00"",""flag"":2040,""state"":true},{""time"":""2023-09-10T14:24:27.166429100+02:00"",""flag"":2300,""state"":false},{""time"":""2023-09-10T14:24:27.167031300+02:00"",""flag"":2000,""state"":false},{""time"":""2023-09-10T14:24:27.167038600+02:00"",""flag"":2001,""state"":true},{""time"":""2023-09-10T14:24:27.167040100+02:00"",""flag"":2010,""state"":false},{""time"":""2023-09-10T14:24:27.167041300+02:00"",""flag"":2011,""state"":false},{""time"":""2023-09-10T14:24:27.167044500+02:00"",""flag"":2040,""state"":true},{""time"":""2023-09-10T14:24:27.174693300+02:00"",""flag"":2300,""state"":false},{""time"":""2023-09-10T14:24:27.175309600+02:00"",""flag"":2000,""state"":false},{""time"":""2023-09-10T14:24:27.175316700+02:00"",""flag"":2001,""state"":true},{""time"":""2023-09-10T14:24:27.175318100+02:00"",""flag"":2010,""state"":false},{""time"":""2023-09-10T14:24:27.175319300+02:00"",""flag"":2011,""state"":false},{""time"":""2023-09-10T14:24:27.175323+02:00"",""flag"":2040,""state"":true},{""time"":""2023-09-10T14:24:27.183088200+02:00"",""flag"":2300,""state"":false}]";

        [TestMethod]
        public void GetEventFlags_Valid()
        {
            SoulMemoryWebClient.HttpClient = new HttpClient(new MockHttpMessageHandler(ExampleJson))
            {
                BaseAddress = new Uri("http://127.0.0.1:2345")
            };

            var client = new SoulMemoryWebClient();
            var result = client.GetEventFlags();
            Assert.IsTrue(result.IsOk);
            var flags = result.Unwrap();
            Assert.AreEqual(19, flags.Count);
            var first = flags[0];
            
            Assert.AreEqual(DateTime.FromBinary(638299526671505608), first.Item1);
            Assert.AreEqual((uint)2300, first.Item2);
            Assert.AreEqual(false, first.Item3);
        }
    }
}
