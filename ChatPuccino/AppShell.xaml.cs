using ChatPuccino.Views;

namespace ChatPuccino;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(LandingPage), typeof(LandingPage));
    }
}
