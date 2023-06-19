# Maui Unit Convert App

![UnitConverter](https://github.com/salisou/MauiVerter.App/blob/master/Images/MenuConvertter.PNG?raw=true)
![UnitConverter](https://github.com/salisou/MauiVerter.App/blob/master/Images/typeConverter.PNG?raw=true)

## PackageReference
- PropertyChanged.Fody
- UnitsNet

## Font 
- fontello.ttf

## Configuration font into MauiProgram


        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                  fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                  fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                  fonts.AddFont("fontello.ttf", "Icons");
                });

    #if DEBUG
        builder.Logging.AddDebug();
    #endif

        return builder.Build();
      }

