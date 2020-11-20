using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrog2731
{
    class Bucket
    {
        private List<Item> items;
  
        public Bucket()
        {
            this.items = new List<Item>();
            items.Add(new Item() { nama = "Jeruk", harga = 5000 });
            items.Add(new Item() { nama = "Ice Tea", harga = 3000 });
            items.Add(new Item() { nama = "Ice Lemon", harga = 5000 });
            items.Add(new Item() { nama = "Bakso", harga = 10000 });
            items.Add(new Item() { nama = "Gado - Gado", harga = 12000 });
            items.Add(new Item() { nama = "Sate", harga = 15000 });
        }

       public List<Item> GetItems()
        {
            return items;
        }
        public void remove(int position)
        {
            this.items.RemoveAt(position);
        }
    }
}
