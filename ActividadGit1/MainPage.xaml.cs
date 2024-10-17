namespace ActividadGit1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_Caballo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Caballo());
        }
    }

}
