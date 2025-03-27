using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RecyclingImageRecognizerContraption.Components.Data;

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

            builder.Services.AddMauiBlazorWebView();

            builder.Services.AddLogging();
            builder.Services.AddSingleton(MediaPicker.Default);

            builder.Services.AddSingleton<AppDbContext>();

            var app = builder.Build();

            //android db check
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                db.InitializeDatabase().Wait();
            }

            //string dbPath = Path.Combine(FileSystem.AppDataDirectory, "recycle.db");
            //builder.Services.AddDbContext<AppDbContext>(options =>
            //    options.UseSqlite($"Data Source={dbPath}"));


#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
            
#endif

            return builder.Build();
        }
    }
}
