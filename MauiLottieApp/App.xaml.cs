namespace MauiLottieApp;

public partial class App : Application
{
	public App(MainPage mainPage)
	{
		InitializeComponent();

		//MainPage = new NavigationPage(new MainPage()); //Valid

        MainPage = new NavigationPage(mainPage); //Invalid
    }
}
