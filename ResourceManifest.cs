using Orchard.UI.Resources;

namespace Orchard.Core.Common
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();
            manifest.DefineScript("SystemJS").SetUrl("system.js");
            manifest.DefineScript("Lodash").SetUrl("lodash.js");
            manifest.DefineScript("React").SetUrl("react.development.js");
            manifest.DefineScript("ReactDOM").SetUrl("react-dom.development.js");
            manifest.DefineScript("AngularMessages").SetUrl("angular-messages.js");
        }
    }
}
