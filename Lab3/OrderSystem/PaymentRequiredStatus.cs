using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    internal class PaymentRequiredStatus : Status
    {
        public string name = "Требуется оплата";

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
            order.status = new InStorageStatus();
            storekeeper.orders.Add(order);
            client.message = "Вы успешно оплатили заказ номер: " + order.id;
            storekeeper.message = "У вас новая задача - собрать заказ номер: " + order.id;
            return true;
        }

        public override bool CancelOrder(Order order, Client client, Storekeeper storekeeper, Courier courier)
        {
            order.status = new CanceledStatus();
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
