using pcso_group2_pcsodb.ViewModel;

namespace pcso_group2_pcsodb.View;

public partial class ManagementDeptB : ContentPage
{
	public ManagementDeptB(ManagementDeptBViewModel managementDeptBViewModel)
	{
		InitializeComponent();
        BindingContext = managementDeptBViewModel;
    }
}