using Google.Android.Material.Badge;
using Google.Android.Material.BottomNavigation;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;
using Microsoft.Maui.Platform;

namespace ChatPuccino.Platforms.Android;

public class CommandBadgeRenderer : ShellRenderer
{
    protected override IShellBottomNavViewAppearanceTracker CreateBottomNavViewAppearanceTracker(ShellItem shellItem)
    {
        return new CommandBadgeBottomNav(this, shellItem);
    }

    class CommandBadgeBottomNav : ShellBottomNavViewAppearanceTracker
    {
        private BadgeDrawable? badgeDrawable;
        public CommandBadgeBottomNav(IShellContext shellContext, ShellItem shellItem) : base(shellContext, shellItem)
        {
        }
        public override void SetAppearance(BottomNavigationView bottomView, IShellAppearanceElement appearance)
        {
            base.SetAppearance(bottomView, appearance);

            if (badgeDrawable is null)
            {
                const int commandBadgeTabIndex = 1;

                var badgeDrawable = bottomView.GetOrCreateBadge(commandBadgeTabIndex);
                badgeDrawable.Number = 10;
                badgeDrawable.BackgroundColor = Colors.Red.ToPlatform();
                badgeDrawable.BadgeTextColor = Colors.White.ToPlatform();
            }
        }
    }
}
