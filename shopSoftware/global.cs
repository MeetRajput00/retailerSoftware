using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopSoftware
{
    static class global
    {
        private static int charges= 0;

        public static int GlobalCharges
        {
            get { return charges; }
            set { charges = value; }
        }
    }
}
