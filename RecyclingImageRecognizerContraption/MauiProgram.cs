using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RecyclingImageRecognizerContraption.Resources.DatabaseService;
namespace RecyclingImageRecognizerContraption
{
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
                });

            //database setup
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "LaPorte.db3");
            builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<LaPorteService>(s, dbPath));

            builder.Services.AddMauiBlazorWebView();

            builder.Services.AddLogging();
            builder.Services.AddSingleton(MediaPicker.Default);

            
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();


            var app = builder.Build();




#if DEBUG
            

#endif

            return builder.Build();
        }
    }
}
