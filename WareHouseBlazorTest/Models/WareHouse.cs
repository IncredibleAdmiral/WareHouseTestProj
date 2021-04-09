using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseBlazorTest.Models
{
    public class WareHouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<WareHouseSection> Sections { get; set; }






    }
}
