using Newtonsoft.Json.Converters;

namespace Codesanook.Common.Json
{
    public class DateConverter : IsoDateTimeConverter
    {
        public DateConverter() => DateTimeFormat = "yyyy-MM-dd";
    }
}

