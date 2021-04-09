using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseBlazorTest.Models
{
    public abstract class Trailer
    {
        int Id { get; set; }

        List<Cargo> Cargos { get; set; }

        



    
    }
}
