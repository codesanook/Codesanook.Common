using System.Web.Mvc;// Model binding of MVC not WebAPI
using Codesanook.Common.PropertyBinders;
using Orchard.Environment;

namespace Codesanook.Common {
    public class ShellEvent : IOrchardShellEvents {
        public void Activated() {
            ModelBinders.Binders.DefaultBinder = new CustomModelBinder();
        }

        public void Terminating() {
        }
    }
}
