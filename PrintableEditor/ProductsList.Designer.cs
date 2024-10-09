namespace PrintableEditor
{
    partial class ProductsList
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
            Products = new ListBox();
            label1 = new Label();
            button_new = new Button();
            button_delete = new Button();
            button_edit = new Button();
            SuspendLayout();
            // 
            // Products
            // 
            Products.FormattingEnabled = true;
            Products.ItemHeight = 15;
            Products.Location = new Point(12, 27);
            Products.Name = "Products";
            Products.Size = new Size(237, 364);
            Products.TabIndex = 0;
            Products.SelectedIndexChanged += Products_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Products";
            // 
            // button_new
            // 
            button_new.Location = new Point(12, 397);
            button_new.Name = "button_new";
            button_new.Size = new Size(75, 23);
            button_new.TabIndex = 2;
            button_new.Text = "New";
            button_new.UseVisualStyleBackColor = true;
            button_new.Click += button_new_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(174, 397);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(75, 23);
            button_delete.TabIndex = 3;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button2_Click;
            // 
            // button_edit
            // 
            button_edit.Location = new Point(93, 397);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(75, 23);
            button_edit.TabIndex = 4;
            button_edit.Text = "Edit";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // ProductsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 450);
            Controls.Add(button_edit);
            Controls.Add(button_delete);
            Controls.Add(button_new);
            Controls.Add(label1);
            Controls.Add(Products);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProductsList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductsList";
            FormClosing += ShowParent;
            Load += ProductsList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Products;
        private Label label1;
        private Button button_new;
        private Button button_delete;
        private Button button_edit;
    }
}