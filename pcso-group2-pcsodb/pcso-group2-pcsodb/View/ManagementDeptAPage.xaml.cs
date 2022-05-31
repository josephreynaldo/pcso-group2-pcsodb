using pcso_group2_pcsodb.ViewModel;

namespace pcso_group2_pcsodb.View;

public partial class ManagementDeptA : ContentPage
{
	public ManagementDeptA(ManagementDeptAViewModel managementDeptAViewModel)
	{
		InitializeComponent();
        BindingContext = managementDeptAViewModel;
    }
}