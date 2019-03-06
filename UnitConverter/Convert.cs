using System;

namespace UnitConverter {
    class Convert {
        string Unit1ComboBoxValue { get; set; }
        string Unit2ComboBoxValue { get; set; }
        double UnitValue { get; set; }

        public Convert(string unit1ComboBoxValue, string unit2ComboBoxValue, double unitValue) {
            Unit1ComboBoxValue = unit1ComboBoxValue;
            Unit2ComboBoxValue = unit2ComboBoxValue;
            UnitValue = unitValue;
        }

        public double MassConvert() {
            double subresult = 0;
            double result = 0;

            if (UnitValue < 0) {
                throw new NegativeValueException("Mass cannot be negative");
            }
            else if (Enum.TryParse(Unit1ComboBoxValue.Replace(" ", "_"), out MassEnum unit1ComboBoxValueEnum) && Enum.TryParse(Unit2ComboBoxValue.Replace(" ", "_"), out MassEnum unit2ComboBoxValueEnum)) {
                switch (unit1ComboBoxValueEnum) {
                    case MassEnum.Tonne:
                        subresult = UnitValue * 1000;
                        break;

                    case MassEnum.Kilogram:
                        subresult = UnitValue;
                        break;

                    case MassEnum.Gram:
                        subresult = UnitValue * 0.001;
                        break;

                    case MassEnum.Milligram:
                        subresult = UnitValue * 0.000001;
                        break;

                    case MassEnum.Imperial_Ton:
                        subresult = UnitValue * 1016.05;
                        break;

                    case MassEnum.US_Ton:
                        subresult = UnitValue * 907.185;
                        break;

                    case MassEnum.Stone:
                        subresult = UnitValue * 6.35029;
                        break;

                    case MassEnum.Pounde:
                        subresult = UnitValue * 0.453592;
                        break;

                    case MassEnum.Ounce:
                        subresult = UnitValue * 0.0283495;
                        break;
                }

                switch (unit2ComboBoxValueEnum) {
                    case MassEnum.Tonne:
                        result = subresult * 0.001;
                        break;

                    case MassEnum.Kilogram:
                        result = subresult;
                        break;

                    case MassEnum.Gram:
                        result = subresult * 1000;
                        break;

                    case MassEnum.Milligram:
                        result = subresult * 1000000;
                        break;

                    case MassEnum.Imperial_Ton:
                        result = subresult * 0.000984207;
                        break;

                    case MassEnum.US_Ton:
                        result = subresult * 0.00110231;
                        break;

                    case MassEnum.Stone:
                        result = subresult * 0.157473;
                        break;

                    case MassEnum.Pounde:
                        result = subresult * 2.20462;
                        break;

                    case MassEnum.Ounce:
                        result = subresult * 35.274;
                        break;
                }
                return result;

            }
            else {
                throw new NegativeValueException("Error: Unexpected enum value");
            }
        }

        public double TemperatureConvert() {
            double subresult = 0;
            double result = 0;
            if (Enum.TryParse(Unit1ComboBoxValue.Replace(" ", "_"), out TemperatureEnum unit1ComboBoxValueEnum) && Enum.TryParse(Unit2ComboBoxValue.Replace(" ", "_"), out TemperatureEnum unit2ComboBoxValueEnum)) {
                switch (unit1ComboBoxValueEnum) {
                    case TemperatureEnum.Celcius:
                        subresult = UnitValue;
                        break;

                    case TemperatureEnum.Fahrenheit:
                        subresult = ((UnitValue - 32) * 0.556);
                        break;

                    case TemperatureEnum.Kelvin:
                        subresult = UnitValue - 273.15;
                        break;
                }

                if (subresult < -273.15) {
                    throw new NegativeValueException("This temperature is below absolute zero");
                }

                switch (unit2ComboBoxValueEnum) {
                    case TemperatureEnum.Celcius:
                        result = subresult;
                        break;

                    case TemperatureEnum.Fahrenheit:
                        result = ((subresult * 1.8) + 32);
                        break;

                    case TemperatureEnum.Kelvin:
                        result = subresult + 273.15;
                        break;
                }


                return result;
            }
            else {
                throw new NegativeValueException("Error: Unexpected enum value");
            }
        }

