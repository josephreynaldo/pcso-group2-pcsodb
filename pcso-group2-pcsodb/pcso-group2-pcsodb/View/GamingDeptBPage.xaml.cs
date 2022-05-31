using pcso_group2_pcsodb.ViewModel;

namespace pcso_group2_pcsodb.View;

public partial class GamingDeptBPage : ContentPage
{
	public GamingDeptBPage(GamingDeptBViewModel gamingDeptBViewModel)
	{
		InitializeComponent();
        BindingContext = gamingDeptBViewModel;

    }
}