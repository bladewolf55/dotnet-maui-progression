using Maui.Progression.ViewModels;

namespace Maui.Progression;

public partial class MainPage : ContentPage
{
	public MainPage(Counter viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

