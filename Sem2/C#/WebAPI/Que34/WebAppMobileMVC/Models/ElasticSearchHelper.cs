using Nest;

namespace WebAppMobileMVC.Models
{
    public class ElasticSearchHelper
    {
        private static readonly ElasticClient client;

        static ElasticSearchHelper()
        {
            var settings = new ConnectionSettings(new Uri("http://localhost:5280"))
                .DefaultIndex("tblerror");

            client = new ElasticClient(settings);
        }

        public static ElasticClient Client => client;
    }
}
