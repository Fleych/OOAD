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
        public override bool DelayOrder(Order order, Client client, Storekeeper storekeeper, Courier courier)
        {
            order.status = new InDeliveryStatus();
            client.message = "Ваш заказ номер " + order.id + " задерживается, мы вернём вам 5% от стоимости заказа";
            courier.message = "За задержку заказа номер " + order.id + " вы будете оштрафованы на много деняг";
            return true;
        }
        public override bool RefundOrder(Order order, Client client, Storekeeper storekeeper, Courier courier)
        {
            order.status = new CanceledStatus();
            client.message = "Ваш заказ номер " + order.id + " не может быть доставлен, мы вернём вам деньги в течени 3 дней";
            courier.message = "Заказ нормер: " + order.id + " отменён, свяжитесь с менеджером для прояснения ситуации";
            return true;
        }
    }
}
