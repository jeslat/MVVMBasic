using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace MVVMBasic.Converters
{
    public class BoolToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var actualValue = false;
            bool.TryParse(value.ToString(), out actualValue);

            if (actualValue)
            {
                return new SolidColorBrush(Colors.Green);
            }
            else
            {
                return new SolidColorBrush(Colors.Red);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
