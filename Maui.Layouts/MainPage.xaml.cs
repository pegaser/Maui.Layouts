namespace Maui.Layouts;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        this.btn.Clicked += Btn_Clicked;
	}

    private void Btn_Clicked(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}

