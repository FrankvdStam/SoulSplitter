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

namespace SoulSplitter.Tests
{
    internal static class XmlData
    {


        public const string SekiroMigration1_1_0 =
            @"<MainViewModel xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <Version>1.1.0</Version>
  <SelectedGame>Sekiro</SelectedGame>
  <DarkSouls1ViewModel />
  <DarkSouls2ViewModel>
    <StartAutomatically>true</StartAutomatically>
    <Splits />
  </DarkSouls2ViewModel>
  <DarkSouls3ViewModel>
    <StartAutomatically>true</StartAutomatically>
    <Splits />
  </DarkSouls3ViewModel>
  <SekiroViewModel>
    <StartAutomatically>true</StartAutomatically>
    <OverwriteIgtOnStart>false</OverwriteIgtOnStart>
    <Splits>
      <HierarchicalTimingTypeViewModel>
        <TimingType xmlns=""Sekiro"">Immediate</TimingType>
        <Children xmlns=""Sekiro"">
          <HierarchicalSplitTypeViewModel>
            <SplitType>Boss</SplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">GyoubuMasatakaOniwa</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
          <HierarchicalSplitTypeViewModel>
            <SplitType>Idol</SplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Idol"">DragonspringHirataEstate</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
          <HierarchicalSplitTypeViewModel>
            <SplitType>Position</SplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xmlns:q1=""SoulMemory"" xsi:type=""q1:Vector3f"">
                  <q1:X>1</q1:X>
                  <q1:Y>2</q1:Y>
                  <q1:Z>3</q1:Z>
                </Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
        </Children>
      </HierarchicalTimingTypeViewModel>
      <HierarchicalTimingTypeViewModel>
        <TimingType xmlns=""Sekiro"">OnLoading</TimingType>
        <Children xmlns=""Sekiro"">
          <HierarchicalSplitTypeViewModel>
            <SplitType>Flag</SplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">123456</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
        </Children>
      </HierarchicalTimingTypeViewModel>
    </Splits>
  </SekiroViewModel>
  <EldenRingViewModel>
    <StartAutomatically>true</StartAutomatically>
    <LockIgtToZero>false</LockIgtToZero>
    <EnabledRemoveSplit>false</EnabledRemoveSplit>
    <Splits />
  </EldenRingViewModel>
</MainViewModel>";

