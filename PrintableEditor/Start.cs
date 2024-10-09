namespace PrintableEditor
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductsList productsList = new ProductsList(this);
            productsList.Show();
            this.Hide();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void button_guides_Click(object sender, EventArgs e)
        {
            GuideList guideList = new GuideList(this);
            guideList.Show();
            this.Hide();
        }
    }
}
