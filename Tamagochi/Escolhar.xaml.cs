
namespace Tamagochi;

public partial class Escolhar : ContentPage
{
	public Escolhar()
	{
		InitializeComponent();
	}


	private  async void OnPokemonClickedd(object sender, EventArgs e)
    {
        string Name = NamePok.Text;
        ResultEditor.Text = string.Empty;

         if(Name != null && !string.IsNullOrWhiteSpace(Name)  )
    {   
    Service Escolhar = new Service();
    var result = await Escolhar.dadosPork(Name).ConfigureAwait(false);
    // Update UI on main thread
    Microsoft.Maui.ApplicationModel.MainThread.BeginInvokeOnMainThread(() =>
        {
            ResultEditor.Text = result;
        });
    } else {

            await Application.Current.MainPage.DisplayPromptAsync(
                  "Error",
                  "Por favor, insira seu nome:");

        }
    
    }
}