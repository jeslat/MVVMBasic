using MVVMBasic.Common;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace MVVMBasic.Views
{
    public sealed partial class VMain : Page
    {
        private NavigationHelper navigationHelper;

        public VMain()
        {
            this.InitializeComponent();
            navigationHelper = new NavigationHelper(this);
        }
    }
}
