using MVVMBasic.Common;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace MVVMBasic.Views
{
    public sealed partial class VCommands : Page
    {
        private NavigationHelper navigationHelper;

        public VCommands()
        {
            this.InitializeComponent();
            navigationHelper = new NavigationHelper(this);
        }
    }
}
