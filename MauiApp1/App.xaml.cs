namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		Init();
	}

	public void Init()
    {
		MainPage = new TabsPage();

		// There's no other way to set the window size on Windows at the moment. 
		// A better method is comming with https://github.com/dotnet/maui/pull/4942.
#if WINDOWS
		MainPage.WidthRequest = 450;
		MainPage.HeightRequest = 800;
#endif
	}
}
