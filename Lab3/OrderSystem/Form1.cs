using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class Form1 : Form
    {
        private Client client = new Client();
        private Storekeeper storekeeper = new Storekeeper();
        private Courier courier = new Courier();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_new_order_Click(object sender, EventArgs e)
        {
            //With pattern
            
            Order new_order = new Order(new PaymentRequiredStatus(), textBox_goods.Text, textBox_adress.Text);

            //Without pattern
            /*
            Order new_order = new Order("Требуется оплата", textBox_goods.Text, textBox_adress.Text);
            */

            client.orders.Add(new_order);
            listBox_client.Items.Add(new_order);
        }

        private void button_pay_order_Click(object sender, EventArgs e)
        {
            Order selected_order = listBox_client.SelectedItem as Order;
            if (selected_order != null)
            {
                if (selected_order.PayOrder(client, storekeeper, courier))
                {
                    listBox_storekeeper.Items.Add(selected_order);

                    listBox_client.Items.Add(selected_order);
                    listBox_client.Items.Remove(selected_order);
                }
                label_storekeeper_message.Text = storekeeper.message;
                label_client_message.Text = client.message;
            }
        }

        private void button_cancel_order_Click(object sender, EventArgs e)
        {
            Order selected_order = listBox_client.SelectedItem as Order;
            if (selected_order != null)
            {
                if (selected_order.CancelOrder(client, storekeeper, courier))
                {
                    if (listBox_storekeeper.Items.Contains(selected_order))
                    {
                        listBox_storekeeper.Items.Remove(selected_order);
                    }

                    if (listBox_courier.Items.Contains(selected_order))
                    {
                        listBox_courier.Items.Remove(selected_order);
                    }

                    listBox_client.Items.Add(selected_order);
                    listBox_client.Items.Remove(selected_order);
                }
                label_client_message.Text = client.message;
            }
        }

        private void button_take_goods_Click(object sender, EventArgs e)
        {
            Order selected_order = listBox_storekeeper.SelectedItem as Order;
            if (selected_order != null)
            {
                if (selected_order.WorkDone(client, storekeeper, courier))
                {
                    listBox_storekeeper.Items.Remove(selected_order);
                    listBox_courier.Items.Add(selected_order);
                }
                listBox_client.Items.Add(selected_order);
                listBox_client.Items.Remove(selected_order);
                label_client_message.Text = client.message;
                label_courier_message.Text = courier.message;
            }
        }

        private void button_order_delivered_Click(object sender, EventArgs e)
        {
            Order selected_order = listBox_courier.SelectedItem as Order;
            if (selected_order != null)
            {
                if (selected_order.WorkDone(client, storekeeper, courier))
                {
                    listBox_courier.Items.Remove(selected_order);
                }
                listBox_client.Items.Add(selected_order);
                listBox_client.Items.Remove(selected_order);
                label_client_message.Text = client.message;
            }
        }
    }
}
