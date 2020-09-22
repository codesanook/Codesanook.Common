using System.ComponentModel;
using System.Web.Mvc;

namespace Codesanook.Common.PropertyBinders {
    public interface IPropertyBinder {
        object BindModel(
            ControllerContext controllerContext,
            ModelBindingContext bindingContext,
            MemberDescriptor memberDescriptor
        );
    }
}