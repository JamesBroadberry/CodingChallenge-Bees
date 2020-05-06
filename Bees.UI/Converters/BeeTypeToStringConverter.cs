using Bees.Core;
using System;
using System.Globalization;
using System.Windows.Data;

namespace Bees.UI.Converters
{
    public class BeeTypeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null)
            {
                return string.Empty;
            }

            var beeType = value.GetType();
            
            if(beeType == typeof(WorkerBee))
            {
                return "Worker Bee";
            }
            else if (beeType == typeof(DroneBee))
            {
                return "Drone Bee";
            }
            else if (beeType == typeof(QueenBee))
            {
                return "Queen Bee";
            }
            else
            {
                return "Unknown Bee";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
