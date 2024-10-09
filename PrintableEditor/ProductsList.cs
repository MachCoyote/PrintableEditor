using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
namespace PrintableEditor
{
    public partial class ProductsList : Form
    {
        Start parent;

        List<string> productsJSON = new List<string>();
        List<string> filepaths = new List<string>();
        List<string> productNames = new List<string>();

        public ProductsList(Start parent)
        {
            InitializeComponent();

            this.parent = parent;
        }

        private void ProductsList_Load(object sender, EventArgs e)
        {
            productsJSON.Clear();
            filepaths.Clear();
            productNames.Clear();

            string webroot = WebPaths.webroot;

            string restofpath = "products\\product\\json\\";

            foreach (string file in Directory.GetFiles(webroot + restofpath))
            {
                //if file is a json file
                if (file.EndsWith(".json"))
                {
                    Product product = JsonConvert.DeserializeObject<Product>(File.ReadAllText(file));
                    productsJSON.Add(File.ReadAllText(file));
                    filepaths.Add(file);
                    productNames.Add(product.name);
                }

            }

            //add to listbox
            Products.Items.Clear();
            for (int i = 0; i < productNames.Count; i++)
            {
                Products.Items.Add(productNames[i]);
                //if name is blank, use filename
                if (productNames[i] == "")
                {
                    Products.Items[i] = filepaths[i].Substring(filepaths[i].LastIndexOf("\\") + 1);
                }
            }
        }

        private void Products_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete method
            //messagebox are you sure? yes cancel
            //if yes delete file using filepaths[Products.SelectedIndex]
            //reload form

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                File.Delete(filepaths[Products.SelectedIndex]);
                //reload products
                Products.Items.Clear();
                ProductsList_Load(sender, e);
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            string path = filepaths[Products.SelectedIndex];
            //get filename from path
            string fileName = path.Substring(path.LastIndexOf("\\") + 1);

            ProductEditor productEditor = new ProductEditor(fileName, this);
            productEditor.Show();
            this.Hide();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            string fileName = "NewProduct.json";
            bool fileExist = true;
            int i = 0;
            while (fileExist)
            {
                if (File.Exists(WebPaths.productsjson + fileName))
                {
                    fileName = "NewProduct" + i + ".json";
                }
                else
                {
                    fileExist = false;
                }
                i++;
            }

            ProductEditor productEditor = new ProductEditor(fileName, this);
            productEditor.Show();
            this.Hide();
        }

        void ShowParent(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        public void reset()
        {
            Products.Items.Clear();
            ProductsList_Load(this, new EventArgs());
        }
    }
}
