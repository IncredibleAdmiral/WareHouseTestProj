using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouseBlazorTest.Models;

namespace WareHouseBlazorTest.Interfaces
{
    public interface IWareHouse
    {
        public int Id {get;set;}

        public ISection GetSection(int id);

        public void AddSection(ISection section);

        public Dock GetDockById(int id);

        public void AddDock(Dock dock);



       
    }
}
