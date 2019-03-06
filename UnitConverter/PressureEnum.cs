using System.ComponentModel;

namespace UnitConverter {
    enum PressureEnum {
        Atmosphere,
        Bar,
        Pascal,
        [Description("Pound force per square inch")]
        Pound_force_per_square_inch,
        Torr
    }
}