        public double lengthConvert() {
            double subresult = 0;
            double result = 0;


            if (UnitValue < 0) {
                throw new NegativeValueException("Length cannot be negative");
            }
            else if (Enum.TryParse(Unit1ComboBoxValue.Replace(" ", "_"), out LengthEnum unit1ComboBoxValueEnum) && Enum.TryParse(Unit2ComboBoxValue.Replace(" ", "_"), out LengthEnum unit2ComboBoxValueEnum)) {
                switch (unit1ComboBoxValueEnum) {
                    case LengthEnum.Kilometre:
                        subresult = UnitValue * 1000;
                        break;

                    case LengthEnum.Metre:
                        subresult = UnitValue;
                        break;

                    case LengthEnum.Centimetre:
                        subresult = UnitValue * 0.01;
                        break;

                    case LengthEnum.Millimetre:
                        subresult = UnitValue * 0.001;
                        break;

                    case LengthEnum.Mile:
                        subresult = UnitValue * 1609.34;
                        break;

                    case LengthEnum.Yard:
                        subresult = UnitValue * 0.9144;
                        break;

                    case LengthEnum.Foot:
                        subresult = UnitValue * 0.3048;
                        break;

                    case LengthEnum.Inch:
                        subresult = UnitValue * 0.0254;
                        break;

                    case LengthEnum.Nautical_Mile:
                        subresult = UnitValue * 1852;
                        break;
                }

                switch (unit2ComboBoxValueEnum) {
                    case LengthEnum.Kilometre:
                        result = subresult * 0.001;
                        break;

                    case LengthEnum.Metre:
                        result = subresult;
                        break;

                    case LengthEnum.Centimetre:
                        result = subresult * 100;
                        break;

                    case LengthEnum.Millimetre:
                        result = subresult * 1000;
                        break;

                    case LengthEnum.Mile:
                        result = subresult * 0.000621371;
                        break;

                    case LengthEnum.Yard:
                        result = subresult * 1.09361;
                        break;

                    case LengthEnum.Foot:
                        result = subresult * 3.28084;
                        break;

                    case LengthEnum.Inch:
                        result = subresult * 39.3701;
                        break;

                    case LengthEnum.Nautical_Mile:
                        result = subresult * 0.000539957;
                        break;
                }


                return result;
            }
            else {
                throw new NegativeValueException("Error: Unexpected enum value");
            }
        }

        public double areaConvert() {
            double subresult = 0;
            double result = 0;


            if (UnitValue < 0) {
                throw new NegativeValueException("Area cannot be negative");
            }
            else if (Enum.TryParse(Unit1ComboBoxValue.Replace(" ", "_"), out AreaEnum unit1ComboBoxValueEnum) && Enum.TryParse(Unit2ComboBoxValue.Replace(" ", "_"), out AreaEnum unit2ComboBoxValueEnum)) {
                switch (unit1ComboBoxValueEnum) {
                    case AreaEnum.Square_kilometre:
                        subresult = UnitValue * 1000000;
                        break;

                    case AreaEnum.Square_metre:
                        subresult = UnitValue;
                        break;

                    case AreaEnum.Square_mile:
                        subresult = UnitValue * 2590000;
                        break;

                    case AreaEnum.Square_yard:
                        subresult = UnitValue * 0.836127;
                        break;

                    case AreaEnum.Square_foot:
                        subresult = UnitValue * 0.092903;
                        break;

                    case AreaEnum.Square_inch:
                        subresult = UnitValue * 0.00064516;
                        break;

                    case AreaEnum.Hectare:
                        subresult = UnitValue * 10000;
                        break;

                    case AreaEnum.Acre:
                        subresult = UnitValue * 4046.86;
                        break;
                }

                switch (unit2ComboBoxValueEnum) {
                    case AreaEnum.Square_kilometre:
                        result = subresult * 0.000001;
                        break;

                    case AreaEnum.Square_metre:
                        result = subresult;
                        break;

                    case AreaEnum.Square_mile:
                        result = subresult * 0.0000003861;
                        break;

                    case AreaEnum.Square_yard:
                        result = subresult * 1.19599;
                        break;

                    case AreaEnum.Square_foot:
                        result = subresult * 10.7639;
                        break;

                    case AreaEnum.Square_inch:
                        result = subresult * 1550;
                        break;

                    case AreaEnum.Hectare:
                        result = subresult * 0.0001;
                        break;

                    case AreaEnum.Acre:
                        result = subresult * 0.000247105;
                        break;
                }


                return result;
            }
            else {
                throw new NegativeValueException("Error: Unexpected enum value");
            }
        }

        public double pressureConvert() {
            double subresult = 0;
            double result = 0;


            if (UnitValue < 0) {
                throw new NegativeValueException("Pressure cannot be negative");
            }
            else if (Enum.TryParse(Unit1ComboBoxValue.Replace(" ", "_"), out PressureEnum unit1ComboBoxValueEnum) && Enum.TryParse(Unit2ComboBoxValue.Replace(" ", "_"), out PressureEnum unit2ComboBoxValueEnum)) {
                switch (unit1ComboBoxValueEnum) {
                    case PressureEnum.Atmosphere:
                        subresult = UnitValue * 101325;
                        break;

                    case PressureEnum.Bar:
                        subresult = UnitValue * 100000;
                        break;

                    case PressureEnum.Pascal:
                        subresult = UnitValue;
                        break;

                    case PressureEnum.Pound_force_per_square_inch:
                        subresult = UnitValue * 6894.76;
                        break;

                    case PressureEnum.Torr:
                        subresult = UnitValue * 133.322;
                        break;

                }

                switch (unit2ComboBoxValueEnum) {
                    case PressureEnum.Atmosphere:
                        result = subresult * 0.000009869;
                        break;

                    case PressureEnum.Bar:
                        result = subresult * 0.00001;
                        break;

                    case PressureEnum.Pascal:
                        result = subresult;
                        break;

                    case PressureEnum.Pound_force_per_square_inch:
                        result = subresult * 0.000145038;
                        break;

                    case PressureEnum.Torr:
                        result = subresult * 0.00750062;
                        break;
                }

                return result;
            }
            else {
                throw new NegativeValueException("Error: Unexpected enum value");
            }
        }

