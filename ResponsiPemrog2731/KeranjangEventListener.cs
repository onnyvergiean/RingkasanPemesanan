using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrog2731
{
    interface KeranjangEventListener
    {
        void onSucceed(string message);
        void onFailed(String message);
    }
}
