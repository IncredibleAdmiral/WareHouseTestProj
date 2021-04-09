using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouseBlazorTest.Models;

namespace WareHouseBlazorTest.Interfaces
{
    public interface ISection
    {
        public int Id { get; set; }


    

        public void AddCargoToCell(Сoordinates сellСoordinates, Cargo cargo);

        public void DeleteCargoOnCell(Сoordinates сellСoordinates);

        
    }
}
