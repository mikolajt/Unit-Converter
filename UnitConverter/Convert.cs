using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                case "Imperial ton":
                    result = subresult * 0.000984207;
                    break;

                case "US ton":
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

        public double TemperatureConvert() {
            double subresult = 0;
            double result = 0;

            switch (Unit1ComboBoxValue) {
                case "Celcius":
                    subresult = UnitValue;
                    break;

                case "Fahrenheit":
                    subresult = ((UnitValue - 32) * (5 / 9));
                    break;

                case "Kelvin":
                    subresult = UnitValue - 273.15;
                    break;
            }

            switch (Unit2ComboBoxValue) {
                case "Celcius":
                    result = subresult;
                    break;

                case "Fahrenheit":
                    result = ((subresult * 9/5) + 32);
                    break;

                case "Kelvin":
                    result = subresult + 273.15;
                    break;
            }


            return result;
        }

        public double LenghtConvert() {
            double subresult = 0;
            double result = 0;

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

                case "Nautica Mile":
                    result = subresult * 0.000539957;
                    break;
            }


            return result;
        }
    }
}
