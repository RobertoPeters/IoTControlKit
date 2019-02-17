﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoTControlKit.Models.Application
{
    [NPoco.TableName("Device")]
    public class Device: BasePoco
    {
        public long DeviceControllerId { get; set; }
        public string NormalizedName { get; set; }
        public string Name { get; set; }
        public string DeviceType { get; set; }
    }
}
