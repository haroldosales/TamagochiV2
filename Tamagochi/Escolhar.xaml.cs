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
        Service Escolhar = new Service();
        var result = await Escolhar.dadosPork(Name).ConfigureAwait(false);
        // Update UI on main thread
        Microsoft.Maui.ApplicationModel.MainThread.BeginInvokeOnMainThread(() =>
        {
            ResultEditor.Text = result;
        });
    }
}