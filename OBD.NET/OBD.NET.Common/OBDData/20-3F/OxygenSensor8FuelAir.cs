﻿using OBD.NET.DataTypes;

namespace OBD.NET.OBDData
{
    public class OxygenSensor8FuelAir : AbstractOBDData
    {
        #region Properties & Fields

        public Ratio FuelAirEquivalenceRatio => new Ratio((2.0 / 25536.0) * ((256 * A) + B), 0, 2 - double.Epsilon);
        public Volt Voltage => new Volt((80 / 25536.0) * ((256 * C) + D), 0, 8 - double.Epsilon);

        #endregion

        #region Constructors

        public OxygenSensor8FuelAir()
            : base(0x2B, 4)
        { }

        #endregion
    }
}
