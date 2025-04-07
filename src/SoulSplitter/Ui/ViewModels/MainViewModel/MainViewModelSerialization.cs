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
using System.Xml.Serialization;
using SoulMemory.Enums;
using System.Xml.Schema;
using System.Xml;
using SoulMemory;

namespace SoulSplitter.Ui.ViewModels.MainViewModel;

internal static class XmlExtensions
{
    public static XmlNode GetChildNodeByName(this XmlNode node, string childName)
    {
        var lower = childName.ToLower();
        foreach (XmlNode child in node.ChildNodes)
        {
            if (child.LocalName.ToLower() == lower)
            {
                return child;
            }
        }
        throw new ArgumentException($"{childName} not found");
    }

    public static XmlAttribute GetAttributeByName(this XmlNode node, string name)
    {
        var lower = name.ToLower();
        if (node.Attributes != null)
        {
            foreach (XmlAttribute attribute in node.Attributes)
            {
                if (attribute.LocalName.ToLower() == lower)
                {
                    return attribute;
                }
            }
        }
        throw new ArgumentException($"{name} not found");
    }

    public static void ForEachChildNodeByName(this XmlNode node, string childName, Action<XmlNode> action)
    {
        var lower = childName.ToLower();
        foreach (XmlNode child in node.ChildNodes)
        {
            if (child.LocalName.ToLower() == lower)
            {
                action(child);
            }
        }
    }
}

public partial class MainViewModel : IXmlSerializable
{
    public XmlSchema GetSchema()
    {
        return null!;
    }

    public void ReadXml(XmlReader reader)
    {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(reader);

        var mainViewModel = xmlDocument.GetChildNodeByName(nameof(MainViewModel));
        var version = mainViewModel.GetChildNodeByName(nameof(MainViewModel.Version)).FirstChild.Value;
        var language = mainViewModel.GetChildNodeByName(nameof(MainViewModel.Language)).FirstChild.Value;
        var startAutomatically = mainViewModel.GetChildNodeByName(nameof(MainViewModel.StartAutomatically)).FirstChild.Value;
        var overwriteIgtOnStart = mainViewModel.GetChildNodeByName(nameof(MainViewModel.OverwriteIgtOnStart)).FirstChild.Value;

        Language = (Language)Enum.Parse(typeof(Language), language);
        StartAutomatically = bool.Parse(startAutomatically);
        OverwriteIgtOnStart = bool.Parse(overwriteIgtOnStart);

        var splits = mainViewModel.GetChildNodeByName(nameof(MainViewModel.Splits));
        foreach (XmlNode splitNode in splits.ChildNodes)
        {
            var splitViewModel = new SplitViewModel();

            var description = splitNode.GetChildNodeByName(nameof(SplitViewModel.Description)).FirstChild.Value;
            var game = splitNode.GetChildNodeByName(nameof(SplitViewModel.Game)).FirstChild.Value;
            var newGamePlusLevel = splitNode.GetChildNodeByName(nameof(SplitViewModel.NewGamePlusLevel)).FirstChild.Value;
            var timingType = splitNode.GetChildNodeByName(nameof(SplitViewModel.TimingType)).FirstChild.Value;
            var splitType = splitNode.GetChildNodeByName(nameof(SplitViewModel.SplitType)).FirstChild.Value;

            splitViewModel.Description = description;
            splitViewModel.Game = (Game)Enum.Parse(typeof(Game), game);
            splitViewModel.NewGamePlusLevel = int.Parse(newGamePlusLevel);
            splitViewModel.TimingType = (TimingType)Enum.Parse(typeof(TimingType), timingType);
            splitViewModel.SplitType = (SplitType)Enum.Parse(typeof(SplitType), splitType);
            splitViewModel.Split = DeserializeSplitObject(splitNode.GetChildNodeByName(nameof(SplitViewModel.Split)), splitViewModel.SplitType);

            Splits.Add(splitViewModel);
        }
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
                var level =  splitNode.FirstChild.GetChildNodeByName(nameof(AttributeViewModel.Level)).FirstChild.Value;

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
        writer.WriteElementString(nameof(Version), Version);
        writer.WriteElementString(nameof(Language), Language.ToString());
        writer.WriteElementString(nameof(StartAutomatically), StartAutomatically.ToString());
        writer.WriteElementString(nameof(OverwriteIgtOnStart), OverwriteIgtOnStart.ToString());
        writer.WriteStartElement(nameof(Splits));

        foreach (var split in Splits)
        {
            writer.WriteStartElement(nameof(SplitViewModel));
            writer.WriteElementString(nameof(SplitViewModel.Description), split.Description);
            writer.WriteElementString(nameof(SplitViewModel.Game), split.Game.ToString());
            writer.WriteElementString(nameof(SplitViewModel.NewGamePlusLevel), split.NewGamePlusLevel.ToString());
            writer.WriteElementString(nameof(SplitViewModel.TimingType), split.TimingType.ToString());
            writer.WriteElementString(nameof(SplitViewModel.SplitType), split.SplitType.ToString());
            SerializeSplitObject(writer, split.SplitType, split.Split);
            writer.WriteEndElement();
        }

        writer.WriteEndElement();
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
}

