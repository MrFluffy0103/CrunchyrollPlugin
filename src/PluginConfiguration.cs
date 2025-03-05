using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.Crunchyroll
{
    public class PluginConfiguration : BasePluginConfiguration
    {
        public string CrunchyrollUsername { get; set; } = string.Empty;
        public string CrunchyrollPassword { get; set; } = string.Empty;
    }
}