using pcso_group2_pcsodb.ViewModel;

namespace pcso_group2_pcsodb.View;

public partial class ManagementSectorPage : ContentPage
{
    public ManagementSectorPage(ManagementSectorViewModel managementSectorViewModel)
    {
        InitializeComponent();
        // instead of doing new LoginViewModel
        // I can resolve it in constructor because I did register
        BindingContext = managementSectorViewModel;
    }
}