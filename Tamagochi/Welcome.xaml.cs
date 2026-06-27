
namespace Tamagochi
{
    public partial class Welcome : ContentPage
    {



        public Welcome()
        {
            InitializeComponent();



        }
        private async void OnCounterClicked(object? sender, EventArgs e)

        {
            string nome = await Application.Current.MainPage.DisplayPromptAsync(
                "Digite seu nome",
                "Por favor, insira seu nome:");

            await Navigation.PushAsync(new MainPage());








        }

    }
}
