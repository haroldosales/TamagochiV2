using System;
using System.Threading.Tasks;

namespace Tamagochi
{
    public partial class MainPage : ContentPage
    {
        public string nome { get; set; }


        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            _ = PromptForNameAsync();

        }

        private async Task PromptForNameAsync()
        {
            var result = await Application.Current.MainPage.DisplayPromptAsync(
                "Digite seu nome",
                "Por favor, insira seu nome:");

            if (!string.IsNullOrWhiteSpace(result))
                nome = result;
            else
                nome = "Usuário";

            OnPropertyChanged(nameof(nome));
        }

        private async void OnCounterClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lista());
        }

        private async void OnCounterClicked2(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new Escolhar());
        }
    }
}
