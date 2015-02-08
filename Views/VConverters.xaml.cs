using MVVMBasic.Common;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace MVVMBasic.Views
{
    public sealed partial class VConverters : Page
    {
        private NavigationHelper navigationHelper;

        public VConverters()
        {
            this.InitializeComponent();
            navigationHelper = new NavigationHelper(this);
        }
    }
}
