using System;
using System.Windows.Markup;

namespace SoulSplitterUIv2.Ui.View
{
    public class ServiceProviderSource : MarkupExtension
    {
        public static Func<Type, object> Resolver { get; set; }
        public Type Type { get; set; }
        public override object ProvideValue(IServiceProvider serviceProvider) => Resolver?.Invoke(Type);
    }
}
