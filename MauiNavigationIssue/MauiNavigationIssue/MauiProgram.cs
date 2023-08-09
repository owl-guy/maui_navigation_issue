using Microsoft.Extensions.Logging;

namespace MauiNavigationIssue;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.RegisterRoutes();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

	public static MauiAppBuilder RegisterRoutes(this MauiAppBuilder builder)
	{
		Routing.RegisterRoute(nameof(TestPageOne), typeof(TestPageOne));

		return builder;
	}
}
