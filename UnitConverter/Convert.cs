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
            else {
                switch (Unit1ComboBoxValue) {
                    case "Tonne":
                        subresult = UnitValue * 1000;
                        break;

                    case "Kilogram":
                        subresult = UnitValue;
                        break;

                    case "Gram":
                        subresult = UnitValue * 0.001;
                        break;

                    case "Milligram":
                        subresult = UnitValue * 0.000001;
                        break;

                    case "Imperial Ton":
                        subresult = UnitValue * 1016.05;
                        break;

                    case "US Ton":
                        subresult = UnitValue * 907.185;
                        break;

                    case "Stone":
                        subresult = UnitValue * 6.35029;
                        break;

                    case "Pound":
                        subresult = UnitValue * 0.453592;
                        break;

                    case "Ounce":
                        subresult = UnitValue * 0.0283495;
                        break;
                }

                switch (Unit2ComboBoxValue) {
                    case "Tonne":
                        result = subresult * 0.001;
                        break;

                    case "Kilogram":
                        result = subresult;
                        break;

                    case "Gram":
                        result = subresult * 1000;
                        break;

                    case "Milligram":
                        result = subresult * 1000000;
                        break;

                    case "Imperial Ton":
                        result = subresult * 0.000984207;
                        break;

                    case "US Ton":
                        result = subresult * 0.00110231;
                        break;

                    case "Stone":
                        result = subresult * 0.157473;
                        break;

                    case "Pounde":
                        result = subresult * 2.20462;
                        break;

                    case "Ounce":
                        result = subresult * 35.274;
                        break;
                }

                return result;
            }
        }

        public double TemperatureConvert() {
            double subresult = 0;
            double result = 0;

            switch (Unit1ComboBoxValue) {
                case "Celcius":
                    subresult = UnitValue;
                    break;

                case "Fahrenheit":
                    subresult = ((UnitValue - 32) * 0.556);
                    break;

                case "Kelvin":
                    subresult = UnitValue - 273.15;
                    break;
            }

            if (subresult < -273.15) {
                throw new NegativeValueException("This temperature is below absolute zero");
            }

            switch (Unit2ComboBoxValue) {
                case "Celcius":
                    result = subresult;
                    break;

                case "Fahrenheit":
                    result = ((subresult * 1.8) + 32);
                    break;

                case "Kelvin":
                    result = subresult + 273.15;
                    break;
            }


            return result;
        }

        public double lengthConvert() {
            double subresult = 0;
            double result = 0;


            if (UnitValue < 0) {
                throw new NegativeValueException("Length cannot be negative");
            }
            else {
                switch (Unit1ComboBoxValue) {
                    case "Kilometre":
                        subresult = UnitValue * 1000;
                        break;

                    case "Metre":
                        subresult = UnitValue;
                        break;

                    case "Centimetre":
                        subresult = UnitValue * 0.01;
                        break;

                    case "Millimetre":
                        subresult = UnitValue * 0.001;
                        break;

                    case "Mile":
                        subresult = UnitValue * 1609.34;
                        break;

                    case "Yard":
                        subresult = UnitValue * 0.9144;
                        break;

                    case "Foot":
                        subresult = UnitValue * 0.3048;
                        break;

                    case "Inch":
                        subresult = UnitValue * 0.0254;
                        break;

                    case "Nautica Mile":
                        subresult = UnitValue * 1852;
                        break;
                }

                switch (Unit2ComboBoxValue) {
                    case "Kilometre":
                        result = subresult * 0.001;
                        break;

                    case "Metre":
                        result = subresult;
                        break;

                    case "Centimetre":
                        result = subresult * 100;
                        break;

                    case "Millimetre":
                        result = subresult * 1000;
                        break;

                    case "Mile":
                        result = subresult * 0.000621371;
                        break;

                    case "Yard":
                        result = subresult * 1.09361;
                        break;

                    case "Foot":
                        result = subresult * 3.28084;
                        break;

                    case "Inch":
                        result = subresult * 39.3701;
                        break;

                    case "Nautical Mile":
                        result = subresult * 0.000539957;
                        break;
                }


                return result;
            }
        }

        public double areaConvert() {
            double subresult = 0;
            double result = 0;


            if (UnitValue < 0) {
                throw new NegativeValueException("Area cannot be negative");
            }
            else {
                switch (Unit1ComboBoxValue) {
                    case "Square kilometre":
                        subresult = UnitValue * 1000000;
                        break;

                    case "Square metre":
                        subresult = UnitValue;
                        break;

                    case "Square mile":
                        subresult = UnitValue * 2590000;
                        break;

                    case "Square yard":
                        subresult = UnitValue * 0.836127;
                        break;

                    case "Square foot":
                        subresult = UnitValue * 0.092903;
                        break;

                    case "Square inch":
                        subresult = UnitValue * 0.00064516;
                        break;

                    case "Hectare":
                        subresult = UnitValue * 10000;
                        break;

                    case "Acre":
                        subresult = UnitValue * 4046.86;
                        break;
                }

                switch (Unit2ComboBoxValue) {
                    case "Square kilometre":
                        result = subresult * 0.000001;
                        break;

                    case "Square metre":
                        result = subresult;
                        break;

                    case "Square mile":
                        result = subresult * 0.0000003861;
                        break;

                    case "Square yard":
                        result = subresult * 1.19599;
                        break;

                    case "Square foot":
                        result = subresult * 10.7639;
                        break;

                    case "Square inch":
                        result = subresult * 1550;
                        break;

                    case "Hectare":
                        result = subresult * 0.0001;
                        break;

                    case "Acre":
                        result = subresult * 0.000247105;
                        break;
                }


                return result;
            }
        }

        public double pressureConvert() {
            double subresult = 0;
            double result = 0;


            if (UnitValue < 0) {
                throw new NegativeValueException("Pressure cannot be negative");
            }
            else {
                switch (Unit1ComboBoxValue) {
                    case "Atmosphere":
                        subresult = UnitValue * 101325;
                        break;

                    case "Bar":
                        subresult = UnitValue * 100000;
                        break;

                    case "Pascal":
                        subresult = UnitValue;
                        break;

                    case "Pound-force per square inch":
                        subresult = UnitValue * 6894.76;
                        break;

                    case "Torr":
                        subresult = UnitValue * 133.322;
                        break;

                }

                switch (Unit2ComboBoxValue) {
                    case "Atmosphere":
                        result = subresult * 0.000009869;
                        break;

                    case "Bar":
                        result = subresult * 0.00001;
                        break;

                    case "Pascal":
                        result = subresult;
                        break;

                    case "Pound-force per square inch":
                        result = subresult * 0.000145038;
                        break;

                    case "Torr":
                        result = subresult * 0.00750062;
                        break;
                }

                return result;
            }
        }

        public double speedConvert() {
            double subresult = 0;
            double result = 0;


            if (UnitValue < 0) {
                throw new NegativeValueException("Speed cannot be negative");
            }
            else {
                switch (Unit1ComboBoxValue) {
                    case "Metre per second":
                        subresult = UnitValue;
                        break;

                    case "Kilometre per hour":
                        subresult = UnitValue * 0.277778;
                        break;

                    case "Miles per hour":
                        subresult = UnitValue * 0.44704;
                        break;

                    case "Foot per second":
                        subresult = UnitValue * 0.3048;
                        break;

                    case "Knot":
                        subresult = UnitValue * 0.514444;
                        break;
                }

                switch (Unit2ComboBoxValue) {
                    case "Metre per second":
                        result = subresult;
                        break;

                    case "Kilometre per hour":
                        result = subresult * 3.6;
                        break;

                    case "Miles per hour":
                        result = subresult * 2.23694;
                        break;

                    case "Foot per second":
                        result = subresult * 3.28084;
                        break;

                    case "Knot":
                        result = subresult * 1.94384;
                        break;
                }


                return result;
            }
        }

        public double timeConvert() {
            double subresult = 0;
            double result = 0;


            if (UnitValue < 0) {
                throw new NegativeValueException("Time cannot be negative");
            }
            else {
                switch (Unit1ComboBoxValue) {
                    case "Millisecond":
                        subresult = UnitValue * 0.001;
                        break;

                    case "Second":
                        subresult = UnitValue;
                        break;

                    case "Minute":
                        subresult = UnitValue * 60;
                        break;

                    case "Hour":
                        subresult = UnitValue * 3600;
                        break;

                    case "Day":
                        subresult = UnitValue * 86400;
                        break;

                    case "Week":
                        subresult = UnitValue * 604800;
                        break;

                    case "Moth":
                        subresult = UnitValue * 2628000;
                        break;

                    case "Year":
                        subresult = UnitValue * 31540000;
                        break;

                    case "Decade":
                        subresult = UnitValue * 315400000;
                        break;

                    case "Century":
                        subresult = UnitValue * 3154000000;
                        break;
                }

                switch (Unit2ComboBoxValue) {
                    case "Millisecond":
                        result = subresult * 1000;
                        break;

                    case "Second":
                        result = subresult;
                        break;

                    case "Minute":
                        result = subresult * 0.016667;
                        break;

                    case "Hour":
                        result = subresult * 0.00027778;
                        break;

                    case "Day":
                        result = subresult * 0.000011574;
                        break;

                    case "Week":
                        result = subresult * 0.0000016534;
                        break;

                    case "Month":
                        result = subresult * 0.00000038052;
                        break;

                    case "Year":
                        result = subresult * 0.00000003171;
                        break;

                    case "Decade":
                        result = subresult * 0.000000003171;
                        break;

                    case "Century":
                        result = subresult * 0.0000000003171;
                        break;
                }


                return result;
            }
        }
    }
}
