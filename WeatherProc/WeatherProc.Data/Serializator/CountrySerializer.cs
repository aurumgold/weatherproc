using System;
using System.Xml.Serialization;
using System.IO;
using WeatherProc.Data.Entities;

namespace WeatherProc.Data.Serializator
{
    public class CountrySerializer : IDisposable
    {
        private const string XML_PATH = "XMLs/Countries.xml";

        private XmlSerializer serializer;
        private CountryList countries;
        private string path;

        public CountryList Countries { get { return countries; } }

        #region Constructors
        public CountrySerializer()
        {
            serializer = new XmlSerializer(typeof(CountryList));
            path = XML_PATH;
            countries = null;
        }

        public CountrySerializer(string path)
        {
            serializer = new XmlSerializer(typeof(CountryList));
            this.path = path;
            countries = null;
        }

        public CountrySerializer(CountryList array)
        {
            serializer = new XmlSerializer(typeof(CountryList));
            path = XML_PATH;
            countries = array;
        }

        public CountrySerializer(CountryList array, string path)
        {
            serializer = new XmlSerializer(typeof(CountryList));
            this.path = path;
            countries = array;
        }
        #endregion

        public void Serialize()
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                serializer.Serialize(sw, countries);
                sw.Close();
            }
        }

        public CountryList Deserialize()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                countries = (CountryList)serializer.Deserialize(sr);
                sr.Close();
            }
            return countries;
        }

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    
                }
                disposed = true;
            }
        }
    }
}
