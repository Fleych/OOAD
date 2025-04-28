using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    internal class CanceledStatus : Status
    {
        public string name = "Отменён";
        public override string GetName()
        {
            return name;
        }

        public override bool WorkDone(Order order, Client client, Storekeeper storekeeper, Courier courier)
        {
            return false;
        }

        public override bool PayOrder(Order order, Client client, Storekeeper storekeeper, Courier courier)
        {
            client.message = "Ваш заказ номер: " + order.id + " отменён";
            return false;
        }

        public override bool CancelOrder(Order order, Client client, Storekeeper storekeeper, Courier courier)
        {
            client.message = "Ваш заказ номер: " + order.id + " уже отменён";
            return false;
        }
    }
}
