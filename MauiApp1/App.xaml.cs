namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
#if WINDOWS
		if (App.Current.UserAppTheme == AppTheme.Unspecified)
			App.Current.UserAppTheme = AppTheme.Light;
#endif
		MainPage = new MainPage();
	}
}
