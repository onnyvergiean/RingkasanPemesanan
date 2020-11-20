using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrog2731
{
    class Keranjang
    {


        private List<ItemKeranjang> itemKeranjang;

        public Keranjang()
        {
            this.itemKeranjang = new List<ItemKeranjang>();
        }

        public void insert(ItemKeranjang itemKeranjang){
            this.itemKeranjang.Add(itemKeranjang);
        }



        public List<ItemKeranjang> findAll()
        {
            return this.itemKeranjang;
        }
        
       
    }
}
