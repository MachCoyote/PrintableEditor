using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PrintableEditor
{
    public static class WebPaths
    {
        public static string webroot
        {
            get
            {
                string json = File.ReadAllText("paths.json");
                Paths paths = JsonConvert.DeserializeObject<Paths>(json);
                return paths.webroot;
            }
        }

        public static string productsjson
        {
            get
            {
                return webroot + "products\\product\\json\\";
            }
        }

        public static string guideCategories
        {
            get
            {
                return webroot + "guides\\data\\";
            }
        }
    }
}
