using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    internal abstract class Status
    {
        public abstract string GetName();
        public abstract bool WorkDone(Order order, Client client, Storekeeper storekeeper, Courier courier);
        public abstract bool PayOrder(Order order, Client client, Storekeeper storekeeper, Courier courier);
        public abstract bool CancelOrder(Order order, Client client, Storekeeper storekeeper, Courier courier);
    }
}
