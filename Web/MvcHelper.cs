using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeSanook.Common.Web
{
    public class MvcHelper
    {
       public static string GetControllerName<T>()where T: Controller {
            return typeof(T).Name.Replace("Controller", "");
        }
    }
}