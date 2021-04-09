using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WareHouseBlazorTest.Interfaces;
using WareHouseBlazorTest.Models;

namespace WareHouseBlazorTest.Mocks
{
    public class SectionMockSingleton : WareHouseSection, IConditionChecker
    {                   
        
        private int hash;

        public event Action ChangeSectionsValuesEvent;

        Thread CheckingThread;


        public  void CheckHash()
        {
            while (true)
            {
               int curHash = GetHashCode();
                
                if(hash!=curHash)
                {
                   
                    if (ChangeSectionsValuesEvent != null)
                    {
                       ChangeSectionsValuesEvent();
                    }
                    
                }
                hash = curHash;
                Thread.Sleep(200);
            } 
           
        }     

        public SectionMockSingleton(int numberOfRows, int numberOfColunms) : base(numberOfRows,numberOfColunms)
        {
            //Section = new WareHouseSection(5,7);

            //Section.AddCargoToCell(new Сoordinates(0, 1), new Cargo() { Description = "Пластиковые дилдо до 20см"});
            //Section.AddCargoToCell(new Сoordinates(0, 2), new Cargo() { Description = "Мексиканские эмигранты"});
            //Section.AddCargoToCell(new Сoordinates(0, 3), new Cargo() { Description = "Бабушкие фарфор"});
            //Section.AddCargoToCell(new Сoordinates(0, 4), new Cargo() { Description = "Мое самомнение"});
            //Section.AddCargoToCell(new Сoordinates(0, 5), new Cargo() { Description = "Оружейный Уран"});
            //Section.AddCargoToCell(new Сoordinates(2, 1), new Cargo() { Description = "Неизвестный груз, но он шевелится"});
            //Section.AddCargoToCell(new Сoordinates(4, 5), new Cargo() { Description = "Кончилась фантазия"});

            //hash = Section.GetHashCode();


           


            CheckingThread = new Thread(CheckHash);


            CheckingThread.Start();


        }

    }
}
