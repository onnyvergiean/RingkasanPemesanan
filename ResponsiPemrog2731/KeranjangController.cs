using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrog2731
{
    class KeranjangController
    {
        private Keranjang keranjang;
        private KeranjangEventListener KeranjangEventListener;

        public KeranjangController(Keranjang keranjang, KeranjangEventListener keranjangEventListener)
        {
            this.keranjang = keranjang;
            this.KeranjangEventListener = keranjangEventListener;
        }

        public void addItemKeranjang(ItemKeranjang itemKeranjang)
        {
            this.keranjang.insert(itemKeranjang);
        }

       
        public List<ItemKeranjang> findAll()
        {
            return this.keranjang.findAll();
        }
    }
}
