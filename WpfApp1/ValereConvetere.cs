using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp1
{
    class ValereConvetere : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string param = parameter.ToString();
            double valere = 1;
            switch (param)
            {
                case "PLN": break;
                case "USD": valere = 0.25; break;
                case "EUR": valere = 0.23; break;
                case "CHF": valere = 0.22; break;
            }
            double brutto = Double.Parse(value.ToString());
            return (brutto * valere).ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
