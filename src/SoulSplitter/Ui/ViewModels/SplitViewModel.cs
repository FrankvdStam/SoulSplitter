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
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using SoulMemory;
using SoulMemory.Enums;

namespace SoulSplitter.Ui.ViewModels;

public class SplitViewModel : IXmlSerializable
{
    public SplitViewModel(){}

    public SplitViewModel(Game game, int newGamePlusLevel, TimingType timingType, SplitType splitType, object split, string description)
    {
        Game = game;
        NewGamePlusLevel = newGamePlusLevel;
        TimingType = timingType;
        SplitType = splitType;
        Split = split;
        Description = description;
    }

    public string Description { get; set; } = null!;
    public Game Game { get; set; }
    public int NewGamePlusLevel { get; set; }
    public TimingType TimingType { get; set; }
    public SplitType SplitType { get; set; }
    public object Split{ get; set; } = null!;


    public bool SplitTriggered;
    public bool SplitConditionMet;


    #region Serialization =======================================================================================

    public XmlSchema GetSchema()
    {
        return null!;
    }

    public void ReadXml(XmlReader reader)
    {
        var xml = reader.ReadOuterXml();
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(xml);
        var node = xmlDocument.GetChildNodeByName(nameof(SplitViewModel));

        var description = node.GetChildNodeByName(nameof(SplitViewModel.Description)).FirstChild.Value;
        var game = node.GetChildNodeByName(nameof(SplitViewModel.Game)).FirstChild.Value;
        var newGamePlusLevel = node.GetChildNodeByName(nameof(SplitViewModel.NewGamePlusLevel)).FirstChild.Value;
        var timingType = node.GetChildNodeByName(nameof(SplitViewModel.TimingType)).FirstChild.Value;
        var splitType = node.GetChildNodeByName(nameof(SplitViewModel.SplitType)).FirstChild.Value;

        Description = description;
        Game = (Game)Enum.Parse(typeof(Game), game);
        NewGamePlusLevel = int.Parse(newGamePlusLevel);
        TimingType = (TimingType)Enum.Parse(typeof(TimingType), timingType);
        SplitType = (SplitType)Enum.Parse(typeof(SplitType), splitType);
        Split = DeserializeSplitObject(node.GetChildNodeByName(nameof(SplitViewModel.Split)), SplitType);
    }

    private object DeserializeSplitObject(XmlNode splitNode, SplitType splitType)
    {
        var typeAttribute = splitNode.GetAttributeByName("type").Value;
        Type type = Type.GetType(typeAttribute + ", SoulMemory")!;
    
        switch (splitType)
        {
            case SplitType.Boss:
            case SplitType.KnownFlag:
            case SplitType.ItemPickup:
            case SplitType.Bonfire:
                return Enum.Parse(type!, splitNode.InnerText);
    
            case SplitType.Flag:
                var flag = splitNode.FirstChild.Value;
                return uint.Parse(flag);
    
            case SplitType.Position:
                var positionViewModel = new PositionViewModel();
                var position = splitNode.FirstChild.GetChildNodeByName(nameof(PositionViewModel.Position));
                var x = position.GetChildNodeByName(nameof(Vector3f.X)).FirstChild.Value;
                var y = position.GetChildNodeByName(nameof(Vector3f.Y)).FirstChild.Value;
                var z = position.GetChildNodeByName(nameof(Vector3f.Z)).FirstChild.Value;
                var size = splitNode.FirstChild.GetChildNodeByName(nameof(PositionViewModel.Size)).FirstChild.Value;
    
                positionViewModel.Position.X = float.Parse(x);
                positionViewModel.Position.Y = float.Parse(y);
                positionViewModel.Position.Z = float.Parse(z);
                positionViewModel.Size = float.Parse(size);
    
                return positionViewModel;
    
            case SplitType.Attribute:
                var attributeViewModel = new AttributeViewModel();
    
                var attributeNode = splitNode.FirstChild.GetChildNodeByName(nameof(AttributeViewModel.Attribute));
                var attributeNodeType = attributeNode.GetAttributeByName("type").Value;
                Type attributeType = Type.GetType(attributeNodeType + ", SoulMemory")!;
    
                var attribute = splitNode.FirstChild.GetChildNodeByName(nameof(AttributeViewModel.Attribute)).FirstChild.Value;
                var level = splitNode.FirstChild.GetChildNodeByName(nameof(AttributeViewModel.Level)).FirstChild.Value;
    
                attributeViewModel.Attribute = (Enum)Enum.Parse(attributeType!, attribute);
                attributeViewModel.Level = int.Parse(level);
                return attributeViewModel;
    
            case SplitType.DarkSouls1Item:
            case SplitType.EldenRingPosition:
            case SplitType.DarkSouls1Bonfire:
            default:
                throw new NotImplementedException();
        }
    }

    public void WriteXml(XmlWriter writer)
    {
        writer.WriteElementString(nameof(SplitViewModel.Description), Description);
        writer.WriteElementString(nameof(SplitViewModel.Game), Game.ToString());
        writer.WriteElementString(nameof(SplitViewModel.NewGamePlusLevel), NewGamePlusLevel.ToString());
        writer.WriteElementString(nameof(SplitViewModel.TimingType), TimingType.ToString());
        writer.WriteElementString(nameof(SplitViewModel.SplitType), SplitType.ToString());
        SerializeSplitObject(writer, SplitType, Split);
    }

    private void SerializeSplitObject(XmlWriter writer, SplitType splitType, object split)
    {
        writer.WriteStartElement(nameof(SplitViewModel.Split));
        writer.WriteAttributeString("type", split.GetType().ToString());

        switch (splitType)
        {
            case SplitType.Boss:
            case SplitType.KnownFlag:
            case SplitType.ItemPickup:
            case SplitType.Bonfire:
            case SplitType.Flag:
                writer.WriteString(split.ToString());
                break;

            case SplitType.Position:
                var position = (PositionViewModel)split;
                writer.WriteStartElement(nameof(PositionViewModel));
                writer.WriteStartElement(nameof(PositionViewModel.Position));
                writer.WriteElementString(nameof(Vector3f.X), position.Position.X.ToString());
                writer.WriteElementString(nameof(Vector3f.Y), position.Position.Y.ToString());
                writer.WriteElementString(nameof(Vector3f.Z), position.Position.Z.ToString());
                writer.WriteEndElement();
                writer.WriteElementString(nameof(PositionViewModel.Size), position.Size.ToString());
                writer.WriteEndElement();
                break;

            case SplitType.Attribute:
                var attributeViewModel = (AttributeViewModel)split;
                writer.WriteStartElement(nameof(AttributeViewModel));

                writer.WriteStartElement(nameof(AttributeViewModel.Attribute));
                writer.WriteAttributeString("type", attributeViewModel.Attribute.GetType().ToString());
                writer.WriteString(attributeViewModel.Attribute.ToString());
                writer.WriteEndElement();

                writer.WriteElementString(nameof(AttributeViewModel.Level), attributeViewModel.Level.ToString());
                writer.WriteEndElement();
                break;

            case SplitType.DarkSouls1Item:
            case SplitType.EldenRingPosition:
            case SplitType.DarkSouls1Bonfire:
                throw new NotImplementedException();
        }

        writer.WriteEndElement();
    }

    #endregion
}
