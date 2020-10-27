using Newtonsoft.Json;
using System.Collections.Generic;

namespace CustomsCalc.Http.Helpers
{
    public static class IEntityExtensions
    {
        public static string ConvertToJson(List<object> key, List<object> value)
        {
            Dictionary<object, object> keyValues = new Dictionary<object, object>(key.Count);
            for (int i = 0; i < key.Count; i++)
            {
                keyValues.Add(key[i], value[i]);
            }
            dynamic str = JsonConvert.SerializeObject(keyValues, Formatting.Indented);
            return str;
        }
    }
}
