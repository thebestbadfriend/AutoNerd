namespace AutoNerdUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            populatelbo();
        }

        private void populatelbo()
        {
            lboPCInfo.Items.Add("something");
            lboPCInfo.Items.Add("another thing");
        }
    }
}