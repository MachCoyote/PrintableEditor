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

namespace PrintableEditor
{
    public partial class CategoryEditor : Form
    {
        GuideList parent;

        bool saveBeforeClose = false;

        Category category = new Category();
        string categoryFolderPath = "";
        string categoryName = "";
        string categoryFolderName = "";

        public CategoryEditor(string categoryFolderPath, GuideList parent)
        {
            InitializeComponent();

            this.parent = parent;

            this.categoryName = "New Category";

            //if folder exists
            if (File.Exists(categoryFolderPath + "category.json"))
            {
                Category category = JsonConvert.DeserializeObject<Category>(File.ReadAllText(categoryFolderPath + "category.json"));
                this.categoryName = category.name;
            }


            this.categoryFolderPath = categoryFolderPath;
            //get folder name from path
            //take away trailing \\
            string tempFolderPath = categoryFolderPath.Substring(0, categoryFolderPath.Length - 1);
            this.categoryFolderName = tempFolderPath.Substring(tempFolderPath.LastIndexOf("\\") + 1);
        }

        private void CategoryEditor_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            tb_foldername.Text = categoryFolderName;
            tb_catname.Text = categoryName;
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

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save()
        {
            string catsRoot = WebPaths.guideCategories;

            string folderName = tb_foldername.Text;
            string catName = tb_catname.Text;

            string newFolderPath = catsRoot + folderName + "\\";

            //if folder doesnt already exist, create it
            if (!Directory.Exists(newFolderPath))
            {
                Directory.CreateDirectory(newFolderPath);
            }

            //if entries folder doesnt already exist, create it
            if (!Directory.Exists(newFolderPath + "entries\\"))
            {
                Directory.CreateDirectory(newFolderPath + "entries\\");
            }

            Category newCategory = new Category();
            newCategory.name = catName;

            //if categories.json doesnt already exist, create it
            if (!File.Exists(newFolderPath + "category.json"))
            {
                File.Create(newFolderPath + "category.json").Close();
            }

            //write category to categories.json
            File.WriteAllText(newFolderPath + "category.json", JsonConvert.SerializeObject(newCategory));
        }

        private void button_saveexit_Click(object sender, EventArgs e)
        {
            Save();
            saveBeforeClose = true;
            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Save();
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
