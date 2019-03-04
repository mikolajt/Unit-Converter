using System;
using System.ComponentModel;
using System.Reflection;

namespace UnitConverter {
    class EnumDescription {

        EnumDescription() { }

        public static string GetEnumDescription(Enum enumValue) {

            FieldInfo fi = enumValue.GetType().GetField(enumValue.ToString());

            DescriptionAttribute[] describtionAttributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (describtionAttributes.Length > 0 && describtionAttributes != null) {
                return describtionAttributes[0].Description;
            }
            else {
                return enumValue.ToString();
            }
        }

    }
}
