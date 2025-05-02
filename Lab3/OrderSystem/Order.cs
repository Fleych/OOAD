using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OrderSystem
{
    internal class Order
    {
        //With pattern
        public Status status { get; set; }
        public string goods { get; set; }
        public string adress { get; set; }
        public int id { get; set; }
        private static int count = 0;

        public Order(Status s, string g, string a) 
        { 
            status = s;
            goods = g;
            adress = a;
            id = count++;
        }

        public override string ToString()
        {
            return "Номер: " + id + " | " + " Товары: " + goods + " | " + "Адресс: " + adress + " | " + status.GetName();
        }

        public bool WorkDone(Client client, Storekeeper storekeeper, Courier courier)
        {
           return status.WorkDone(this, client, storekeeper, courier);
        }

        public bool PayOrder(Client client, Storekeeper storekeeper, Courier courier)
        {
            return status.PayOrder(this, client, storekeeper, courier);
        }

        public bool CancelOrder(Client client, Storekeeper storekeeper, Courier courier)
        {
            return status.CancelOrder(this, client, storekeeper, courier);
        }

        public bool DelayOrder(Client client, Storekeeper storekeeper, Courier courier)
        {
            return status.DelayOrder(this, client, storekeeper, courier);
        }
        public bool RefundOrder(Client client, Storekeeper storekeeper, Courier courier)
        {
            return status.RefundOrder(this, client, storekeeper, courier);
        }


        //Without pattern
        /*
        public string status { get; set; }
        public string goods { get; set; }
        public string adress { get; set; }
        public int id { get; set; }
        private static int count = 0;

        public Order(string s, string g, string a)
        {
            status = s;
            goods = g;
            adress = a;
            id = count++;
        }

        public override string ToString()
        {
            return "Номер: " + id + " | " + " Товары: " + goods + " | " + "Адресс: " + adress + " | " + status;
        }
        
        public bool WorkDone(Client client, Storekeeper storekeeper, Courier courier)
        {
           if (status == "Требуется оплата") 
           { 
                return false; 
           }
           if (status == "На складе")
           {
                status = "В доставке";
                client.message = "Ваш заказ номер: " + id + " собран и скоро будет доставлен";
                storekeeper.orders.Remove(this);
                courier.orders.Add(this);
                courier.message = "У вас новая задача - доставить заказ номер: " + id;
                return true; 
           }
           if (status == "В доставке")
           {
                status = "Выполнен";
                client.message = "Ваш заказ номер: " + id + " доставлен!";
                courier.orders.Remove(this);
                return true;
           }
           if (status == "Выполнен")
           {
                return false;
           }
           if (status == "Отменён")
           {
               return false;
           }
            return false;
        }

        public bool PayOrder(Client client, Storekeeper storekeeper, Courier courier)
        {
            if (status == "Требуется оплата")
            {
                status = "На складе";
                storekeeper.orders.Add(this);
                client.message = "Вы успешно оплатили заказ номер: " + id;
                storekeeper.message = "У вас новая задача - собрать заказ номер: " + id;
                return true;
            }
            if (status == "На складе")
            {
                client.message = "Вы уже оплатили заказ номер: " + id;
                return false;
            }
            if (status == "В доставке")
            {
                client.message = "Вы уже оплатили заказ номер: " + id;
                return false;
            }
            if (status == "Выполнен")
            {
                client.message = "Ваш заказ номер: " + id + " уже доставлен";
                return false;
            }
            if (status == "Отменён")
            {
                client.message = "Ваш заказ номер: " + id + " отменён";
                return false;
            }
            return false;
        }

        public bool CancelOrder(Client client, Storekeeper storekeeper, Courier courier)
        {
            if (status == "Требуется оплата")
            {
                status = "Отменён";
                client.message = "Вы отменили заказ номер: " + id;
                return true;
            }
            if (status == "На складе")
            {
                status = "Отменён";
                storekeeper.orders.Remove(this);
                client.message = "Вы отменили заказ номер: " + id;
                return true;
            }
            if (status == "В доставке")
            {
                client.message = "Вы не можете отменить заказ номер: " + id + " так как он уже в доставке";
                return false;
            }
            if (status == "Выполнен")
            {
                client.message = "Ваш заказ номер: " + id + " уже доставлен";
                return false;
            }
            if (status == "Отменён")
            {
                client.message = "Ваш заказ номер: " + id + " уже отменён";
                return false;
            }
            return false;
        }
        */
    }
}
