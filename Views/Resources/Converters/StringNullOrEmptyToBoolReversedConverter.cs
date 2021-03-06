﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CodeIDX.Views.Resources.Converters
{
    public class StringNullOrEmptyToBoolReversedConverter : IValueConverter
    {

        public static StringNullOrEmptyToBoolReversedConverter Instance = new StringNullOrEmptyToBoolReversedConverter();

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value is string && !string.IsNullOrEmpty((string)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
