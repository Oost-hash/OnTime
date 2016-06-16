using System.Net;
using System.Xml;

namespace OnTime
{
    class Api
    {
        //APi Auth fields
        private const string UserName = "robbie.roeten@student.stenden.com";
        private const string UserPass = "URh9TIvryE5RATjrh88MhPE7bMak44VsHxaGKENhTwZkT_69xvuPlw";

        //Field for url api
        private const string BaseUrl = "http://webservices.ns.nl/ns-api-";
        

        private static XmlDocument ApiCall(string url)
        {
            XmlResolver resolver = new XmlUrlResolver();
            resolver.Credentials = new NetworkCredential(UserName, UserPass);

            XmlDocument xmlDoc = new XmlDocument {XmlResolver = resolver};
            xmlDoc.Load(url);

            return xmlDoc;
        }

        public XmlDocument Departure(string station)
        {
            string url = $"{BaseUrl}avt?station={station}";
            return ApiCall(url);
        }

        public XmlDocument Prices(string from, string to, string via, string date)
        {
            string url = $"{BaseUrl}prijzen-v3?from={from}&to={to}";

            if (via != null)
            {
                url += $"&via={via}";
            } else if (date != null)
            {
                url += $"&date={date}";
            }

            return ApiCall(url);
        }

        public XmlDocument Disruptions(string station, bool actual, bool unplannend)
        {
            string url = $"{BaseUrl}storingen?station={station}&actual={actual}&unplanned={unplannend}";

            return ApiCall(url);
        }

        public XmlDocument TravelAdvice(string from, string to, string via, string dateTime, bool departure, int previousAdvices, int nextAdvices)
        {
            string url = $"{BaseUrl}treinplanner?fromStation={from}&toStation={to}&previousAdvices={previousAdvices}&=nextAdvices={nextAdvices}";

            if (via != null)
            {
                url += $"&viaStation={via}";
            } else if (dateTime != null)
            {
                url += $"&dateTime={dateTime}";
            }
            if (departure)
            {
                url += "&Departure=false";
            }

            return ApiCall(url);
        }
    }
}
