using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_2_3
{
    internal class Bucket
    {
        private  Item[] _items;

        public Bucket() 
        {
            _items = new Item[0];
        }

        public void Add(Item item) 
        {
            if (_items.Length == 0)
            {
                _items = new Item[1];
                _items[0] = item;
                return;
            }

            var newitems = new Item[_items.Length + 1];

            for (int i = 0; i < _items.Length; i++)
            {
                newitems[i] = _items[i];
            }

            newitems[newitems.Length - 1] = item;
            _items = newitems;
        }

        public Item[] GetOrderItems() 
        {
            return _items;
        }
    }
}
