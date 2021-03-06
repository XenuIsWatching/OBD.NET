﻿using System;
using OBD.NET.Devices;
using OBD.NET.Events.EventArgs;
using OBD.NET.OBDData;

namespace OBD.NET.Events
{
    public class GenericDataEventManager<T> : IDataEventManager where T : IOBDData
    {
        #region Properties & Fields

        #endregion

        #region Events

        internal event ELM327.DataReceivedEventHandler<T> DataReceived;

        #endregion

        #region Constructors

        #endregion

        #region Methods

        public void RaiseEvent(object sender, IOBDData data, DateTime timestamp)
        {
            DataReceived?.Invoke(sender, new DataReceivedEventArgs<T>((T)data, timestamp));
        }

        #endregion
    }
}
