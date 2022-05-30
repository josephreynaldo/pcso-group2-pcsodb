using pcso_group2_pcsodb.ViewModel;

namespace pcso_group2_pcsodb.View;

public partial class HomePage : ContentPage
{
      

    public HomePage(HomeViewModel homeViewModel)
    {
        InitializeComponent();
        BindingContext = homeViewModel;
    }
}