namespace PrintableEditor
{
    partial class GuideEditor
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
            label_json = new Label();
            textBox_filename = new TextBox();
            label_filename = new Label();
            button_imgpath = new Button();
            textBox_imgpath = new TextBox();
            label_imgpath = new Label();
            rtb_description = new RichTextBox();
            label_description = new Label();
            textBox_name = new TextBox();
            label_name = new Label();
            label_steps = new Label();
            lb_steps = new ListBox();
            tb_stephead = new TextBox();
            label_steaphead = new Label();
            tb_stepimg = new TextBox();
            label_stepimg = new Label();
            rtb_stepdesc = new RichTextBox();
            label_stepdesc = new Label();
            label_separator = new Label();
            button_stepimg = new Button();
            button_addstep = new Button();
            button_removestep = new Button();
            button_stepup = new Button();
            button_stepdown = new Button();
            button_savestep = new Button();
            button_save = new Button();
            button_saveexit = new Button();
            button_exit = new Button();
            SuspendLayout();
            // 
            // label_json
            // 
            label_json.AutoSize = true;
            label_json.Location = new Point(568, 9);
            label_json.Name = "label_json";
            label_json.Size = new Size(32, 15);
            label_json.TabIndex = 27;
            label_json.Text = ".json";
            // 
            // textBox_filename
            // 
            textBox_filename.Location = new Point(140, 6);
            textBox_filename.Name = "textBox_filename";
            textBox_filename.Size = new Size(422, 23);
            textBox_filename.TabIndex = 26;
            textBox_filename.TextAlign = HorizontalAlignment.Right;
            // 
            // label_filename
            // 
            label_filename.AutoSize = true;
            label_filename.Location = new Point(12, 9);
            label_filename.Name = "label_filename";
            label_filename.Size = new Size(58, 15);
            label_filename.TabIndex = 25;
            label_filename.Text = "Filename:";
            // 
            // button_imgpath
            // 
            button_imgpath.Location = new Point(557, 64);
            button_imgpath.Name = "button_imgpath";
            button_imgpath.Size = new Size(43, 23);
            button_imgpath.TabIndex = 24;
            button_imgpath.Text = "...";
            button_imgpath.UseVisualStyleBackColor = true;
            button_imgpath.Click += button_imgpath_Click;
            // 
            // textBox_imgpath
            // 
            textBox_imgpath.Location = new Point(140, 64);
            textBox_imgpath.Name = "textBox_imgpath";
            textBox_imgpath.Size = new Size(411, 23);
            textBox_imgpath.TabIndex = 23;
            // 
            // label_imgpath
            // 
            label_imgpath.AutoSize = true;
            label_imgpath.Location = new Point(12, 67);
            label_imgpath.Name = "label_imgpath";
            label_imgpath.Size = new Size(70, 15);
            label_imgpath.TabIndex = 22;
            label_imgpath.Text = "Image Path:";
            // 
            // rtb_description
            // 
            rtb_description.Location = new Point(140, 93);
            rtb_description.Name = "rtb_description";
            rtb_description.Size = new Size(460, 224);
            rtb_description.TabIndex = 29;
            rtb_description.Text = "";
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Location = new Point(12, 96);
            label_description.Name = "label_description";
            label_description.Size = new Size(70, 15);
            label_description.TabIndex = 28;
            label_description.Text = "Description:";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(140, 35);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(460, 23);
            textBox_name.TabIndex = 31;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(12, 38);
            label_name.Name = "label_name";
            label_name.Size = new Size(42, 15);
            label_name.TabIndex = 30;
            label_name.Text = "Name:";
            // 
            // label_steps
            // 
            label_steps.AutoSize = true;
            label_steps.Location = new Point(12, 372);
            label_steps.Name = "label_steps";
            label_steps.Size = new Size(38, 15);
            label_steps.TabIndex = 32;
            label_steps.Text = "Steps:";
            // 
            // lb_steps
            // 
            lb_steps.FormattingEnabled = true;
            lb_steps.ItemHeight = 15;
            lb_steps.Location = new Point(140, 363);
            lb_steps.Name = "lb_steps";
            lb_steps.Size = new Size(460, 214);
            lb_steps.TabIndex = 33;
            lb_steps.SelectedIndexChanged += lb_steps_SelectedIndexChanged;
            // 
            // tb_stephead
            // 
            tb_stephead.Location = new Point(140, 605);
            tb_stephead.Name = "tb_stephead";
            tb_stephead.Size = new Size(460, 23);
            tb_stephead.TabIndex = 35;
            // 
            // label_steaphead
            // 
            label_steaphead.AutoSize = true;
            label_steaphead.Location = new Point(12, 608);
            label_steaphead.Name = "label_steaphead";
            label_steaphead.Size = new Size(81, 15);
            label_steaphead.TabIndex = 34;
            label_steaphead.Text = "Step Heading:";
            // 
            // tb_stepimg
            // 
            tb_stepimg.Location = new Point(140, 634);
            tb_stepimg.Name = "tb_stepimg";
            tb_stepimg.Size = new Size(411, 23);
            tb_stepimg.TabIndex = 37;
            // 
            // label_stepimg
            // 
            label_stepimg.AutoSize = true;
            label_stepimg.Location = new Point(12, 637);
            label_stepimg.Name = "label_stepimg";
            label_stepimg.Size = new Size(96, 15);
            label_stepimg.TabIndex = 36;
            label_stepimg.Text = "Step Image Path:";
            // 
            // rtb_stepdesc
            // 
            rtb_stepdesc.Location = new Point(140, 666);
            rtb_stepdesc.Name = "rtb_stepdesc";
            rtb_stepdesc.Size = new Size(460, 246);
            rtb_stepdesc.TabIndex = 40;
            rtb_stepdesc.Text = "";
            // 
            // label_stepdesc
            // 
            label_stepdesc.AutoSize = true;
            label_stepdesc.Location = new Point(12, 666);
            label_stepdesc.Name = "label_stepdesc";
            label_stepdesc.Size = new Size(96, 15);
            label_stepdesc.TabIndex = 39;
            label_stepdesc.Text = "Step Description:";
            // 
            // label_separator
            // 
            label_separator.AutoSize = true;
            label_separator.Location = new Point(12, 335);
            label_separator.Name = "label_separator";
            label_separator.Size = new Size(597, 15);
            label_separator.TabIndex = 41;
            label_separator.Text = "----------------------------------------------------------------------------------------------------------------------\r\n";
            // 
            // button_stepimg
            // 
            button_stepimg.Location = new Point(557, 634);
            button_stepimg.Name = "button_stepimg";
            button_stepimg.Size = new Size(43, 23);
            button_stepimg.TabIndex = 42;
            button_stepimg.Text = "...";
            button_stepimg.UseVisualStyleBackColor = true;
            button_stepimg.Click += button_stepimg_Click;
            // 
            // button_addstep
            // 
            button_addstep.Location = new Point(12, 390);
            button_addstep.Name = "button_addstep";
            button_addstep.Size = new Size(122, 23);
            button_addstep.TabIndex = 43;
            button_addstep.Text = "Add";
            button_addstep.UseVisualStyleBackColor = true;
            button_addstep.Click += button_addstep_Click;
            // 
            // button_removestep
            // 
            button_removestep.Location = new Point(12, 419);
            button_removestep.Name = "button_removestep";
            button_removestep.Size = new Size(122, 23);
            button_removestep.TabIndex = 44;
            button_removestep.Text = "Remove";
            button_removestep.UseVisualStyleBackColor = true;
            button_removestep.Click += button_removestep_Click;
            // 
            // button_stepup
            // 
            button_stepup.Location = new Point(12, 448);
            button_stepup.Name = "button_stepup";
            button_stepup.Size = new Size(58, 23);
            button_stepup.TabIndex = 45;
            button_stepup.Text = "/\\";
            button_stepup.UseVisualStyleBackColor = true;
            button_stepup.Click += button_stepup_Click;
            // 
            // button_stepdown
            // 
            button_stepdown.Location = new Point(76, 448);
            button_stepdown.Name = "button_stepdown";
            button_stepdown.RightToLeft = RightToLeft.No;
            button_stepdown.Size = new Size(58, 23);
            button_stepdown.TabIndex = 46;
            button_stepdown.Text = "\\/";
            button_stepdown.UseVisualStyleBackColor = true;
            button_stepdown.Click += button_stepdown_Click;
            // 
            // button_savestep
            // 
            button_savestep.Location = new Point(12, 694);
            button_savestep.Name = "button_savestep";
            button_savestep.Size = new Size(112, 60);
            button_savestep.TabIndex = 47;
            button_savestep.Text = "Save Step";
            button_savestep.UseVisualStyleBackColor = true;
            button_savestep.Click += button_savestep_Click;
            // 
            // button_save
            // 
            button_save.Location = new Point(76, 928);
            button_save.Name = "button_save";
            button_save.Size = new Size(112, 60);
            button_save.TabIndex = 48;
            button_save.Text = "Save";
            button_save.TextImageRelation = TextImageRelation.TextAboveImage;
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_saveexit
            // 
            button_saveexit.Location = new Point(246, 928);
            button_saveexit.Name = "button_saveexit";
            button_saveexit.Size = new Size(112, 60);
            button_saveexit.TabIndex = 49;
            button_saveexit.Text = "Save And Exit";
            button_saveexit.UseVisualStyleBackColor = true;
            button_saveexit.Click += button_saveexit_Click;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(415, 928);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(112, 60);
            button_exit.TabIndex = 50;
            button_exit.Text = "Exit Without Saving";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // GuideEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 1000);
            Controls.Add(button_exit);
            Controls.Add(button_saveexit);
            Controls.Add(button_save);
            Controls.Add(button_savestep);
            Controls.Add(button_stepdown);
            Controls.Add(button_stepup);
            Controls.Add(button_removestep);
            Controls.Add(button_addstep);
            Controls.Add(button_stepimg);
            Controls.Add(label_separator);
            Controls.Add(rtb_stepdesc);
            Controls.Add(label_stepdesc);
            Controls.Add(tb_stepimg);
            Controls.Add(label_stepimg);
            Controls.Add(tb_stephead);
            Controls.Add(label_steaphead);
            Controls.Add(lb_steps);
            Controls.Add(label_steps);
            Controls.Add(textBox_name);
            Controls.Add(label_name);
            Controls.Add(rtb_description);
            Controls.Add(label_description);
            Controls.Add(label_json);
            Controls.Add(textBox_filename);
            Controls.Add(label_filename);
            Controls.Add(button_imgpath);
            Controls.Add(textBox_imgpath);
            Controls.Add(label_imgpath);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "GuideEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuideEditor";
            FormClosing += ShowParent;
            Load += GuideEditor_Load;
            KeyDown += SaveKeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_json;
        private TextBox textBox_filename;
        private Label label_filename;
        private Button button_imgpath;
        private TextBox textBox_imgpath;
        private Label label_imgpath;
        private RichTextBox rtb_description;
        private Label label_description;
        private TextBox textBox_name;
        private Label label_name;
        private Label label_steps;
        private ListBox lb_steps;
        private TextBox tb_stephead;
        private Label label_steaphead;
        private TextBox tb_stepimg;
        private Label label_stepimg;
        private RichTextBox rtb_stepdesc;
        private Label label_stepdesc;
        private Label label_separator;
        private Button button_stepimg;
        private Button button_addstep;
        private Button button_removestep;
        private Button button_stepup;
        private Button button_stepdown;
        private Button button_savestep;
        private Button button_save;
        private Button button_saveexit;
        private Button button_exit;
    }
}