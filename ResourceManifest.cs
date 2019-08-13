using Orchard.UI.Resources;

namespace Codesanook.Common
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();
            manifest.DefineScript("SystemJS").SetUrl("system.js");
            manifest.DefineScript("Lodash").SetUrl("lodash.js");
            manifest.DefineScript("AngularMessages").SetUrl("angular-messages.js");
        }
    }
}
