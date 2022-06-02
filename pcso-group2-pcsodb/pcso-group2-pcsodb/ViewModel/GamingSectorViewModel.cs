namespace pcso_group2_pcsodb.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using pcso_group2_pcsodb.Model;
using pcso_group2_pcsodb.Services;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.Json;

    public partial class GamingSectorViewModel : BaseViewModel
{
    [ObservableProperty]
    private string username;

    [ICommand]
    public void GoToHome()
    {
        Shell.Current.GoToAsync("//Home");
    }

    [ICommand]
    public void GoToDepartmentA()
    {
        Shell.Current.GoToAsync("//GamingDeptA");
    }
    [ICommand]
    public void GoToDepartmentB()
    {
        Shell.Current.GoToAsync("//GamingDeptB");
    }
 
}