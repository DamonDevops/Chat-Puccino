using ChatPuccino.ViewModels;

namespace ChatPuccino.Views;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
		this.BindingContext = new LandingViewModel();
	}

	private void GoToApp()
	{

	}
}