using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_2_3
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void Notify(Item[] items) 
        {
            Console.WriteLine("ваше замовлення ");
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write($"{items[i].Name} - {items[i].Id}\t");
            }
            
        }
    }
}
