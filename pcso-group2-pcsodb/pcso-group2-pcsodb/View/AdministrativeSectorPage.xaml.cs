using pcso_group2_pcsodb.ViewModel;

namespace pcso_group2_pcsodb.View;

public partial class AdministrativeSectorPage : ContentPage
{
    public AdministrativeSectorPage(AdministrativeSectorViewModel administrativeSectorViewModel)
    {
        InitializeComponent();
        // instead of doing new LoginViewModel
        // I can resolve it in constructor because I did register
        BindingContext = administrativeSectorViewModel;
    }
}