        public double speedConvert() {
            double subresult = 0;
            double result = 0;


            if (UnitValue < 0) {
                throw new NegativeValueException("Speed cannot be negative");
            }
            else if (Enum.TryParse(Unit1ComboBoxValue.Replace(" ", "_"), out SpeedEnum unit1ComboBoxValueEnum) && Enum.TryParse(Unit2ComboBoxValue.Replace(" ", "_"), out SpeedEnum unit2ComboBoxValueEnum)) {
                switch (unit1ComboBoxValueEnum) {
                    case SpeedEnum.Metre_per_second:
                        subresult = UnitValue;
                        break;

                    case SpeedEnum.Kilometre_per_hour:
                        subresult = UnitValue * 0.277778;
                        break;

                    case SpeedEnum.Miles_per_hour:
                        subresult = UnitValue * 0.44704;
                        break;

                    case SpeedEnum.Foot_per_second:
                        subresult = UnitValue * 0.3048;
                        break;

                    case SpeedEnum.Knot:
                        subresult = UnitValue * 0.514444;
                        break;
                }

                switch (unit2ComboBoxValueEnum) {
                    case SpeedEnum.Metre_per_second:
                        result = subresult;
                        break;

                    case SpeedEnum.Kilometre_per_hour:
                        result = subresult * 3.6;
                        break;

                    case SpeedEnum.Miles_per_hour:
                        result = subresult * 2.23694;
                        break;

                    case SpeedEnum.Foot_per_second:
                        result = subresult * 3.28084;
                        break;

                    case SpeedEnum.Knot:
                        result = subresult * 1.94384;
                        break;
                }


                return result;
            }
            else {
                throw new NegativeValueException("Error: Unexpected enum value");
            }
        }

        public double timeConvert() {
            double subresult = 0;
            double result = 0;


            if (UnitValue < 0) {
                throw new NegativeValueException("Time cannot be negative");
            }
            else if (Enum.TryParse(Unit1ComboBoxValue.Replace(" ", "_"), out TimeEnum unit1ComboBoxValueEnum) && Enum.TryParse(Unit2ComboBoxValue.Replace(" ", "_"), out TimeEnum unit2ComboBoxValueEnum)) {
                switch (unit1ComboBoxValueEnum) {
                    case TimeEnum.Millisecond:
                        subresult = UnitValue * 0.001;
                        break;

                    case TimeEnum.Second:
                        subresult = UnitValue;
                        break;

                    case TimeEnum.Minute:
                        subresult = UnitValue * 60;
                        break;

                    case TimeEnum.Hour:
                        subresult = UnitValue * 3600;
                        break;

                    case TimeEnum.Day:
                        subresult = UnitValue * 86400;
                        break;

                    case TimeEnum.Week:
                        subresult = UnitValue * 604800;
                        break;

                    case TimeEnum.Month:
                        subresult = UnitValue * 2628000;
                        break;

                    case TimeEnum.Year:
                        subresult = UnitValue * 31540000;
                        break;

                    case TimeEnum.Decade:
                        subresult = UnitValue * 315400000;
                        break;

                    case TimeEnum.Century:
                        subresult = UnitValue * 3154000000;
                        break;
                }

                switch (unit2ComboBoxValueEnum) {
                    case TimeEnum.Millisecond:
                        result = subresult * 1000;
                        break;

                    case TimeEnum.Second:
                        result = subresult;
                        break;

                    case TimeEnum.Minute:
                        result = subresult * 0.016667;
                        break;

                    case TimeEnum.Hour:
                        result = subresult * 0.00027778;
                        break;

                    case TimeEnum.Day:
                        result = subresult * 0.000011574;
                        break;

                    case TimeEnum.Week:
                        result = subresult * 0.0000016534;
                        break;

                    case TimeEnum.Month:
                        result = subresult * 0.00000038052;
                        break;

                    case TimeEnum.Year:
                        result = subresult * 0.00000003171;
                        break;

                    case TimeEnum.Decade:
                        result = subresult * 0.000000003171;
                        break;

                    case TimeEnum.Century:
                        result = subresult * 0.0000000003171;
                        break;
                }


                return result;
            }
            else {
                throw new NegativeValueException("Error: Unexpected enum value");
            }
        }
    }
}
