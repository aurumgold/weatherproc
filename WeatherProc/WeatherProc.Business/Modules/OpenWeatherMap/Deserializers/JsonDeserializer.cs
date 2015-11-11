using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using WeatherProc.Business.Modules.OpenWeatherMap.Models;
using WeatherProc.Business.Enums;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Deserializers
{
    public class JsonDeserializer
    {
        public JsonModel JsonToObject(string json, ModelType type)
        {
            switch (type)
            {
                case ModelType.Current:
                    return JsonConvert.DeserializeObject<CurrentJsonModel>(json);

                case ModelType.Forecast5Days:
                    return JsonConvert.DeserializeObject<Forecast5DaysJsonModel>(json);

                case ModelType.Forecast16Days:
                    return JsonConvert.DeserializeObject<Forecast16DaysJsonModel>(json);

                default:
                    return null;
            }
        }

        public JsonModel JsonToObject(StreamReader sr, ModelType type)
        {
            string json = sr.ReadToEnd();
            return JsonToObject(json, type);
        }

    }
}
