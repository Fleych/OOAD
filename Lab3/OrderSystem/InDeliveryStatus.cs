using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    internal class InDeliveryStatus : Status
    {
        public string name = "В доставке";
        public override string GetName()
        {
            return name;
        }

        public override bool WorkDone(Order order, Client client, Storekeeper storekeeper, Courier courier)
        {
            order.status = new DoneStatus();
            client.message = "Ваш заказ номер: " + order.id + " доставлен!";
            courier.orders.Remove(order);
            return true;
        }

        public override bool PayOrder(Order order, Client client, Storekeeper storekeeper, Courier courier)
        {
            client.message = "Вы уже оплатили заказ номер: " + order.id;
            return false;
        }

        public override bool CancelOrder(Order order, Client client, Storekeeper storekeeper, Courier courier)
        {
            client.message = "Вы не можете отменить заказ номер: " + order.id + " так как он уже в доставке";
            return false;
        }
    }
}
