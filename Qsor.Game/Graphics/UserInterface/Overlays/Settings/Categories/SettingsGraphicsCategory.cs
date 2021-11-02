using osu.Framework.Allocation;
using osu.Framework.Graphics.Sprites;
using Qsor.Game.Graphics.UserInterface.Overlays.Settings.Drawables;
using Qsor.Game.Graphics.UserInterface.Overlays.Settings.Drawables.Objects;

namespace Qsor.Game.Graphics.UserInterface.Overlays.Settings.Categories
{
    public class SettingsGraphicsCategory : SettingsCategoryContainer
    {
        
        public override string Name => "Graphics";
        public override IconUsage Icon => FontAwesome.Solid.Desktop;

        [BackgroundDependencyLoader]
        private void Load()
        {
            var renderer = new DrawableSettingsSubCategory("RENDERER");
            renderer.Content.Add(new DrawableSettingsCheckbox(false, "Frame limiter", "DROPDOWN"));
            renderer.Content.Add(new DrawableSettingsCheckbox(false, "Show FPS counter", "Show a subtle FPS counter in the bottom right corner of the screen."));

            var layout = new DrawableSettingsSubCategory("LAYOUT");
            layout.Content.Add(new DrawableSettingsCheckbox(false, "Resolution", "This has to be a drop-down menu!"));
            layout.Content.Add(new DrawableSettingsCheckbox(true, "Fulscreen mode", "Switches to dedicated fullscreen mode. Decreases cursor latency in Windows 7+."));
            layout.Content.Add(new DrawableSettingsCheckbox(true, "Render at native resolution", "Always use the full native resolution but display osu! in a smaller centered portion of the screen. Useful to get the low latency of full screen with a smaller game resolution."));
            layout.Content.Add(new DrawableSettingsCheckbox(false, "Horizontal postion", "SLIDER"));
            layout.Content.Add(new DrawableSettingsCheckbox(false, "Vertical postion", "SLIDER"));

            var detailSettings = new DrawableSettingsSubCategory("DETAIL SETTINGS");
            detailSettings.Content.Add(new DrawableSettingsCheckbox(true, "Snaking sliders", "Sliders gradually snake out from their starting point. This should run fine unless you have a low-end PC."));

            var mainMenu = new DrawableSettingsSubCategory("MAIN MENU");
            mainMenu.Content.Add(new DrawableSettingsCheckbox(false, "Snow", "Little representations of your current gamemode will fall from the sky."));

            var songSelect = new DrawableSettingsSubCategory("SONG SELECT");
            songSelect.Content.Add(new DrawableSettingsCheckbox(true, "Show thumbnails", "Display a preview of each beatmaps's background. Requires skin support (version 2.2+)."));

            AddInternal(renderer);
            AddInternal(layout);
            AddInternal(mainMenu);
            AddInternal(songSelect);
        }
    }
}