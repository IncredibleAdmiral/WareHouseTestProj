using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouseBlazorTest.Interfaces;

namespace WareHouseBlazorTest.Models
{
    public class WareHouseSection : ISection
    {
      
        public int Id { get; set;}
        
        public string Name { get; set; }

        public List<List<Cell>> Grid { get;  set; }
       

        public WareHouseSection(int numberOfRows, int numberOfColunms)
        {
            Grid = new List<List<Cell>>();

            for (int rowsCounter = 0; rowsCounter < numberOfRows; rowsCounter++)
            {
                var curentRow = new List<Cell>();

                for (int columnsCounter = 0; columnsCounter < numberOfColunms; columnsCounter++)
                {


                    Сoordinates cellCoordinate = new Сoordinates(rowsCounter, columnsCounter);

                    curentRow.Add(new Cell(cellCoordinate));
                }
                Grid.Add(curentRow);
            }
        }

        private List<Cell> GetRow(int row)
        {
            if (row > Grid.Count)
            {
                throw new Exception("OverRowCount");
            }
            else
            {
                return Grid[row];
            }
        }


        private Cell GetCell(Сoordinates сellСoordinates)
        {

            var currentRow = GetRow(сellСoordinates.row);
            if (сellСoordinates.column > currentRow.Count)
            {
                throw new Exception("OverColumnCount");
            }
            else
            {
                return currentRow[сellСoordinates.column];
            }
        }



        public void AddCargoToCell(Сoordinates сellСoordinates, Cargo cargo)
        {
            var currentCell = GetCell(сellСoordinates);
            currentCell.Cargo = cargo;
        }

        public void DeleteCargoOnCell(Сoordinates сellСoordinates)
        {
            var currentCell = GetCell(сellСoordinates);

            currentCell.Cargo = null;
           
        }

        public override int GetHashCode()
        {
            int hash = 0;

            foreach ( List<Cell> cells in Grid)
            {
                foreach (Cell cell in cells)
                {
                    hash += cell.GetHashCode();
                }
            }

            return hash;
        }


    }


}
   




   



    
