using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrog2731
{
    class ItemKeranjang
    {
        public string nama { get; set; }
        public int harga { get; set; }
        public int subTotal { get; set; }
        public int hargaTotal { get; set; }

        public ItemKeranjang(string nama, int harga)
        {
            this.nama = nama;
            this.harga = harga;
        }

        public string getName()
        {
            return this.nama;
        }

        public int getHarga()
        {
            return this.harga;
        }
    }
}
