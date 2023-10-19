using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков
{
    internal class Apartment
    {
        
            private static int number;//уникальный номер квартиры
            public void SetNumb(int number1)
            {
                Apartment.number = number1;
            }
            public int PrintNumb()
            {
                return number++;
            }
            private uint height;
            public void SetHeig(uint height1)//высота здания
            {
                this.height = height1;
            }
            public uint PrintHeig()
            {
                return height;
            }
            private uint floor;//количество этажей
            public void SetFlo(uint floor1)
            {
                this.floor = floor1;
            }
            public uint PrintFlo()
            {
                return floor;
            }
            private uint quantity_apart;//количество квартир
            public void SetQuan_apart(uint quantity_apart)
            {
                this.quantity_apart = quantity_apart;
            }
            
            public uint PrintQuan_apart()
            {
                return quantity_apart;
            }
            private uint quantity_entr;//количество подъездов
            public void SetQuan_entr(uint quantity_entr)
            {
                this.quantity_entr = quantity_entr;
            }
            public uint PrintQuan_entr()
            {
                return quantity_entr;
            }
            public uint Heigth(uint heigth, uint floor)
            {
                uint result = (uint)(heigth / floor);
                return result;
            } 
            public uint Quantity_apart_inENTR(uint floor, uint quantity_entr)
            {
                uint result1 = (uint)(floor / quantity_entr);
                return result1;
            }
            public uint Quantity_apart_infloor(uint quantity_apart, uint floor)
            {
                uint result3 = (uint)(quantity_apart / floor);
                return result3;
            }

    }
}
