using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Newtonsoft.Json;

namespace PrintableEditor
{
    public partial class GuideList : Form
    {
        Start parent;

        List<string> categoryNames = new List<string>();
        List<string> categoryPaths = new List<string>();

        List<string> guideNames = new List<string>();
        List<string> guidePaths = new List<string>();

        public GuideList(Start parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void GuideList_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        void ShowParent(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        void LoadCategories()
        {
            categoryNames.Clear();
            categoryPaths.Clear();
            lb_categories.Items.Clear();

            string searchPath = WebPaths.guideCategories;

            //foreach dir in searchPath, if it has a category.json, add its folder path and name from category.json to lists
            foreach (string dir in Directory.GetDirectories(searchPath))
            {
                string dirdir = dir + "\\";
                string categoryJsonPath = dirdir + "category.json";
                if (File.Exists(categoryJsonPath))
                {
                    Category category = JsonConvert.DeserializeObject<Category>(File.ReadAllText(categoryJsonPath));
                    categoryNames.Add(category.name);
                    categoryPaths.Add(dirdir);

                    lb_categories.Items.Add(category.name);
                }
                else //delete the folder if it doesn't have a category.json
                {
                    try
                    {
                        Directory.Delete(dirdir, true);
                    }
                    catch (Exception e)
                    {

                    }
                }
            }

            lb_categories.SelectedIndex = 0;

            LoadGuides();
        }

        void LoadGuides()
        {
            guideNames.Clear();
            guidePaths.Clear();
            lb_guides.Items.Clear();

            string searchPath = categoryPaths[lb_categories.SelectedIndex] + "entries\\";

            //foreach json in searchPath, add its path and name from json to lists
            foreach (string file in Directory.GetFiles(searchPath))
            {
                if (file.EndsWith(".json"))
                {
                    Guide guide = JsonConvert.DeserializeObject<Guide>(File.ReadAllText(file));
                    guideNames.Add(guide.name);
                    guidePaths.Add(file);

                    lb_guides.Items.Add(guide.name);
                }
            }
        }

        private void lb_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_guides.Text = "Guides in " + categoryNames[lb_categories.SelectedIndex];
            LoadGuides();
        }

        private void button_cat_delete_Click(object sender, EventArgs e)
        {
            //messagebox are you sure? yes cancel
            //if yes delete folder using categoryPaths[lb_categories.SelectedIndex]
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this category? (WARNING: This will also delete all guides within.)", "Delete Category", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Directory.Delete(categoryPaths[lb_categories.SelectedIndex], true);
                LoadCategories();
            }
        }

        private void button_guide_delete_Click(object sender, EventArgs e)
        {
            //messagebox are you sure? yes cancel
            //if yes delete file using guidePaths[lb_guides.SelectedIndex]
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this guide?", "Delete Guide", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                File.Delete(guidePaths[lb_guides.SelectedIndex]);
                LoadGuides();
            }
        }

        public void reset()
        {
            LoadCategories();
        }

        private void button_cat_edit_Click(object sender, EventArgs e)
        {
            CategoryEditor categoryEditor = new CategoryEditor(categoryPaths[lb_categories.SelectedIndex], this);
            categoryEditor.Show();
            this.Hide();
        }

        private void button_cat_new_Click(object sender, EventArgs e)
        {
            string fileName = "NewCategory";
            string newFolderPath = WebPaths.guideCategories + fileName + "\\";


            //while folder exists, append index to filename
            int i = 0;
            while (Directory.Exists(newFolderPath))
            {
                fileName = "NewCategory" + i;
                newFolderPath = WebPaths.guideCategories + fileName + "\\";
                i++;
            }

            CategoryEditor categoryEditor = new CategoryEditor(newFolderPath, this);
            categoryEditor.Show();
            this.Hide();
        }

        private void button_guide_edit_Click(object sender, EventArgs e)
        {
            GuideEditor guideEditor = new GuideEditor(guidePaths[lb_guides.SelectedIndex], this);
            guideEditor.Show();
            this.Hide();
        }

        private void button_guide_new_Click(object sender, EventArgs e)
        {
            string fileName = "NewGuide.json";

            int i = 0;
            while (File.Exists(categoryPaths[lb_categories.SelectedIndex] + "entries\\" + fileName))
            {
                fileName = "NewGuide" + i + ".json";
                i++;
            }

            GuideEditor guideEditor = new GuideEditor(categoryPaths[lb_categories.SelectedIndex] + "entries\\" + fileName, this);
            guideEditor.Show();
            this.Hide();
        }
    }
}
