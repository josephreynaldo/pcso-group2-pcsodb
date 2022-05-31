namespace pcso_group2_pcsodb.ViewModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

    public partial class ManagementSectorViewModel : BaseViewModel
{
    [ICommand]
    public void GoToHome()
    {
        Shell.Current.GoToAsync("//Home");
    }
    [ICommand]
    public void GoToDepartmentA()
    {
        Shell.Current.GoToAsync("//ManagementDeptA");
    }
    [ICommand]
    public void GoToDepartmentB()
    {
        Shell.Current.GoToAsync("//ManagementDeptB");
    }
}