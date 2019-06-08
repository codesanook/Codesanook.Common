using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.Environment;
using React;

namespace Codesanook.Common {
    public class ShellEvent : IOrchardShellEvents {
        public void Activated() {
            
            ReactSiteConfiguration.Configuration
                .SetLoadBabel(false)
                .AddScriptWithoutTransform("~/modules/codesanook.common/scripts/server-bundle.js");
        }

        public void Terminating() {
        }
    }
}