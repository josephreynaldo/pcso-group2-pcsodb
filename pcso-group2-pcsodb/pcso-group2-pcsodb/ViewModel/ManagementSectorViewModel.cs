namespace pcso_group2_pcsodb.ViewModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

    public partial class ManagementSectorViewModel : BaseViewModel
{
    [ObservableProperty]
    private string username;

    [ICommand]
    public void GoToHome()
    {
        Shell.Current.GoToAsync("//Home");
    }
}