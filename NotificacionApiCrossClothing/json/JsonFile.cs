using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace NotificacionApiCrossClothing.json
{
   public static class JsonFile
    {
        public static T FromJson<T>(string jsonFileName)
        {
            return JsonConvert.DeserializeObject<T>(ReadJsonFromFile(jsonFileName));
        }

        private static string ReadJsonFromFile(string jsonFileName)
        {
            string path = string.IsNullOrEmpty(AppDomain.CurrentDomain.RelativeSearchPath) ?
                AppDomain.CurrentDomain.BaseDirectory : AppDomain.CurrentDomain.RelativeSearchPath;
            JObject jsonConfig = JObject.Parse(File.ReadAllText(string.Format(CultureInfo.CurrentCulture, "{0}\\{1}", path, jsonFileName, CultureInfo.CurrentCulture)));
           //JObject jsonConfig = JObject.Parse(File.ReadAllText($"{path}{jsonFileName}"));
            return jsonConfig.ToString(Formatting.None);
        }
    }
}
