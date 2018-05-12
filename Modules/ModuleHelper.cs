
namespace CodeSanook.Common.Modules
{
    public class ModuleHelper
    {
        public static string GetModuleName<TInModule>()
        {
            return typeof(TInModule).Assembly.GetName().Name;
        }
    }
}