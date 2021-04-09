using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseBlazorTest.Models
{
    public class Cell
    {
       public readonly string coordinateName;

        public readonly Сoordinates сoordinates;

        public Cell(Сoordinates сoordinates)
        {
            this.сoordinates = сoordinates;


            int row = сoordinates.row + 1;

            int column = сoordinates.column + 1;

            coordinateName = row.ToString() + "." + column.ToString();
        }



        public Cargo Cargo { get; set; }

        public void DeleteCargo()
        {
            Cargo = null;

        
        }


       


        public override int GetHashCode()
        {
            int Hash = 0;
            
            if (Cargo != null)
            {
                Hash += Cargo.Description.Count();
            }

            return Hash;
        }

    }
}
