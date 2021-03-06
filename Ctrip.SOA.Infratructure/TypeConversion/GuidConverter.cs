﻿using System;
using System.Globalization;
using Ctrip.SOA.Infratructure.Utility;

namespace Ctrip.SOA.Infratructure.TypeConversion
{   
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class GuidConverter : BaseTypeConverter
    {
        public override bool CanConvertFrom(Type sourceType)
        {
            return sourceType == typeof(Guid) || base.CanConvertFrom(sourceType);
        }

        public override object ConvertFrom(object source, CultureInfo culture)
        {
            if (source == null)
            {
                return Guid.Empty;
            }
            return Convert.ChangeType(source, typeof(Guid));
        }
    }
}