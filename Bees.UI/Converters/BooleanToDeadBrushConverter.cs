using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Bees.UI.Converters
{
    public class BooleanToDeadBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null || value.GetType() != typeof(bool))
            {
                return Brushes.Black;
            }

            return (bool)value ? Brushes.Red : Brushes.Green;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