        public const string ExampleSettings = @"<MainViewModel xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <Version>1.0.24</Version>
  <SelectedGameIndex>2</SelectedGameIndex>
  <SekiroViewModel>
    <StartAutomatically>true</StartAutomatically>
    <Splits>
      <HierarchicalTimingTypeViewModel>
        <TimingType xmlns=""Sekiro"">Immediate</TimingType>
        <Children xmlns=""Sekiro"">
          <HierarchicalSplitTypeViewModel>
            <SplitType>Position</SplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Vector3f"">
                  <X xmlns="""">-304.803772</X>
                  <Y xmlns="""">-53.6740761</Y>
                  <Z xmlns="""">305.3302</Z>
                </Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
        </Children>
      </HierarchicalTimingTypeViewModel>
    </Splits>
  </SekiroViewModel>
  <EldenRingViewModel>
    <StartAutomatically>true</StartAutomatically>
    <LockIgtToZero>false</LockIgtToZero>
    <EnabledRemoveSplit>false</EnabledRemoveSplit>
    <Splits>
      <HierarchicalTimingTypeViewModel>
        <TimingType>Immediate</TimingType>
        <Children>
          <HierarchicalSplitTypeViewModel>
            <EldenRingSplitType>Flag</EldenRingSplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">60000</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">1034447900</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">11007175</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">13007150</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
          <HierarchicalSplitTypeViewModel>
            <EldenRingSplitType>Grace</EldenRingSplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Grace"">Gatefront</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Grace"">StormhillShack</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Grace"">SouthRayaLucariaGate</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Grace"">MainAcademyGate</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Grace"">DragonTempleRooftop</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
        </Children>
      </HierarchicalTimingTypeViewModel>
      <HierarchicalTimingTypeViewModel>
        <TimingType>OnLoading</TimingType>
        <Children>
          <HierarchicalSplitTypeViewModel>
            <EldenRingSplitType>Grace</EldenRingSplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Grace"">LiurniaHighwaySouth</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Grace"">DragonTemple</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Grace"">TempleOfEiglay</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Grace"">TheFourBelfries</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
          <HierarchicalSplitTypeViewModel>
            <EldenRingSplitType>Flag</EldenRingSplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">1034457100</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">520670</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">16007020</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
          <HierarchicalSplitTypeViewModel>
            <EldenRingSplitType>Boss</EldenRingSplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">GodskinDuoCrumblingFarumAzula</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">MalikethTheBlackBladeCrumblingFarumAzula</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
        </Children>
      </HierarchicalTimingTypeViewModel>
    </Splits>
  </EldenRingViewModel>
<DarkSouls1ViewModel />
  <DarkSouls2ViewModel>
    <Splits />
  </DarkSouls2ViewModel>
</MainViewModel>";

        public const string DarkSouls3Migration_1_9_0 = @"<MainViewModel xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <Version>1.1.9</Version>
  <SelectedGame>DarkSouls3</SelectedGame>
  <DarkSouls1ViewModel>
    <StartAutomatically>true</StartAutomatically>
    <SplitsViewModel>
      <Splits />
    </SplitsViewModel>
    <ResetInventoryIndices>true</ResetInventoryIndices>
  </DarkSouls1ViewModel>
  <DarkSouls2ViewModel>
    <StartAutomatically>true</StartAutomatically>
    <Splits />
  </DarkSouls2ViewModel>
  <DarkSouls3ViewModel>
    <StartAutomatically>true</StartAutomatically>
    <Splits>
      <HierarchicalTimingTypeViewModel>
        <TimingType xmlns=""DarkSouls3"">OnLoading</TimingType>
        <Children xmlns=""DarkSouls3"">
          <HierarchicalSplitTypeViewModel>
            <SplitType>Boss</SplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">IudexGundyr</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">VordtOfTheBorealValley</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">CurseRottedGreatwood</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">DeaconsOfTheDeep</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">PontiffSulyvahn</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">AldrichDevourerOfGods</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">YhormTheGiant</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">OceirosTheConsumedKing</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">ChampionGundyr</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">DragonslayerArmour</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">LothricYoungerPrince</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">AncientWyvern</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">DarkeaterMidir</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">HalflightSpearOfTheChurch</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">SlaveKnightGael</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">SisterFriede</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">ChampionsGravetenderAndGravetenderGreatwolf</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">SoulOfCinder</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">OldDemonKing</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">NamelessKing</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">HighLordWolnir</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
          <HierarchicalSplitTypeViewModel>
            <SplitType>Flag</SplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">133</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">70000109</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">25105032</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">25105003</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">64500630</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">14100510</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
          <HierarchicalSplitTypeViewModel>
            <SplitType>Attribute</SplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Attribute"">
                  <AttributeType>Dexterity</AttributeType>
                  <Level>39</Level>
                </Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
        </Children>
      </HierarchicalTimingTypeViewModel>
      <HierarchicalTimingTypeViewModel>
        <TimingType xmlns=""DarkSouls3"">Immediate</TimingType>
        <Children xmlns=""DarkSouls3"">
          <HierarchicalSplitTypeViewModel>
            <SplitType>Flag</SplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">13000885</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
          <HierarchicalSplitTypeViewModel>
            <SplitType>Bonfire</SplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Bonfire"">OceirosTheConsumedKing</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
          <HierarchicalSplitTypeViewModel>
            <SplitType>ItemPickup</SplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""ItemPickup"">CovenantWarriorOfSunlightRank1SunlightShield</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
        </Children>
      </HierarchicalTimingTypeViewModel>
    </Splits>
  </DarkSouls3ViewModel>
  <SekiroViewModel>
    <StartAutomatically>true</StartAutomatically>
    <SplitsViewModel>
      <Splits />
    </SplitsViewModel>
    <OverwriteIgtOnStart>false</OverwriteIgtOnStart>
  </SekiroViewModel>
  <EldenRingViewModel>
    <StartAutomatically>true</StartAutomatically>
    <LockIgtToZero>false</LockIgtToZero>
    <EnabledRemoveSplit>false</EnabledRemoveSplit>
    <Splits />
  </EldenRingViewModel>
</MainViewModel>";
    }
}
