using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouseBlazorTest.Interfaces;

namespace WareHouseBlazorTest.Models
{
    public class WareHouse : IWareHouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ISection> Sections { get; set; }

        public List<Dock> Docks { get; set; }
        

        public WareHouse(int id, string name)
        {
            Id = id;
            Name = name;
          
        }

        public ISection GetSection(int id)
        {
            return Sections.Single(section => section.Id == id);
        }

        public void AddSection(ISection section)
        {
           var checkSectionsId = Sections.SingleOrDefault(section => section.Id == section.Id);
            if (checkSectionsId == null)
            {
                Sections.Add(section);
            }
            else
            {
                throw new Exception("Section already exists");
            }
                
        }

        public Dock GetDockById(int id)
        {
            return Docks.Single(dock => dock.id == id);
        }

        public void AddDock(Dock dock)
        {
            var checkSectionsId = Docks.SingleOrDefault(Dock => Dock.id == dock.id);
            if (checkSectionsId == null)
            {
                Docks.Add(dock);
            }
            else
            {
                throw new Exception("Dock already exists");
            }
        }
    }
}
