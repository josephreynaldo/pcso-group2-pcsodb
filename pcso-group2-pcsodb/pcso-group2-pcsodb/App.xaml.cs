namespace pcso_group2_pcsodb;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new AppShell();
        Shell.Current.GoToAsync("//Home");
    }
}
