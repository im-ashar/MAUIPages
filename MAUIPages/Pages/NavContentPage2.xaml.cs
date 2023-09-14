namespace MAUIPages.Pages;

public partial class NavContentPage2 : ContentPage
{
    public NavContentPage2()
    {
        InitializeComponent();
    }

    private async void btnBack_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}