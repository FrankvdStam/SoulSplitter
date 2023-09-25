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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using LiveSplit.Model;
using LiveSplit.UI;
using Moq;
using NSubstitute;

namespace SoulSplitter.Tests.Integration
{
    public class SoulsComponentTestWrapper
    {
        private readonly SoulComponent _soulComponent;
        public readonly Mock<LiveSplitState> MockLiveSplitState;
        public readonly Mock<IRun> MockIRun;

        public SoulsComponentTestWrapper(string xml, string gameName)
        {
            MockIRun = new Mock<IRun>();
            MockIRun
                .Setup(i => i.GameName)
                .Returns(gameName);

            MockLiveSplitState = new Mock<LiveSplitState>(MockIRun.Object, null, null, null, null);

            _soulComponent = new SoulComponent(MockLiveSplitState.Object);
            var doc = new XmlDocument();
            doc.LoadXml(xml);
            _soulComponent.SetSettings(doc);
        }

        public void Update()
        {
            _soulComponent.Update(null, MockLiveSplitState.Object, 0.0f, 0.0f, LayoutMode.Horizontal);
        }
    }
}
