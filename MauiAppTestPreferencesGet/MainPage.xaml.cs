namespace MauiAppTestPreferencesGet;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        string cTestPreference = Preferences.Get("SettingTest", "Preference OK");

		if (cTestPreference == null)
		{
            TestLabel.Text = "Preference = null";
        }
		else
		{
            TestLabel.Text = cTestPreference;
        }
    }
}

