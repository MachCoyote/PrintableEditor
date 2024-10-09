using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintableEditor
{
    public class Product
    {
        public string name { get; set; }
        public string subheading { get; set; }
        public string description { get; set; }
        public string image_path { get; set; }
        public string link { get; set; }
        public List<string> compatible_lenses { get; set; }
    }

    public class Guide
    {
        public string name { get; set; }
        public string img { get; set; }
        public string description { get; set; }
        public List<Step> steps { get; set; }
    }

    public class Step
    {
        public string heading { get; set; }
        public string description { get; set; }
        public string img { get; set; }
    }

    public class Paths
    {
        public string webroot { get; set; }
    }

    public class Category
    {
        public string name { get; set; }
    }
}
