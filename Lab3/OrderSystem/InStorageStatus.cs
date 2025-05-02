using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    internal class InStorageStatus : Status
    {
        public string name = "На складе";
        public override string GetName()
        {
            return name;
        }
        public override bool WorkDone(Order order, Client client, Storekeeper storekeeper, Courier courier)
        {
            order.status = new InDeliveryStatus();
            client.message = "Ваш заказ номер: " + order.id + " собран и скоро будет доставлен";
            storekeeper.orders.Remove(order);
            courier.orders.Add(order);
            courier.message = "У вас новая задача - доставить заказ номер: " + order.id;
            return true;
        }

        public override bool PayOrder(Order order, Client client, Storekeeper storekeeper, Courier courier)
        {
            client.message = "Вы уже оплатили заказ номер: " + order.id;
            return false;
        }

        public override bool CancelOrder(Order order, Client client, Storekeeper storekeeper, Courier courier)
        {
            order.status = new CanceledStatus();
            storekeeper.orders.Remove(order);
            client.message = "Вы отменили заказ номер: " + order.id;
            return true;
        }
        public override bool DelayOrder(Order order, Client client, Storekeeper storekeeper, Courier courier)
        {
            return false;
        }
        public override bool RefundOrder(Order order, Client client, Storekeeper storekeeper, Courier courier)
        {
            return false;
        }
    }
}
