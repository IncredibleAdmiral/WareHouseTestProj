using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseBlazorTest.Models
{
    public class Dock
    {
        int Id { get; set; }
        
        WareHouse WareHouse { get; set; }

        DockCondition Condition { get; set; }



    
    }
}
