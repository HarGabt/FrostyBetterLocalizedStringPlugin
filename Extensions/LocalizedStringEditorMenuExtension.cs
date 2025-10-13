using BetterLocalizedStringPlugin.Controls;
using Frosty.Core;
using System.Windows.Media;

namespace BetterLocalizedStringPlugin.Extensions
{
    public class LocalizedStringViewerMenuExtension : MenuExtension
    {
        internal static ImageSource imageSource = new ImageSourceConverter().ConvertFromString("pack://application:,,,/BetterLocalizedStringPlugin;component/Images/LocalizedStringEditor.png") as ImageSource;

        public override string TopLevelMenuName => "View";

        public override string MenuItemName => "Better Localized String Editor";

        public override ImageSource Icon => imageSource;

        public override RelayCommand MenuItemClicked => new RelayCommand((o) =>
        {
            App.EditorWindow.OpenEditor("Better Localized String Editor", new LocalizedStringEditor());
        });
    }
}
