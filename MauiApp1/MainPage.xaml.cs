namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public bool IsDarkMode => App.Current.UserAppTheme == AppTheme.Dark;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		CounterLabel.Text = $"Current count: {count}";

		SemanticScreenReader.Announce(CounterLabel.Text);
	}

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
		App.Current.UserAppTheme = e.Value ? AppTheme.Dark : AppTheme.Light;
	}
}

