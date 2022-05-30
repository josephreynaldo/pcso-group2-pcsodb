


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcso_group2_pcsodb.ViewModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


public partial class HomeViewModel : BaseViewModel
{

    [ICommand]
    public void GoToCharity()
    {        
        Shell.Current.GoToAsync("//CharitySector");
    }

}