using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_2_3
{
    public class Shop
    {
        public Item[] GetOrderedItems = new Item[10];

        public Item[] GetItems() 
        {
            var result = new Item[]
            {
                new Item {Id = 1, Name = "Coffee"},
                new Item {Id = 2, Name = "Tea"},
                new Item {Id = 3, Name= "Car"},
                new Item {Id = 4, Name= "Toy"},
                new Item {Id = 5, Name = "Lego"},
                new Item {Id = 6, Name= "Laptop"},
                new Item {Id = 7, Name = "Cake"},
                new Item {Id = 8, Name= "Cookie"},
                new Item {Id = 9, Name= "Cartridge"},
                new Item {Id= 11, Name="Candy"},
                new Item {Id= 12, Name="Smartphone"},
                new Item {Id= 13, Name="Clothes"},
                new Item {Id= 14, Name="Paint"},
                new Item {Id= 15, Name="Charger"},
                new Item {Id= 16, Name="Water"},
                new Item {Id= 17, Name="TV"},
                new Item {Id= 18, Name="Multi Cooker"},
                new Item {Id= 19, Name="Glasses"},
                new Item {Id= 20, Name="Guitar"},
            };
            return result;
        }
    }
}
