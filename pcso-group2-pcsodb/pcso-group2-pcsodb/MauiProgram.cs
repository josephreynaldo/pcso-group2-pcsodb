namespace pcso_group2_pcsodb;


using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Markup;


using pcso_group2_pcsodb.Services;
using pcso_group2_pcsodb.View;
using pcso_group2_pcsodb.ViewModel;




public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()

           .UseMauiCommunityToolkit()
           .UseMauiCommunityToolkitMarkup()
           .UseMauiCommunityToolkitCore()


            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});



        builder.Services.AddSingleton<DepartmentService>();
        

        builder.Services.AddSingleton<HomeViewModel>();
        builder.Services.AddSingleton<HomePage>();


        builder.Services.AddSingleton<CharitySectorViewModel>();
        builder.Services.AddSingleton<CharitySectorPage>();

        builder.Services.AddSingleton<AdministrativeSectorViewModel>();
        builder.Services.AddSingleton<AdministrativeSectorPage>();

        builder.Services.AddSingleton<BranchOperationSectorViewModel>();
        builder.Services.AddSingleton<BranchOperationSectorPage>();

        builder.Services.AddSingleton<ManagementSectorViewModel>();
        builder.Services.AddSingleton<ManagementSectorPage>();

        builder.Services.AddSingleton<GamingSectorViewModel>();
        builder.Services.AddSingleton<GamingSectorPage>();


        return builder.Build();
	}
}
