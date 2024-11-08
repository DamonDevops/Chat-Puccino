using CommunityToolkit.Mvvm.ComponentModel;

namespace ChatPuccino.ViewModels.Tools;

public partial class BadgeViewModel : BaseViewModel
{
    [ObservableProperty]
    int count = 0;
}
