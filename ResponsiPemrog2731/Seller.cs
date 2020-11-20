using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrog2731
{
    class Seller
    {
        private string name;
        private KeranjangController keranjang;

        public Seller(string name, KeranjangController keranjang)
        {
            this.name = name;
            this.keranjang = keranjang;
        }

        public List<ItemKeranjang> findAll()
        {
            return this.keranjang.findAll();
        }

        public void addItemKeranjang(ItemKeranjang itemKeranjang)
        {
            this.keranjang.addItemKeranjang(itemKeranjang);
        }
    }
}
