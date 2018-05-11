
namespace CodeSanook.Common.Modules
{
    public class ModuleHelper
    {
        public static string GetModuleName()
        {
            return typeof(ModuleHelper).Assembly.GetName().Name;
        }
    }
}