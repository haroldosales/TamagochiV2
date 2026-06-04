namespace Tamagochi
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object? sender, EventArgs e)
        {
            string? name = NameEntry.Text;



            // Show a quick confirmation and navigate to the Lista page
            await Navigation.PushAsync(new Lista());
        }

        private async void OnCounterClicked2(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new Escolhar());
        }

    }
}
