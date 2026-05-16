using System;
using System.Globalization;
using System.Windows.Data;

namespace Or.Business
{
    public class TypeTransacConverter : IValueConverter
    {
        // Ok utilisation d'un Converteur
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Les break ne sont pas nécessaires car tu as return 

            switch(value)
            {
                case Operation.DepotSimple:
                    return "Dépôt";
                case Operation.RetraitSimple:
                    return "Retrait";
                case Operation.InterCompte:
                    return "Virement";
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
