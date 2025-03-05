using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;
using MediaBrowser.Model.Drawing;
using MediaBrowser.Common.Configuration;
using System.Collections.Generic;

namespace Jellyfin.Plugin.Crunchyroll
{
    public class CrunchyrollPlugin : BasePlugin<PluginConfiguration>, IHasWebPages
    {
        public CrunchyrollPlugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
            : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }

        public override string Name => "Crunchyroll Plugin";

        public override string Description => "A plugin to stream Crunchyroll content through Jellyfin.";

        public static CrunchyrollPlugin Instance { get; private set; } = null!;

        public IEnumerable<PluginPageInfo> GetPages()
        {
            return new[]
            {
                new PluginPageInfo
                {
                    Name = "crunchyroll",
                    EmbeddedResourcePath = GetType().Namespace + ".Configuration.crunchyroll.html"
                },
                new PluginPageInfo
                {
                    Name = "crunchyrolljs",
                    EmbeddedResourcePath = GetType().Namespace + ".Configuration.crunchyroll.js"
                }
            };
        }
    }
}