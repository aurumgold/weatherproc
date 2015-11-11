using System.IO;
using WeatherProc.Business.Enums;
using WeatherProc.Business.Abstracts;
using WeatherProc.Business.Modules;
using WeatherProc.Business.Modules.OpenWeatherMap.Models;
using WeatherProc.Business.Modules.OpenWeatherMap.Deserializers;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IModule module = new OpenWeatherMapModule();
            module.Initialize();


            bool t = false;
        }

        static void Test1()
        {
            JsonDeserializer jd = new JsonDeserializer();
            XmlDeserializer xd = new XmlDeserializer();

            CurrentJsonModel j = new CurrentJsonModel();
            CurrentXmlModel x = new CurrentXmlModel();
            Forecast5DaysJsonModel fc5 = new Forecast5DaysJsonModel();
            Forecast5DaysXmlModel fc5x = new Forecast5DaysXmlModel();
            Forecast16DaysJsonModel fc16 = new Forecast16DaysJsonModel();
            Forecast16DaysXmlModel fc16x = new Forecast16DaysXmlModel();

            using (StreamReader file = File.OpenText(@"C:\Users\Fishman\Desktop\C#\WeatherProc\Inputs\OpenWeatherMap\json\cur.weather.json"))
            {
                j = jd.JsonToObject(file, ModelType.Current) as CurrentJsonModel;
                file.Close();
            }

            using (StreamReader file = File.OpenText(@"C:\Users\Fishman\Desktop\C#\WeatherProc\Inputs\OpenWeatherMap\xml\cur.weather.xml"))
            {
                x = xd.XmlToObject(file, ModelType.Current) as CurrentXmlModel;
                file.Close();
            }

            using (StreamReader file = File.OpenText(@"C:\Users\Fishman\Desktop\C#\WeatherProc\Inputs\OpenWeatherMap\json\fc5.weather.json"))
            {
                fc5 = jd.JsonToObject(file, ModelType.Forecast5Days) as Forecast5DaysJsonModel;
                file.Close();
            }

            using (StreamReader file = File.OpenText(@"C:\Users\Fishman\Desktop\C#\WeatherProc\Inputs\OpenWeatherMap\xml\fc5.weather.xml"))
            {
                fc5x = xd.XmlToObject(file, ModelType.Forecast5Days) as Forecast5DaysXmlModel;
                file.Close();
            }

            using (StreamReader file = File.OpenText(@"C:\Users\Fishman\Desktop\C#\WeatherProc\Inputs\OpenWeatherMap\json\fc16.weather.json"))
            {
                fc16 = jd.JsonToObject(file, ModelType.Forecast16Days) as Forecast16DaysJsonModel;
                file.Close();
            }

            using (StreamReader file = File.OpenText(@"C:\Users\Fishman\Desktop\C#\WeatherProc\Inputs\OpenWeatherMap\xml\fc16.weather.xml"))
            {
                fc16x = xd.XmlToObject(file, ModelType.Forecast16Days) as Forecast16DaysXmlModel;
                file.Close();
            } 
        }
    }
}
