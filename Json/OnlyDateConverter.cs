using Newtonsoft.Json.Converters;

namespace Codesanook.Common.Json
{
    public class OnlyDateConverter : IsoDateTimeConverter
    {
        public OnlyDateConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }

}
