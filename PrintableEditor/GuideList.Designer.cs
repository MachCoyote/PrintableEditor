namespace PrintableEditor
{
    partial class GuideList
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
            lbl_categories = new Label();
            lb_categories = new ListBox();
            button_cat_new = new Button();
            button_cat_edit = new Button();
            button_cat_delete = new Button();
            lbl_guides = new Label();
            lb_guides = new ListBox();
            button_guide_new = new Button();
            button_guide_edit = new Button();
            button_guide_delete = new Button();
            SuspendLayout();
            // 
            // lbl_categories
            // 
            lbl_categories.AutoSize = true;
            lbl_categories.Location = new Point(12, 9);
            lbl_categories.Name = "lbl_categories";
            lbl_categories.Size = new Size(97, 15);
            lbl_categories.TabIndex = 0;
            lbl_categories.Text = "Guide Categories";
            // 
            // lb_categories
            // 
            lb_categories.FormattingEnabled = true;
            lb_categories.ItemHeight = 15;
            lb_categories.Location = new Point(12, 27);
            lb_categories.Name = "lb_categories";
            lb_categories.Size = new Size(438, 214);
            lb_categories.TabIndex = 1;
            lb_categories.SelectedIndexChanged += lb_categories_SelectedIndexChanged;
            // 
            // button_cat_new
            // 
            button_cat_new.Location = new Point(12, 247);
            button_cat_new.Name = "button_cat_new";
            button_cat_new.Size = new Size(75, 23);
            button_cat_new.TabIndex = 2;
            button_cat_new.Text = "New";
            button_cat_new.UseVisualStyleBackColor = true;
            button_cat_new.Click += button_cat_new_Click;
            // 
            // button_cat_edit
            // 
            button_cat_edit.Location = new Point(93, 247);
            button_cat_edit.Name = "button_cat_edit";
            button_cat_edit.Size = new Size(75, 23);
            button_cat_edit.TabIndex = 3;
            button_cat_edit.Text = "Edit";
            button_cat_edit.UseVisualStyleBackColor = true;
            button_cat_edit.Click += button_cat_edit_Click;
            // 
            // button_cat_delete
            // 
            button_cat_delete.Location = new Point(174, 247);
            button_cat_delete.Name = "button_cat_delete";
            button_cat_delete.Size = new Size(75, 23);
            button_cat_delete.TabIndex = 4;
            button_cat_delete.Text = "Delete";
            button_cat_delete.UseVisualStyleBackColor = true;
            button_cat_delete.Click += button_cat_delete_Click;
            // 
            // lbl_guides
            // 
            lbl_guides.AutoSize = true;
            lbl_guides.Location = new Point(12, 290);
            lbl_guides.Name = "lbl_guides";
            lbl_guides.Size = new Size(139, 15);
            lbl_guides.TabIndex = 5;
            lbl_guides.Text = "Guides in CategoryName";
            // 
            // lb_guides
            // 
            lb_guides.FormattingEnabled = true;
            lb_guides.ItemHeight = 15;
            lb_guides.Location = new Point(12, 308);
            lb_guides.Name = "lb_guides";
            lb_guides.Size = new Size(438, 214);
            lb_guides.TabIndex = 6;
            // 
            // button_guide_new
            // 
            button_guide_new.Location = new Point(12, 528);
            button_guide_new.Name = "button_guide_new";
            button_guide_new.Size = new Size(75, 23);
            button_guide_new.TabIndex = 7;
            button_guide_new.Text = "New";
            button_guide_new.UseVisualStyleBackColor = true;
            button_guide_new.Click += button_guide_new_Click;
            // 
            // button_guide_edit
            // 
            button_guide_edit.Location = new Point(93, 528);
            button_guide_edit.Name = "button_guide_edit";
            button_guide_edit.Size = new Size(75, 23);
            button_guide_edit.TabIndex = 8;
            button_guide_edit.Text = "Edit";
            button_guide_edit.UseVisualStyleBackColor = true;
            button_guide_edit.Click += button_guide_edit_Click;
            // 
            // button_guide_delete
            // 
            button_guide_delete.Location = new Point(174, 528);
            button_guide_delete.Name = "button_guide_delete";
            button_guide_delete.Size = new Size(75, 23);
            button_guide_delete.TabIndex = 9;
            button_guide_delete.Text = "Delete";
            button_guide_delete.UseVisualStyleBackColor = true;
            button_guide_delete.Click += button_guide_delete_Click;
            // 
            // GuideList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 561);
            Controls.Add(button_guide_delete);
            Controls.Add(button_guide_edit);
            Controls.Add(button_guide_new);
            Controls.Add(lb_guides);
            Controls.Add(lbl_guides);
            Controls.Add(button_cat_delete);
            Controls.Add(button_cat_edit);
            Controls.Add(button_cat_new);
            Controls.Add(lb_categories);
            Controls.Add(lbl_categories);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "GuideList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuideList";
            FormClosing += ShowParent;
            Load += GuideList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_categories;
        private ListBox lb_categories;
        private Button button_cat_new;
        private Button button_cat_edit;
        private Button button_cat_delete;
        private Label lbl_guides;
        private ListBox lb_guides;
        private Button button_guide_new;
        private Button button_guide_edit;
        private Button button_guide_delete;
    }
}