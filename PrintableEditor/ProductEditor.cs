using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PrintableEditor
{
    public partial class ProductEditor : Form
    {
        string fileName;
        ProductsList parent;

        bool saveBeforeClose = false;

        public ProductEditor(string fileName, ProductsList parent)
        {
            InitializeComponent();

            this.fileName = fileName;
            this.parent = parent;
        }

        private void ProductEditor_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            string jsonPath = WebPaths.productsjson + fileName;

            //if file does not exist, return
            if (!File.Exists(jsonPath))
            {
                textBox_filename.Text = jsonPath.Substring(jsonPath.LastIndexOf("\\") + 1);
                //-.json
                textBox_filename.Text = textBox_filename.Text.Substring(0, textBox_filename.Text.Length - 5);
                return;
            }

            Product product = JsonConvert.DeserializeObject<Product>(File.ReadAllText(jsonPath));

            //get filename from path
            textBox_filename.Text = jsonPath.Substring(jsonPath.LastIndexOf("\\") + 1);
            //-.json
            textBox_filename.Text = textBox_filename.Text.Substring(0, textBox_filename.Text.Length - 5);

            textBox_name.Text = product.name;
            textBox_subheading.Text = product.subheading;
            textBox_imgpath.Text = product.image_path;
            textBox_link.Text = product.link;
            rtb_description.Text = product.description;

            foreach (string lens in product.compatible_lenses)
            {
                listBox_compatibility.Items.Add(lens);
            }
        }

        private void button_imgpath_Click(object sender, EventArgs e)
        {
            //open file dialog to select image
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Select an Image";
            openFileDialog1.ShowDialog();

            //if no file is selected, return
            if (openFileDialog1.FileName == "")
            {
                return;
            }

            string imgpath = openFileDialog1.FileName;

            //if path contains webroot, remove it
            string webroot = WebPaths.webroot;
            if (imgpath.Contains(webroot))
            {
                imgpath = imgpath.Replace(webroot, "\\");
            }

            //replace all backslashes with forward slashes
            imgpath = imgpath.Replace("\\", "/");



            //set text box to image path
            textBox_imgpath.Text = imgpath;
        }

        private void button_compat_add_Click(object sender, EventArgs e)
        {
            if (textBox_compatibility.Text != "")
            {
                listBox_compatibility.Items.Add(textBox_compatibility.Text);
                textBox_compatibility.Text = "";
            }
        }

        private void button_compat_remove_Click(object sender, EventArgs e)
        {
            //if nothing is selected, return
            if (listBox_compatibility.SelectedIndex == -1)
            {
                return;
            }

            //masgbnox are you sure
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this item?", "Remove Item", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                listBox_compatibility.Items.RemoveAt(listBox_compatibility.SelectedIndex);
            }
        }

        private void button_moveup_Click(object sender, EventArgs e)
        {
            //swap selected item with item above it
            if (listBox_compatibility.SelectedIndex > 0)
            {
                int index = listBox_compatibility.SelectedIndex;
                string item = listBox_compatibility.Items[index].ToString();
                listBox_compatibility.Items.RemoveAt(index);
                listBox_compatibility.Items.Insert(index - 1, item);
                listBox_compatibility.SelectedIndex = index - 1;
            }
        }

        private void button_movedown_Click(object sender, EventArgs e)
        {
            //swap selected item with item below it
            if (listBox_compatibility.SelectedIndex < listBox_compatibility.Items.Count - 1 && listBox_compatibility.SelectedIndex != -1)
            {
                int index = listBox_compatibility.SelectedIndex;
                string item = listBox_compatibility.Items[index].ToString();
                listBox_compatibility.Items.RemoveAt(index);
                listBox_compatibility.Items.Insert(index + 1, item);
                listBox_compatibility.SelectedIndex = index + 1;
            }
        }

        void ShowParent(object sender, FormClosingEventArgs e)
        {
            if (!saveBeforeClose)
            {
                //messagebox are you sure? yes cancel
                //if yes close form
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit without saving?", "Exit Without Saving", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    parent.Show();
                    parent.reset();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                parent.Show(); 
                parent.reset();
            }
        }

        private void Save()
        {
            string jsonPath = WebPaths.productsjson + textBox_filename.Text + ".json";

            //if file does not exist, create it, else overwrite it
            if (!File.Exists(jsonPath))
            {
                File.Create(jsonPath).Close();
            }

            Product product = new Product();

            product.name = textBox_name.Text;
            product.subheading = textBox_subheading.Text;
            product.image_path = textBox_imgpath.Text;
            product.link = textBox_link.Text;
            product.description = rtb_description.Text;

            //replace all \u000b with \n
            product.description = product.description.Replace("\u000b", "\n");

            List<string> compatible_lenses = new List<string>();
            foreach (string lens in listBox_compatibility.Items)
            {
                compatible_lenses.Add(lens);
            }
            product.compatible_lenses = compatible_lenses;

            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(product));
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void button_saveclose_Click(object sender, EventArgs e)
        {
            Save();
            saveBeforeClose = true;
            this.Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void SaveKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                Save();
            }
        }
    }
}
