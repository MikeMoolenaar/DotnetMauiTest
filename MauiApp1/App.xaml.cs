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
	}
}
