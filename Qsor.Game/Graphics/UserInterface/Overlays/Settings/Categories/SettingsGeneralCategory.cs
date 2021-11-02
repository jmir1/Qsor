using osu.Framework.Allocation;
using osu.Framework.Graphics.Sprites;
using Qsor.Game.Graphics.UserInterface.Overlays.Settings.Drawables;
using Qsor.Game.Graphics.UserInterface.Overlays.Settings.Drawables.Objects;

namespace Qsor.Game.Graphics.UserInterface.Overlays.Settings.Categories
{
    public class SettingsGeneralCategory : SettingsCategoryContainer
    {
        public override string Name => "General";
        public override IconUsage Icon => FontAwesome.Solid.Cog;
        
        [BackgroundDependencyLoader]
        private void Load()
        {
            var signIn = new DrawableSettingsSubCategory("SIGN IN");
            signIn.Content.Add(new DrawableSettingsInput("", "Username", "Enter your username"));
            signIn.Content.Add(new DrawableSettingsInput("false", "Password", "Enter your password", true));
            signIn.Content.Add(new DrawableSettingsCheckbox(true, "Remember Username", "Remember the username next time Qsor starts."));
            signIn.Content.Add(new DrawableSettingsCheckbox(false, "Remember Password", "Remember the password next time Qsor starts."));

            var language = new DrawableSettingsSubCategory("LANGUAGE");
            language.Content.Add(new DrawableSettingsCheckbox(true, "Select language", "This has to be a drop-down menu!"));
            language.Content.Add(new DrawableSettingsCheckbox(false, "Prefer metadata in original language", "Where available, song titles will me shown in their native language (and charcter-set)."));
            language.Content.Add(new DrawableSettingsCheckbox(false, "Use alternative font for chat display", "For people who prefer a less stylized font, this sets the in-game chat to use Tahoma."));

            var updates = new DrawableSettingsSubCategory("UPDATES");
            updates.Content.Add(new DrawableSettingsCheckbox(true, "Release stream", "This has to be a drop-down menu!"));

            AddInternal(signIn);
            AddInternal(language);
            AddInternal(updates);
        }
    }
}