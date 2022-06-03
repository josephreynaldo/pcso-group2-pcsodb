

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;


using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.Json;

using pcso_group2_pcsodb.View;
using pcso_group2_pcsodb.Services;
using pcso_group2_pcsodb.Model;
namespace pcso_group2_pcsodb.ViewModel;


public partial class AdministrativeSectorViewModel : BaseViewModel
{
    
    DepartmentService departmentService;  
    public ObservableCollection<Department> Departments { get; } = new ObservableCollection<Department>();

    public AdministrativeSectorViewModel(DepartmentService departmentService) {
       // this.username = "Administrative";
        this.departmentService = departmentService;

        GetByDepartmentSectorIDAsync(5);
    }


    [ICommand]
    public void GoToHome()
    {
        Shell.Current.GoToAsync("//Home");
    }


    async Task GetByDepartmentSectorIDAsync(int sectorid)
    {
        if (IsBusy)
            return;
        try
        {
            IsBusy = true;
            var departments = await departmentService.GetDepartmentsBySectorid(sectorid);
            if (departments.Count != 0)
            {
                Departments.Clear();
            }
            foreach (var department in departments)
            {
                Departments.Add(department);
            }
        }
        catch (Exception ex)
        {
            //Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error!",
                $"Unabale to get Office: {ex.Message}", "OK");
        }
        finally
        {
            IsBusy = false;
        }
    }


}