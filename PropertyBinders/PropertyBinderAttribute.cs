using System;

namespace Codesanook.Common.PropertyBinders {

    [AttributeUsage(AttributeTargets.Property)]
    public class PropertyBinderAttribute : Attribute {
        public PropertyBinderAttribute(Type binderType) => BinderType = binderType;
        public Type BinderType { get; private set; }
    }
}