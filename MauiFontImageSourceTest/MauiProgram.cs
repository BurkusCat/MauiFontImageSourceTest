using Microsoft.Extensions.Logging;
using System.Reflection;

namespace MauiFontImageSourceTest;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        Assembly assembly = Assembly.GetExecutingAssembly()!;

        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddEmbeddedResourceFont(assembly, "ionicons.ttf", "ionicons");
                fonts.AddEmbeddedResourceFont(assembly, "OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddEmbeddedResourceFont(assembly, "OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
