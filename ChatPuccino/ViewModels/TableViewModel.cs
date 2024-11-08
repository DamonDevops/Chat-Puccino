using ChatPuccino.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ChatPuccino.ViewModels;

public partial class TableViewModel : BaseViewModel
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Count))]
    List<Consumable> commands = [];

    public int Count => Commands.Count;
}
