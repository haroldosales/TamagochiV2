namespace Tamagochi
{
    public partial class Lista : ContentPage
    {
        Service Escolhar = new Service();
        Pokemon pok = new Pokemon();
        
        public Lista()
        {
           
            InitializeComponent();

        }

       

        private async void OnPokemonClicked(object sender, EventArgs e)
        {
            ResultEditor.Text = string.Empty;

            for (int i = 1; i <= 30; i++)
            {
                pok.name = i.ToString();
                var result = await Escolhar.OneOne(pok.name).ConfigureAwait(false);

                // Update UI on main thread
                Microsoft.Maui.ApplicationModel.MainThread.BeginInvokeOnMainThread(() =>
                {
                    ResultEditor.Text += result + "\r\n";
                });
            }
        }
    }
}