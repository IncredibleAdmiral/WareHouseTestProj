using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseBlazorTest.Models
{
    public enum CargoCondition
    {
        // Ожидает прибытия
        InComming,
        
        // На хранении
        OnStorage,
        

        // Отправлен
        Shipped,

        // Разгрузка
        Unloading,

        // Загрузка
        Loading




    }
}
