using System;

namespace UnitConverter {
    class NegativeValueException : Exception {

        public NegativeValueException(string message) : base(message) { }

    }
}
