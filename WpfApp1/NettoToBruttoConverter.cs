using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp1
{
    class NettoToBruttoConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string param = parameter.ToString();
            double vat = 1;
            switch(param)
            {
                case "zwolniony": break;
                case "0": vat = 1.0; break;
                case "23": vat = 1.23; break;
                case "8": vat = 1.08; break;
                case "7": vat = 1.07; break;
                case "5": vat = 1.05; break;
            }
            double netto = 0;
            try
            {
                netto = Double.Parse(value.ToString());
            }
            catch
            {
                netto = 0;
            }

            return (netto * vat).ToString();
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
