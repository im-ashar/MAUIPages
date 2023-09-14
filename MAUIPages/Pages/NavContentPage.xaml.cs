namespace MAUIPages.Pages;

public partial class NavContentPage : ContentPage
{
	public NavContentPage()
	{
		InitializeComponent();
	}

    private void btnOpenNavPage2_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new NavContentPage2());
    }
}