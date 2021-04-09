using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseBlazorTest.Models
{
    public class Сoordinates
    {
        public readonly int row;

        public readonly int column;



        public Сoordinates(int row,int column)
        {
            this.row = row;
            this.column = column;
        }

    }
}
