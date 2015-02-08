using MVVMBasic.Common;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace MVVMBasic
{
    public sealed partial class VSimple : Page
    {
        private NavigationHelper navigationHelper;

        public VSimple()
        {
            this.InitializeComponent();
            navigationHelper = new NavigationHelper(this);
        }
    }
}
