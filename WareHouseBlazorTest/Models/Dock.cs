using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseBlazorTest.Models
{
    public class Dock
    {
        public readonly int id;

        public readonly WareHouse warehouse; 

        DockCondition Condition { get; set; }

        public Dock(int id, WareHouse warehouse)
        {
            this.id = id;
            this.warehouse = warehouse;
        }
    
    }
}
