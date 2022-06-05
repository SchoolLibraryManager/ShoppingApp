using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    internal class InternalVars
    {
        private static string toPurchase;
        internal static string ToPurchase { get { return toPurchase; } set { toPurchase = value; } }

        internal static List<string> PurchaseList = new List<string>();
    }
}
