using DemoEx2g.Models;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoEx2g
{
    public partial class OrderControl : UserControl
    {
        private Order this_order;
        private PickupPoint? this_pickupPoint;
        private OrderPage this_orderPage;

        private Color normalColor = ColorTranslator.FromHtml("#00FFFF");
        private Color hoverColor = ColorTranslator.FromHtml("#0000FF");

        public OrderControl(Order order, PickupPoint? pickupPoint, OrderPage orderPage)
        {
            this_order = order;
            this_pickupPoint = pickupPoint;
            this_orderPage = orderPage;

            InitializeComponent();
            FillData();
            ApplyDesign();
        }

        private void FillData()
        {
            string address = "Адрес не найден";

            if (this_pickupPoint != null)
            {
                address = this_pickupPoint.Address;
            }

            label_id.Text = "Номер заказа: " + this_order.Id.ToString();
            label_article.Text = "Товары:\n" + FormatArticleOrder(this_order.ArticleOrder);
            label_dateOrder.Text = "Дата заказа: " + this_order.DateOrder;
            label_dateDelivery.Text = "Дата доставки: " + this_order.DateDelivery;
            label_address.Text = "Пункт выдачи: " + address;
            label_client.Text = "Клиент: " + this_order.FullnameClient;
            label_code.Text = "Код получения: " + this_order.Code.ToString();
            label_status.Text = "Статус: " + this_order.Status;

            int bottom = label_article.Bottom;

            if (bottom < 70)
            {
                bottom = 70;
            }

            label_dateOrder.Location = new Point(label_dateOrder.Location.X, bottom + 10);
            label_dateDelivery.Location = new Point(label_dateDelivery.Location.X, label_dateOrder.Bottom + 5);
            label_address.Location = new Point(label_address.Location.X, label_dateDelivery.Bottom + 5);
            label_client.Location = new Point(label_client.Location.X, label_address.Bottom + 5);

            edit_button.Location = new Point(edit_button.Location.X, label_client.Bottom + 10);
            delete_button.Location = new Point(delete_button.Location.X, label_client.Bottom + 10);

            int newHeight = edit_button.Bottom + 15;

            if (newHeight < 170)
            {
                newHeight = 170;
            }

            this.Height = newHeight;
        }

        private string FormatArticleOrder(string articleOrder)
        {
            if (string.IsNullOrWhiteSpace(articleOrder))
            {
                return "Нет товаров";
            }

            string[] parts = articleOrder.Split(',');

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < parts.Length; i += 2)
            {
                string article = parts[i].Trim();
                string count = "1";

                if (i + 1 < parts.Length)
                {
                    count = parts[i + 1].Trim();
                }

                result.AppendLine("Артикул: " + article + " | Кол-во: " + count);
            }

            return result.ToString();
        }

        private void ApplyDesign()
        {
            BackColor = normalColor;

            label_id.BackColor = Color.Transparent;
            label_article.BackColor = Color.Transparent;
            label_dateOrder.BackColor = Color.Transparent;
            label_dateDelivery.BackColor = Color.Transparent;
            label_address.BackColor = Color.Transparent;
            label_client.BackColor = Color.Transparent;
            label_code.BackColor = Color.Transparent;
            label_status.BackColor = Color.Transparent;

            edit_button.BackColor = hoverColor;
            edit_button.ForeColor = Color.White;
            edit_button.FlatStyle = FlatStyle.Flat;
            edit_button.FlatAppearance.BorderSize = 0;

            delete_button.BackColor = hoverColor;
            delete_button.ForeColor = Color.White;
            delete_button.FlatStyle = FlatStyle.Flat;
            delete_button.FlatAppearance.BorderSize = 0;

            MouseEnter += OrderControl_MouseEnter;
            MouseLeave += OrderControl_MouseLeave;

            foreach (Control control in Controls)
            {
                control.MouseEnter += OrderControl_MouseEnter;
                control.MouseLeave += OrderControl_MouseLeave;
            }
        }

        private void OrderControl_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = hoverColor;
        }

        private void OrderControl_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = normalColor;
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            OrderEditor orderEditor = new OrderEditor(this_order, "Update", this_orderPage);
            orderEditor.ShowDialog();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            OrderEditor orderEditor = new OrderEditor(this_order, "Delete", this_orderPage);
            orderEditor.ShowDialog();
        }
    }
}