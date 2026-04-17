using Flavor.Maui.Demo.Pages;

namespace Flavor.Maui.Demo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
#if MACCATALYST
		return new Window(new MacMainPage());
#else
		return new Window(new AppShell());
#endif
	}
}