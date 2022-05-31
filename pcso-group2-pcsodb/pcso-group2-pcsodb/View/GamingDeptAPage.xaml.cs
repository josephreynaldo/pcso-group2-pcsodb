using pcso_group2_pcsodb.ViewModel;

namespace pcso_group2_pcsodb.View;

public partial class GamingDeptAPage : ContentPage
{
	public GamingDeptAPage(GamingDeptAViewModel gamingDeptAViewModel)
	{
		InitializeComponent();
		BindingContext = gamingDeptAViewModel;

    }
}