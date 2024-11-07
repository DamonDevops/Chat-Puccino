using ChatPuccino.Views;
using CommunityToolkit.Mvvm.Input;

namespace ChatPuccino.ViewModels;

public partial class LandingViewModel : BaseViewModel
{
    [RelayCommand]
    async Task GoToMenu()
    {
        await Shell.Current.GoToAsync($"//{nameof(MenuPage)}");
    }
}
