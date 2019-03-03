using System.ComponentModel;

namespace UnitConverter {
    enum MassEnum {
        Tonne, 
        Kilogram, 
        Gram, 
        Milligram,
        [Description("Imperial Ton")]
        Imperialton,
        [Description("US Ton")]
        USton,
        Stone, 
        Pounde, 
        Ounce
    }
}
