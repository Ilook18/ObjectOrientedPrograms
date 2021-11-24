﻿using ObjectOrientedPrograms;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgram
{
    class InventoryFactory
    {
        public List<InventoryModel> Rice { get; set; }
        public List<InventoryModel> Wheat { get; set; }
        public List<InventoryModel> Pulses { get; set; }
    }
}