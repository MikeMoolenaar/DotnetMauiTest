using System.Globalization;

namespace MauiApp1.Views;

public partial class Settings : ContentPage
{
	public bool viewReady = false;
	public Settings()
	{
		InitializeComponent();
		PickerTheme.SelectedIndex = (int)App.Current.UserAppTheme;
		PickerLang.SelectedIndex = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "en" ? 0 : 1;
		viewReady = true;
	}

	private void Picker_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!viewReady) return;

		int index = ((Picker)sender).SelectedIndex;
		App.Current.UserAppTheme = index switch
		{
			0 => AppTheme.Unspecified,
			1 => AppTheme.Dark,
			_ => AppTheme.Light
		};
	}

    private void PickerLang_SelectedIndexChanged(object sender, EventArgs e)
    {
		if (!viewReady) return;

		int index = ((Picker)sender).SelectedIndex;
		string lang = index == 0 ? "en-US" : "nl-NL";
		// Get current language
		// Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;

		Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
		Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);

		(App.Current as App).Init();
	}
}