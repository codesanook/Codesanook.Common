using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;

namespace Codesanook.Common.PropertyBinders {
    // https://stackoverflow.com/a/12683210/1872200
    // http://aboutcode.net/2011/03/12/mvc-property-binder.html
    public class CustomModelBinder : DefaultModelBinder {

        protected override void BindProperty(
            ControllerContext controllerContext,
            ModelBindingContext bindingContext,
            PropertyDescriptor propertyDescriptor
        ) {
            var propertyBinderAttribute = TryFindPropertyBinderAttribute(propertyDescriptor);
            if (propertyBinderAttribute != null) {
                var binder = CreateBinder(propertyBinderAttribute);
                var value = binder.BindModel(controllerContext, bindingContext, propertyDescriptor);
                //var value = bindingContext.ValueProvider.GetValue(memberDescriptor.Name); 
                propertyDescriptor.SetValue(bindingContext.Model, value);
            }
            else // Back to the default behavior.
            {
                base.BindProperty(controllerContext, bindingContext, propertyDescriptor);
            }
        }

        private PropertyBinderAttribute TryFindPropertyBinderAttribute(PropertyDescriptor propertyDescriptor) =>
            propertyDescriptor.Attributes.OfType<PropertyBinderAttribute>().FirstOrDefault();

        private IPropertyBinder CreateBinder(PropertyBinderAttribute propertyBinderAttribute) =>
            (IPropertyBinder)Activator.CreateInstance(propertyBinderAttribute.BinderType);
    }
}