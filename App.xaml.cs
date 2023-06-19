using MauiVerter.MVVM.Views;

namespace MauiVerter;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MenuView());
		//MainPage = new ConverterView();
	}
}
