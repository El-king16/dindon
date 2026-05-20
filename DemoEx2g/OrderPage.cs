using DemoEx2g.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DemoEx2g
{
    public partial class OrderPage : Form
    {
        private int y = 0;
        Users this_users;
        public OrderPage(Users? users)
        {
            InitializeComponent();
            this_users = users;
            LoadOrders();
        }

        public void LoadOrders()
        {
            using (var con = new DbConnection())
            {
                panel_orders.Controls.Clear();
                y = 0;

                List<Order> orders = con.Orders.ToList();

                foreach (Order order in orders)
                {
                    PickupPoint? pickupPoint = con.PickupPoint.FirstOrDefault(p => p.Id == order.AddressId);

                    OrderControl orderControl = new OrderControl(order, pickupPoint, this);
                    orderControl.Location = new Point(0, y);

                    panel_orders.Controls.Add(orderControl);

                    y += orderControl.Height + 10;
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            OrderEditor orderEditor = new OrderEditor(null, "Add", this);
            orderEditor.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductPage productPage = new ProductPage(this_users);
            this.Visible = false;
            productPage.Show();
            this.Close();

        }
    }
}