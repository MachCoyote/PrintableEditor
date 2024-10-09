namespace PrintableEditor
{
    partial class CategoryEditor
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
            lbl_foldername = new Label();
            tb_foldername = new TextBox();
            lbl_catname = new Label();
            tb_catname = new TextBox();
            button_save = new Button();
            button_saveexit = new Button();
            button_exit = new Button();
            SuspendLayout();
            // 
            // lbl_foldername
            // 
            lbl_foldername.AutoSize = true;
            lbl_foldername.Location = new Point(12, 9);
            lbl_foldername.Name = "lbl_foldername";
            lbl_foldername.Size = new Size(129, 15);
            lbl_foldername.TabIndex = 0;
            lbl_foldername.Text = "Category Folder Name:";
            // 
            // tb_foldername
            // 
            tb_foldername.Location = new Point(12, 27);
            tb_foldername.Name = "tb_foldername";
            tb_foldername.Size = new Size(434, 23);
            tb_foldername.TabIndex = 1;
            // 
            // lbl_catname
            // 
            lbl_catname.AutoSize = true;
            lbl_catname.Location = new Point(12, 67);
            lbl_catname.Name = "lbl_catname";
            lbl_catname.Size = new Size(134, 15);
            lbl_catname.TabIndex = 2;
            lbl_catname.Text = "Category Display Name:";
            // 
            // tb_catname
            // 
            tb_catname.Location = new Point(12, 85);
            tb_catname.Name = "tb_catname";
            tb_catname.Size = new Size(434, 23);
            tb_catname.TabIndex = 3;
            // 
            // button_save
            // 
            button_save.Location = new Point(12, 132);
            button_save.Name = "button_save";
            button_save.Size = new Size(75, 23);
            button_save.TabIndex = 4;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_saveexit
            // 
            button_saveexit.Location = new Point(93, 132);
            button_saveexit.Name = "button_saveexit";
            button_saveexit.Size = new Size(87, 23);
            button_saveexit.TabIndex = 5;
            button_saveexit.Text = "Save And Exit";
            button_saveexit.UseVisualStyleBackColor = true;
            button_saveexit.Click += button_saveexit_Click;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(186, 132);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(120, 23);
            button_exit.TabIndex = 6;
            button_exit.Text = "Exit Without Saving";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // CategoryEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 167);
            Controls.Add(button_exit);
            Controls.Add(button_saveexit);
            Controls.Add(button_save);
            Controls.Add(tb_catname);
            Controls.Add(lbl_catname);
            Controls.Add(tb_foldername);
            Controls.Add(lbl_foldername);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CategoryEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryEditor";
            FormClosing += ShowParent;
            Load += CategoryEditor_Load;
            KeyDown += SaveKeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_foldername;
        private TextBox tb_foldername;
        private Label lbl_catname;
        private TextBox tb_catname;
        private Button button_save;
        private Button button_saveexit;
        private Button button_exit;
    }
}