using System.ComponentModel;

namespace UnitConverter {
    enum MassEnum {
        Tonne, 
        Kilogram, 
        Gram, 
        Milligram,
        [Description("Imperial Ton")]
        Imperial_Ton,
        [Description("US Ton")]
        US_Ton,
        Stone, 
        Pounde, 
        Ounce
    }
}
