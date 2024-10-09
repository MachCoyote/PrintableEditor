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
using System.IO;

namespace PrintableEditor
{
    public partial class GuideEditor : Form
    {
        GuideList parent;

        bool saveBeforeClose = false;

        string jsonPath = "";

        string fileName = "";
        Guide guide = new Guide();

        int loadedStep = 0;

        public GuideEditor(string guidePath, GuideList parent)
        {
            InitializeComponent();

            this.parent = parent;

            jsonPath = guidePath;

            //set filename from path (subtract .json)
            fileName = guidePath.Substring(guidePath.LastIndexOf("\\") + 1);
            fileName = fileName.Substring(0, fileName.Length - 5);

            //if exists, load guide
            if (File.Exists(guidePath))
            {
                guide = JsonConvert.DeserializeObject<Guide>(File.ReadAllText(guidePath));
            }
            else
            {
                guide.name = "New Guide";
                guide.description = "I am a guide!";
                List<Step> steps = new List<Step>();
                Step step = new Step();
                step.heading = "Step 1";
                step.description = "This is step 1";
                steps.Add(step);
                guide.steps = steps;
            }
        }

        private void GuideEditor_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            textBox_filename.Text = fileName;
            textBox_name.Text = guide.name;
            textBox_imgpath.Text = guide.img;
            rtb_description.Text = guide.description;

            LoadSteps();
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

        void LoadGuide()
        {
            textBox_filename.Text = fileName;
            textBox_name.Text = guide.name;
            textBox_imgpath.Text = guide.img;
            rtb_description.Text = guide.description;

            LoadSteps();
        }

        void LoadSteps()
        {
            lb_steps.Items.Clear();

            int i = 1;
            foreach (Step step in guide.steps)
            {
                lb_steps.Items.Add($"[{i}]: " + step.heading);

                i++;
            }

            lb_steps.SelectedIndex = 0;
            LoadStep();
        }

        void LoadSteps(int selectedStep)
        {
            lb_steps.Items.Clear();

            int i = 1;
            foreach (Step step in guide.steps)
            {
                lb_steps.Items.Add($"[{i}]: " + step.heading);

                i++;
            }

            lb_steps.SelectedIndex = selectedStep;
            LoadStep();
        }

        void LoadStep()
        {
            if (lb_steps.SelectedIndex == -1)
            {
                loadedStep = -1;
                return;
            }

            loadedStep = lb_steps.SelectedIndex;

            Step step = guide.steps[lb_steps.SelectedIndex];

            tb_stephead.Text = step.heading;
            tb_stepimg.Text = step.img;
            rtb_stepdesc.Text = step.description;
        }

        private void lb_steps_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStep();
        }

        void SaveStep()
        {
            LoadSteps(lb_steps.SelectedIndex);

            guide.steps[loadedStep].heading = tb_stephead.Text;
            guide.steps[loadedStep].img = tb_stepimg.Text;
            guide.steps[loadedStep].description = rtb_stepdesc.Text;

            //replace all \u000b with \n
            guide.steps[loadedStep].description = guide.steps[loadedStep].description.Replace("\u000b", "\n");
        }

        private void button_savestep_Click(object sender, EventArgs e)
        {
            SaveStep();
        }

        private void button_addstep_Click(object sender, EventArgs e)
        {
            Step step = new Step();
            step.heading = "New Step";
            step.description = "I am a step!";
            guide.steps.Insert(lb_steps.SelectedIndex + 1, step);
            LoadSteps(lb_steps.SelectedIndex + 1);
        }

        private void button_removestep_Click(object sender, EventArgs e)
        {
            //msgbox are you sure
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this step?", "Remove Step", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                guide.steps.RemoveAt(lb_steps.SelectedIndex);
                LoadSteps();
            }
        }

        private void button_stepup_Click(object sender, EventArgs e)
        {
            if (lb_steps.SelectedIndex > 0)
            {
                int index = lb_steps.SelectedIndex;
                Step step = guide.steps[index];
                guide.steps.RemoveAt(index);
                guide.steps.Insert(index - 1, step);
                LoadSteps(index - 1);
            }
        }

        private void button_stepdown_Click(object sender, EventArgs e)
        {
            if (lb_steps.SelectedIndex < guide.steps.Count - 1)
            {
                int index = lb_steps.SelectedIndex;
                Step step = guide.steps[index];
                guide.steps.RemoveAt(index);
                guide.steps.Insert(index + 1, step);
                LoadSteps(index + 1);
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Save()
        {
            SaveStep();

            guide.name = textBox_name.Text;
            guide.img = textBox_imgpath.Text;
            guide.description = rtb_description.Text;

            //replace all \u000b with \n
            guide.description = guide.description.Replace("\u000b", "\n");

            //replace jsonPath with new filename
            jsonPath = jsonPath.Substring(0, jsonPath.LastIndexOf("\\") + 1) + textBox_filename.Text + ".json";

            //if guidePath (the json file) doesn't exist, create it
            if (!File.Exists(jsonPath))
            {
                File.Create(jsonPath).Close();
            }

            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(guide));
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void button_saveexit_Click(object sender, EventArgs e)
        {
            Save();
            saveBeforeClose = true;
            this.Close();
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

        private void button_stepimg_Click(object sender, EventArgs e)
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
            tb_stepimg.Text = imgpath;
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
