using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ExamenWPF.Convers
{
    public class ConversYear : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
        // из формы в источник
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value.ToString() == "" || int.TryParse(value.ToString(), out int v))
            {
                return value;
            }
            else
            {
                return 1;
            }
        }
    }
}
