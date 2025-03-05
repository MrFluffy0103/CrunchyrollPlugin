using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Drawing;
using MediaBrowser.Model.Serialization;
using MediaBrowser.Common.Configuration;

namespace Jellyfin.Plugin.Crunchyroll
{
    public class PluginEntry : BasePlugin<PluginConfiguration>
    {
        public PluginEntry(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
            : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }

        public override string Name => "Crunchyroll Plugin";

        public override string Description => "A plugin to stream Crunchyroll content through Jellyfin.";

        public static PluginEntry Instance { get; private set; } = null!;
    }
}