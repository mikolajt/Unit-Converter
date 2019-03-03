using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter {
    class ComboBoxLists {

        private string UnitName { get; set; }

        public ComboBoxLists(string unitName) {
            UnitName = unitName;
        }

        public List<string> CreateList() {

            switch (UnitName) {
                case "Mass":
                    List<string> massList = new List<string>() { "Tonne", "Kilogram", "Gram", "Milligram", "Imperial ton", "US ton", "Stone", "Pounde", "Ounce" };
                    return massList;

                case "Temperature":
                    List<string> temperatureList = new List<string>() { "Celcius", "Fahrenheit", "Kelvin" };
                    return temperatureList;

                case "Lenght":
                    List<string> lenghtList = new List<string>() { "Kilometre", "Metre", "Centimetre", "Millimetre", "Mile", "Yard", "Foot", "Inch", "Nautica Mile" };
                    return lenghtList;
            }

            return null;
        }
    }
}
