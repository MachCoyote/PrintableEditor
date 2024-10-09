namespace PrintableEditor
{
    partial class ProductEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_name = new Label();
            label_subheading = new Label();
            label_imgpath = new Label();
            label_link = new Label();
            label_description = new Label();
            label_compatibility = new Label();
            textBox_name = new TextBox();
            textBox_subheading = new TextBox();
            textBox_imgpath = new TextBox();
            textBox_link = new TextBox();
            rtb_description = new RichTextBox();
            listBox_compatibility = new ListBox();
            button_imgpath = new Button();
            textBox_compatibility = new TextBox();
            button_compat_add = new Button();
            button_compat_remove = new Button();
            button_saveclose = new Button();
            button_save = new Button();
            button_exit = new Button();
            label_filename = new Label();
            textBox_filename = new TextBox();
            label_json = new Label();
            button_moveup = new Button();
            button_movedown = new Button();
            SuspendLayout();
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(12, 44);
            label_name.Name = "label_name";
            label_name.Size = new Size(42, 15);
            label_name.TabIndex = 0;
            label_name.Text = "Name:";
            // 
            // label_subheading
            // 
            label_subheading.AutoSize = true;
            label_subheading.Location = new Point(12, 73);
            label_subheading.Name = "label_subheading";
            label_subheading.Size = new Size(73, 15);
            label_subheading.TabIndex = 1;
            label_subheading.Text = "Subheading:";
            // 
            // label_imgpath
            // 
            label_imgpath.AutoSize = true;
            label_imgpath.Location = new Point(12, 102);
            label_imgpath.Name = "label_imgpath";
            label_imgpath.Size = new Size(70, 15);
            label_imgpath.TabIndex = 2;
            label_imgpath.Text = "Image Path:";
            // 
            // label_link
            // 
            label_link.AutoSize = true;
            label_link.Location = new Point(12, 131);
            label_link.Name = "label_link";
            label_link.Size = new Size(77, 15);
            label_link.TabIndex = 3;
            label_link.Text = "Product Link:";
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Location = new Point(12, 160);
            label_description.Name = "label_description";
            label_description.Size = new Size(70, 15);
            label_description.TabIndex = 4;
            label_description.Text = "Description:";
            // 
            // label_compatibility
            // 
            label_compatibility.AutoSize = true;
            label_compatibility.Location = new Point(12, 490);
            label_compatibility.Name = "label_compatibility";
            label_compatibility.Size = new Size(82, 15);
            label_compatibility.TabIndex = 5;
            label_compatibility.Text = "Compatibility:";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(140, 41);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(460, 23);
            textBox_name.TabIndex = 6;
            // 
            // textBox_subheading
            // 
            textBox_subheading.Location = new Point(140, 70);
            textBox_subheading.Name = "textBox_subheading";
            textBox_subheading.Size = new Size(460, 23);
            textBox_subheading.TabIndex = 7;
            // 
            // textBox_imgpath
            // 
            textBox_imgpath.Location = new Point(140, 99);
            textBox_imgpath.Name = "textBox_imgpath";
            textBox_imgpath.Size = new Size(411, 23);
            textBox_imgpath.TabIndex = 8;
            // 
            // textBox_link
            // 
            textBox_link.Location = new Point(140, 128);
            textBox_link.Name = "textBox_link";
            textBox_link.Size = new Size(460, 23);
            textBox_link.TabIndex = 9;
            // 
            // rtb_description
            // 
            rtb_description.Location = new Point(140, 157);
            rtb_description.Name = "rtb_description";
            rtb_description.Size = new Size(460, 321);
            rtb_description.TabIndex = 10;
            rtb_description.Text = "";
            // 
            // listBox_compatibility
            // 
            listBox_compatibility.FormattingEnabled = true;
            listBox_compatibility.ItemHeight = 15;
            listBox_compatibility.Location = new Point(140, 484);
            listBox_compatibility.Name = "listBox_compatibility";
            listBox_compatibility.Size = new Size(460, 199);
            listBox_compatibility.TabIndex = 11;
            // 
            // button_imgpath
            // 
            button_imgpath.Location = new Point(557, 99);
            button_imgpath.Name = "button_imgpath";
            button_imgpath.Size = new Size(43, 23);
            button_imgpath.TabIndex = 12;
            button_imgpath.Text = "...";
            button_imgpath.UseVisualStyleBackColor = true;
            button_imgpath.Click += button_imgpath_Click;
            // 
            // textBox_compatibility
            // 
            textBox_compatibility.Location = new Point(12, 508);
            textBox_compatibility.Name = "textBox_compatibility";
            textBox_compatibility.Size = new Size(122, 23);
            textBox_compatibility.TabIndex = 13;
            // 
            // button_compat_add
            // 
            button_compat_add.Location = new Point(12, 537);
            button_compat_add.Name = "button_compat_add";
            button_compat_add.Size = new Size(122, 23);
            button_compat_add.TabIndex = 14;
            button_compat_add.Text = "Add";
            button_compat_add.UseVisualStyleBackColor = true;
            button_compat_add.Click += button_compat_add_Click;
            // 
            // button_compat_remove
            // 
            button_compat_remove.Location = new Point(12, 566);
            button_compat_remove.Name = "button_compat_remove";
            button_compat_remove.Size = new Size(122, 23);
            button_compat_remove.TabIndex = 15;
            button_compat_remove.Text = "Remove";
            button_compat_remove.UseVisualStyleBackColor = true;
            button_compat_remove.Click += button_compat_remove_Click;
            // 
            // button_saveclose
            // 
            button_saveclose.Location = new Point(315, 711);
            button_saveclose.Name = "button_saveclose";
            button_saveclose.Size = new Size(122, 62);
            button_saveclose.TabIndex = 16;
            button_saveclose.Text = "Save and Exit";
            button_saveclose.UseVisualStyleBackColor = true;
            button_saveclose.Click += button_saveclose_Click;
            // 
            // button_save
            // 
            button_save.Location = new Point(140, 711);
            button_save.Name = "button_save";
            button_save.Size = new Size(122, 62);
            button_save.TabIndex = 17;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(478, 711);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(122, 62);
            button_exit.TabIndex = 18;
            button_exit.Text = "Exit Without Saving";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // label_filename
            // 
            label_filename.AutoSize = true;
            label_filename.Location = new Point(12, 15);
            label_filename.Name = "label_filename";
            label_filename.Size = new Size(58, 15);
            label_filename.TabIndex = 19;
            label_filename.Text = "Filename:";
            // 
            // textBox_filename
            // 
            textBox_filename.Location = new Point(140, 12);
            textBox_filename.Name = "textBox_filename";
            textBox_filename.Size = new Size(422, 23);
            textBox_filename.TabIndex = 20;
            textBox_filename.TextAlign = HorizontalAlignment.Right;
            // 
            // label_json
            // 
            label_json.AutoSize = true;
            label_json.Location = new Point(568, 15);
            label_json.Name = "label_json";
            label_json.Size = new Size(32, 15);
            label_json.TabIndex = 21;
            label_json.Text = ".json";
            // 
            // button_moveup
            // 
            button_moveup.Location = new Point(12, 595);
            button_moveup.Name = "button_moveup";
            button_moveup.Size = new Size(58, 23);
            button_moveup.TabIndex = 22;
            button_moveup.Text = "/\\";
            button_moveup.UseVisualStyleBackColor = true;
            button_moveup.Click += button_moveup_Click;
            // 
            // button_movedown
            // 
            button_movedown.Location = new Point(76, 595);
            button_movedown.Name = "button_movedown";
            button_movedown.Size = new Size(58, 23);
            button_movedown.TabIndex = 23;
            button_movedown.Text = "\\/";
            button_movedown.UseVisualStyleBackColor = true;
            button_movedown.Click += button_movedown_Click;
            // 
            // ProductEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 788);
            Controls.Add(button_movedown);
            Controls.Add(button_moveup);
            Controls.Add(label_json);
            Controls.Add(textBox_filename);
            Controls.Add(label_filename);
            Controls.Add(button_exit);
            Controls.Add(button_save);
            Controls.Add(button_saveclose);
            Controls.Add(button_compat_remove);
            Controls.Add(button_compat_add);
            Controls.Add(textBox_compatibility);
            Controls.Add(button_imgpath);
            Controls.Add(listBox_compatibility);
            Controls.Add(rtb_description);
            Controls.Add(textBox_link);
            Controls.Add(textBox_imgpath);
            Controls.Add(textBox_subheading);
            Controls.Add(textBox_name);
            Controls.Add(label_compatibility);
            Controls.Add(label_description);
            Controls.Add(label_link);
            Controls.Add(label_imgpath);
            Controls.Add(label_subheading);
            Controls.Add(label_name);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProductEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductEditor";
            FormClosing += ShowParent;
            Load += ProductEditor_Load;
            KeyDown += SaveKeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_name;
        private Label label_subheading;
        private Label label_imgpath;
        private Label label_link;
        private Label label_description;
        private Label label_compatibility;
        private TextBox textBox_name;
        private TextBox textBox_subheading;
        private TextBox textBox_imgpath;
        private TextBox textBox_link;
        private RichTextBox rtb_description;
        private ListBox listBox_compatibility;
        private Button button_imgpath;
        private TextBox textBox_compatibility;
        private Button button_compat_add;
        private Button button_compat_remove;
        private Button button_saveclose;
        private Button button_save;
        private Button button_exit;
        private Label label_filename;
        private TextBox textBox_filename;
        private Label label_json;
        private Button button_moveup;
        private Button button_movedown;
    }
}