using Maui.Progression.ViewModels;

namespace Maui.Progression.Views;

public partial class MainPage : ContentPage
{
	public MainPage(Counter viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

