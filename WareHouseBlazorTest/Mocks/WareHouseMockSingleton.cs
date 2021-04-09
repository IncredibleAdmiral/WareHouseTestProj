using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouseBlazorTest.Interfaces;
using WareHouseBlazorTest.Models;

namespace WareHouseBlazorTest.Mocks
{
    public class WareHouseMockSingleton : WareHouse, IConditionChecker
    {
        public WareHouseMockSingleton(int id, string name) : base(id, name)
        {
        }

        public void CheckHash()
        {
            throw new NotImplementedException();
        }
    }
}
