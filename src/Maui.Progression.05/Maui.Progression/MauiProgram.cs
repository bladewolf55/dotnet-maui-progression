using Maui.Progression.DomainServices;
using Maui.Progression.DomainServices.Interfaces;
using Maui.Progression.ViewModels;
using Maui.Progression.Views;

namespace Maui.Progression;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("AbrilFatface-Regular.ttf", "AbrilFatface");
			});

		builder.Services.AddSingleton<INumberMapper>(new NumberMapper());
		builder.Services.AddSingleton<Counter>();
		builder.Services.AddSingleton<MainPage>();

        return builder.Build();
	}
}
