namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ViewModel.OrderInfoCollection.Clear();
            ViewModel.ChangeCollection();
        }
    }

}
