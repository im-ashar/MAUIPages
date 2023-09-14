using MAUIPages.Pages;

namespace MAUIPages;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        //MainPage = new DemoContentPage();
        //MainPage = new NavigationPage(new NavContentPage());
        //MainPage = new DemoFlyoutPage();
        MainPage = new DemoTabbedPage();
    }
}
