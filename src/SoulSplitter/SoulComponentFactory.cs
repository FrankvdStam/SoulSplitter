using System;
using LiveSplit.Model;
using LiveSplit.UI.Components;
using SoulSplitter;


[assembly: ComponentFactory(typeof(SoulComponentFactory))]

namespace SoulSplitter
{
    public class SoulComponentFactory : IComponentFactory
    {
        public string ComponentName => SoulComponent.Name;

        public string Description => "Elden Ring plugin for IGT/RTA with load removal";

        public ComponentCategory Category => ComponentCategory.Control;

        public string UpdateName => SoulComponent.Name;
        
        public string XMLURL => $"{UpdateURL}/Components/Updates.xml";

        public string UpdateURL => "https://raw.githubusercontent.com/FrankvdStam/SoulSplitter/main/";

        public Version Version => new Version(0, 0, 11);

        public IComponent Create(LiveSplitState state)
        {
            return new SoulComponent(state);
        }
    }
}
