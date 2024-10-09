namespace PrintableEditor
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            pictureBox1 = new PictureBox();
            button_product = new Button();
            button_guides = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(365, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button_product
            // 
            button_product.Location = new Point(12, 106);
            button_product.Name = "button_product";
            button_product.Size = new Size(162, 68);
            button_product.TabIndex = 1;
            button_product.Text = "Products";
            button_product.UseVisualStyleBackColor = true;
            button_product.Click += button1_Click;
            // 
            // button_guides
            // 
            button_guides.Location = new Point(12, 180);
            button_guides.Name = "button_guides";
            button_guides.Size = new Size(162, 68);
            button_guides.TabIndex = 2;
            button_guides.Text = "Guides";
            button_guides.UseVisualStyleBackColor = true;
            button_guides.Click += button_guides_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 480);
            Controls.Add(button_guides);
            Controls.Add(button_product);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrintableEditor";
            Load += Start_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button_product;
        private Button button_guides;
    }
}
