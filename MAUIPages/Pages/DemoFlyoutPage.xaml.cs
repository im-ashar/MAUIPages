namespace MAUIPages.Pages;

public partial class DemoFlyoutPage : FlyoutPage
{
    public DemoFlyoutPage()
    {
        InitializeComponent();
    }

    private void btnOpenNavPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new NavigationPage(new NavContentPage()));
    }
}