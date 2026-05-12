using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Or.Business
{
    public class TypeTransacConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            switch(value)
            {
                case Operation.DepotSimple:
                    return "Dépot";
                    break;
                case Operation.RetraitSimple:
                    return "Retrait";
                    break;
                case Operation.InterCompte:
                    return "Virement";
                    break;
                default:
                    break;

            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }


        
    }
}
