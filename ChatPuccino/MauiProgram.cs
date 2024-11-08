using ChatPuccino.ViewModels;
using ChatPuccino.Views;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace ChatPuccino;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseSkiaSharp()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("CoffeeDreamDemoRegular.ttf", "CoffeeDream");
            })
            .ConfigureMauiHandlers(handlers =>
            {
                #if ANDROID
                handlers.AddHandler(typeof(Shell), typeof(Platforms.Android.CommandBadgeRenderer));
                #endif
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<AppShell>();

        builder.Services.AddSingleton<LandingViewModel>();
        builder.Services.AddSingleton<MenuViewModel>();
        builder.Services.AddSingleton<TableViewModel>();
        builder.Services.AddSingleton<CatsViewModel>();
        builder.Services.AddSingleton<AboutViewModel>();

        builder.Services.AddSingleton<LandingPage>();
        builder.Services.AddSingleton<MenuPage>();
        builder.Services.AddSingleton<TablePage>();
        builder.Services.AddSingleton<CatsPage>();
        builder.Services.AddSingleton<AboutPage>();

        return builder.Build();
    }
}
