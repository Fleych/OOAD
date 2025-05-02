namespace OrderSystem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_client = new System.Windows.Forms.ListBox();
            this.label_client = new System.Windows.Forms.Label();
            this.label_storekeeper = new System.Windows.Forms.Label();
            this.listBox_storekeeper = new System.Windows.Forms.ListBox();
            this.label_courier = new System.Windows.Forms.Label();
            this.listBox_courier = new System.Windows.Forms.ListBox();
            this.button_new_order = new System.Windows.Forms.Button();
            this.button_cancel_order = new System.Windows.Forms.Button();
            this.button_take_goods = new System.Windows.Forms.Button();
            this.button_order_delivered = new System.Windows.Forms.Button();
            this.button_pay_order = new System.Windows.Forms.Button();
            this.textBox_goods = new System.Windows.Forms.TextBox();
            this.textBox_adress = new System.Windows.Forms.TextBox();
            this.label_goods = new System.Windows.Forms.Label();
            this.label_adress = new System.Windows.Forms.Label();
            this.label_client_message = new System.Windows.Forms.Label();
            this.label_storekeeper_message = new System.Windows.Forms.Label();
            this.label_courier_message = new System.Windows.Forms.Label();
            this.button_order_delayed = new System.Windows.Forms.Button();
            this.button_order_impossible = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_client
            // 
            this.listBox_client.FormattingEnabled = true;
            this.listBox_client.Location = new System.Drawing.Point(15, 25);
            this.listBox_client.Name = "listBox_client";
            this.listBox_client.Size = new System.Drawing.Size(448, 303);
            this.listBox_client.TabIndex = 0;
            // 
            // label_client
            // 
            this.label_client.AutoSize = true;
            this.label_client.Location = new System.Drawing.Point(12, 9);
            this.label_client.Name = "label_client";
            this.label_client.Size = new System.Drawing.Size(43, 13);
            this.label_client.TabIndex = 1;
            this.label_client.Text = "Клиент";
            // 
            // label_storekeeper
            // 
            this.label_storekeeper.AutoSize = true;
            this.label_storekeeper.Location = new System.Drawing.Point(466, 9);
            this.label_storekeeper.Name = "label_storekeeper";
            this.label_storekeeper.Size = new System.Drawing.Size(65, 13);
            this.label_storekeeper.TabIndex = 2;
            this.label_storekeeper.Text = "Кладовщик";
            // 
            // listBox_storekeeper
            // 
            this.listBox_storekeeper.FormattingEnabled = true;
            this.listBox_storekeeper.Location = new System.Drawing.Point(469, 25);
            this.listBox_storekeeper.Name = "listBox_storekeeper";
            this.listBox_storekeeper.Size = new System.Drawing.Size(448, 303);
            this.listBox_storekeeper.TabIndex = 3;
            // 
            // label_courier
            // 
            this.label_courier.AutoSize = true;
            this.label_courier.Location = new System.Drawing.Point(920, 9);
            this.label_courier.Name = "label_courier";
            this.label_courier.Size = new System.Drawing.Size(43, 13);
            this.label_courier.TabIndex = 4;
            this.label_courier.Text = "Курьер";
            // 
            // listBox_courier
            // 
            this.listBox_courier.FormattingEnabled = true;
            this.listBox_courier.Location = new System.Drawing.Point(923, 25);
            this.listBox_courier.Name = "listBox_courier";
            this.listBox_courier.Size = new System.Drawing.Size(448, 303);
            this.listBox_courier.TabIndex = 5;
            // 
            // button_new_order
            // 
            this.button_new_order.Location = new System.Drawing.Point(15, 415);
            this.button_new_order.Name = "button_new_order";
            this.button_new_order.Size = new System.Drawing.Size(136, 41);
            this.button_new_order.TabIndex = 6;
            this.button_new_order.Text = "Новый заказ";
            this.button_new_order.UseVisualStyleBackColor = true;
            this.button_new_order.Click += new System.EventHandler(this.button_new_order_Click);
            // 
            // button_cancel_order
            // 
            this.button_cancel_order.Location = new System.Drawing.Point(310, 415);
            this.button_cancel_order.Name = "button_cancel_order";
            this.button_cancel_order.Size = new System.Drawing.Size(153, 43);
            this.button_cancel_order.TabIndex = 7;
            this.button_cancel_order.Text = "Отменить заказ";
            this.button_cancel_order.UseVisualStyleBackColor = true;
            this.button_cancel_order.Click += new System.EventHandler(this.button_cancel_order_Click);
            // 
            // button_take_goods
            // 
            this.button_take_goods.Location = new System.Drawing.Point(469, 412);
            this.button_take_goods.Name = "button_take_goods";
            this.button_take_goods.Size = new System.Drawing.Size(448, 44);
            this.button_take_goods.TabIndex = 8;
            this.button_take_goods.Text = "Товары взяты со склада";
            this.button_take_goods.UseVisualStyleBackColor = true;
            this.button_take_goods.Click += new System.EventHandler(this.button_take_goods_Click);
            // 
            // button_order_delivered
            // 
            this.button_order_delivered.Location = new System.Drawing.Point(923, 414);
            this.button_order_delivered.Name = "button_order_delivered";
            this.button_order_delivered.Size = new System.Drawing.Size(139, 44);
            this.button_order_delivered.TabIndex = 9;
            this.button_order_delivered.Text = "Заказ доставлен";
            this.button_order_delivered.UseVisualStyleBackColor = true;
            this.button_order_delivered.Click += new System.EventHandler(this.button_order_delivered_Click);
            // 
            // button_pay_order
            // 
            this.button_pay_order.Location = new System.Drawing.Point(157, 415);
            this.button_pay_order.Name = "button_pay_order";
            this.button_pay_order.Size = new System.Drawing.Size(147, 43);
            this.button_pay_order.TabIndex = 10;
            this.button_pay_order.Text = "Оплатить заказ";
            this.button_pay_order.UseVisualStyleBackColor = true;
            this.button_pay_order.Click += new System.EventHandler(this.button_pay_order_Click);
            // 
            // textBox_goods
            // 
            this.textBox_goods.Location = new System.Drawing.Point(91, 360);
            this.textBox_goods.Name = "textBox_goods";
            this.textBox_goods.Size = new System.Drawing.Size(372, 20);
            this.textBox_goods.TabIndex = 11;
            // 
            // textBox_adress
            // 
            this.textBox_adress.Location = new System.Drawing.Point(91, 391);
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(372, 20);
            this.textBox_adress.TabIndex = 12;
            // 
            // label_goods
            // 
            this.label_goods.AutoSize = true;
            this.label_goods.Location = new System.Drawing.Point(20, 363);
            this.label_goods.Name = "label_goods";
            this.label_goods.Size = new System.Drawing.Size(49, 13);
            this.label_goods.TabIndex = 13;
            this.label_goods.Text = "Товары:";
            // 
            // label_adress
            // 
            this.label_adress.AutoSize = true;
            this.label_adress.Location = new System.Drawing.Point(20, 398);
            this.label_adress.Name = "label_adress";
            this.label_adress.Size = new System.Drawing.Size(47, 13);
            this.label_adress.TabIndex = 14;
            this.label_adress.Text = "Адресс:";
            // 
            // label_client_message
            // 
            this.label_client_message.AutoSize = true;
            this.label_client_message.Location = new System.Drawing.Point(20, 340);
            this.label_client_message.Name = "label_client_message";
            this.label_client_message.Size = new System.Drawing.Size(0, 13);
            this.label_client_message.TabIndex = 15;
            // 
            // label_storekeeper_message
            // 
            this.label_storekeeper_message.AutoSize = true;
            this.label_storekeeper_message.Location = new System.Drawing.Point(475, 340);
            this.label_storekeeper_message.Name = "label_storekeeper_message";
            this.label_storekeeper_message.Size = new System.Drawing.Size(0, 13);
            this.label_storekeeper_message.TabIndex = 16;
            // 
            // label_courier_message
            // 
            this.label_courier_message.AutoSize = true;
            this.label_courier_message.Location = new System.Drawing.Point(930, 340);
            this.label_courier_message.Name = "label_courier_message";
            this.label_courier_message.Size = new System.Drawing.Size(0, 13);
            this.label_courier_message.TabIndex = 17;
            // 
            // button_order_delayed
            // 
            this.button_order_delayed.Location = new System.Drawing.Point(1077, 414);
            this.button_order_delayed.Name = "button_order_delayed";
            this.button_order_delayed.Size = new System.Drawing.Size(139, 44);
            this.button_order_delayed.TabIndex = 18;
            this.button_order_delayed.Text = "Доставка задержится";
            this.button_order_delayed.UseVisualStyleBackColor = true;
            this.button_order_delayed.Click += new System.EventHandler(this.button_order_delayed_Click);
            // 
            // button_order_impossible
            // 
            this.button_order_impossible.Location = new System.Drawing.Point(1232, 414);
            this.button_order_impossible.Name = "button_order_impossible";
            this.button_order_impossible.Size = new System.Drawing.Size(139, 44);
            this.button_order_impossible.TabIndex = 19;
            this.button_order_impossible.Text = "Доставка не возможна";
            this.button_order_impossible.UseVisualStyleBackColor = true;
            this.button_order_impossible.Click += new System.EventHandler(this.button_order_impossible_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 474);
            this.Controls.Add(this.button_order_impossible);
            this.Controls.Add(this.button_order_delayed);
            this.Controls.Add(this.label_courier_message);
            this.Controls.Add(this.label_storekeeper_message);
            this.Controls.Add(this.label_client_message);
            this.Controls.Add(this.label_adress);
            this.Controls.Add(this.label_goods);
            this.Controls.Add(this.textBox_adress);
            this.Controls.Add(this.textBox_goods);
            this.Controls.Add(this.button_pay_order);
            this.Controls.Add(this.button_order_delivered);
            this.Controls.Add(this.button_take_goods);
            this.Controls.Add(this.button_cancel_order);
            this.Controls.Add(this.button_new_order);
            this.Controls.Add(this.listBox_courier);
            this.Controls.Add(this.label_courier);
            this.Controls.Add(this.listBox_storekeeper);
            this.Controls.Add(this.label_storekeeper);
            this.Controls.Add(this.label_client);
            this.Controls.Add(this.listBox_client);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_client;
        private System.Windows.Forms.Label label_client;
        private System.Windows.Forms.Label label_storekeeper;
        private System.Windows.Forms.ListBox listBox_storekeeper;
        private System.Windows.Forms.Label label_courier;
        private System.Windows.Forms.ListBox listBox_courier;
        private System.Windows.Forms.Button button_new_order;
        private System.Windows.Forms.Button button_cancel_order;
        private System.Windows.Forms.Button button_take_goods;
        private System.Windows.Forms.Button button_order_delivered;
        private System.Windows.Forms.Button button_pay_order;
        private System.Windows.Forms.TextBox textBox_goods;
        private System.Windows.Forms.TextBox textBox_adress;
        private System.Windows.Forms.Label label_goods;
        private System.Windows.Forms.Label label_adress;
        private System.Windows.Forms.Label label_client_message;
        private System.Windows.Forms.Label label_storekeeper_message;
        private System.Windows.Forms.Label label_courier_message;
        private System.Windows.Forms.Button button_order_delayed;
        private System.Windows.Forms.Button button_order_impossible;
    }
}

