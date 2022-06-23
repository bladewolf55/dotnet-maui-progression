using Maui.Progression.ViewModels;

namespace Maui.Progression;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new Counter();
	}
}

