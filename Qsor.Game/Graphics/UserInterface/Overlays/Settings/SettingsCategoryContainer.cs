using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Sprites;
using osuTK;

namespace Qsor.Game.Graphics.UserInterface.Overlays.Settings
{
    public abstract class SettingsCategoryContainer : FillFlowContainer
    {
        public new abstract string Name { get; }
        public abstract IconUsage Icon { get; }

        public SettingsCategoryContainer()
        {
            Spacing = new Vector2(0, 25f);
            RelativeSizeAxes = Axes.X;
            AutoSizeAxes = Axes.Y;
        }
    }
}