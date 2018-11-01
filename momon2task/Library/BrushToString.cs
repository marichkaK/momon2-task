﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace momon2task.Library
{
    class BrushToString
    {
        /// <summary>
        /// Converts <see cref="Brush"/> to <see cref="string"/>.
        /// </summary>
        /// <param name="value"><see cref="Brush"/> to convert.</param>
        /// <param name="targetType">Type to which convert (<see cref="string"/>).</param>
        /// <param name="parameter">Not using parameter.</param>
        /// <param name="culture"><see cref="CultureInfo"/> of region.</param>
        /// <returns>Converted to <see cref="string"/> <see cref="Brush"/>.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return (value as Brush).ToString();
            }
            catch
            {
                return Binding.DoNothing;
            }
        }

        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Brush"/>.
        /// </summary>
        /// <param name="value"><see cref="string"/> to convert.</param>
        /// <param name="targetType">Type to which convert (<see cref="Brush"/>).</param>
        /// <param name="parameter">Not using parameter.</param>
        /// <param name="culture"><see cref="CultureInfo"/> of region.</param>
        /// <returns>Converted to <see cref="Brush"/> <see cref="string"/>.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return (Brush)new BrushConverter().ConvertFromString(value as string);
            }
            catch
            {
                return Binding.DoNothing;
            }
        }
    }
}
