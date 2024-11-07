using Google.Android.Material.BottomNavigation;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;

namespace ChatPuccino.Platforms.Android;

public class CommandBadgeRenderer : ShellRenderer
{
    protected override IShellBottomNavViewAppearanceTracker CreateBottomNavViewAppearanceTracker(ShellItem shellItem)
    {
        return base.CreateBottomNavViewAppearanceTracker(shellItem);
    }

    class CommandBadgeBottomNav : ShellBottomNavViewAppearanceTracker
    {
        public CommandBadgeBottomNav(IShellContext shellContext, ShellItem shellItem) : base(shellContext, shellItem)
        {
        }
        public void SetAppearance(BottomNavigationView bottomView, IShellAppearanceElement appearance)
        {
            throw new NotImplementedException();
        }
    }
}
