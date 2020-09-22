using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace Codesanook.Common.PropertyBinders {
    public class PhoneNumberPropertyBinder : IPropertyBinder {

        private static readonly Regex pattern = new Regex(@"\s+", RegexOptions.Compiled);

        public object BindModel(
            ControllerContext controllerContext,
            ModelBindingContext bindingContext,
            MemberDescriptor memberDescriptor
        ) {
            var httpContext = controllerContext.HttpContext;
            var phoneNumber = httpContext.Request.Form[memberDescriptor.Name];
            return pattern.Replace(phoneNumber, string.Empty);
        }
    }
}