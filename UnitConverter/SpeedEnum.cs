using System.ComponentModel;

namespace UnitConverter {
    enum SpeedEnum {
        [Description("Metre per second")]
        Metre_per_second,
        [Description("Kilometre per hour")]
        Kilometre_per_hour,
        [Description("Miles per hour")]
        Miles_per_hour,
        [Description("Foot per second")]
        Foot_per_second,
        Knot
    }
}
