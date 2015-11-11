using System.IO;
using System.Xml.Serialization;
using WeatherProc.Business.Modules.OpenWeatherMap.Models;
using WeatherProc.Business.Enums;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Deserializers
{
    public class XmlDeserializer
    {
        private XmlSerializer serializer;
        public XmlModel XmlToObject(StreamReader str, ModelType type)
        {
            switch (type)
            {
                case ModelType.Current:
                    serializer = new XmlSerializer(typeof(CurrentXmlModel));
                    return (CurrentXmlModel)serializer.Deserialize(str);

                case ModelType.Forecast5Days:
                    serializer = new XmlSerializer(typeof(Forecast5DaysXmlModel));
                    return (Forecast5DaysXmlModel)serializer.Deserialize(str);

                case ModelType.Forecast16Days:
                    serializer = new XmlSerializer(typeof(Forecast16DaysXmlModel));
                    return (Forecast16DaysXmlModel)serializer.Deserialize(str);

                default:
                    return null;
            }
        }
    }
}
