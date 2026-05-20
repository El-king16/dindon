using DemoEx2g.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DemoEx2g
{
    public partial class OrderEditor : Form
    {
        private Order? this_order;
        private string mode;
        private OrderPage this_orderPage;

        public OrderEditor(Order? order, string mode, OrderPage orderPage)
        {
            this_order = order;
            this.mode = mode;
            this_orderPage = orderPage;

            InitializeComponent();
            LoadPickupPoints();
            ApplyMode();

            if (this_order != null)
            {
                FillData();
            }
        }

        private void LoadPickupPoints()
        {
            using (var con = new DbConnection())
            {
                List<PickupPoint> pickupPoints = con.PickupPoint.ToList();

                address_box.DataSource = pickupPoints;
                address_box.DisplayMember = "Address";
                address_box.ValueMember = "Id";
            }
        }

        private void FillData()
        {
            if (this_order == null)
            {
                return;
            }

            articleOrder_box.Text = this_order.ArticleOrder;
            dateOrder_box.Text = this_order.DateOrder;
            dateDelivery_box.Text = this_order.DateDelivery;
            client_box.Text = this_order.FullnameClient;
            code_box.Text = this_order.Code.ToString();
            status_box.Text = this_order.Status;
            address_box.SelectedValue = this_order.AddressId;
        }

        private void ApplyMode()
        {
            if (mode == "Add")
            {
                Text = "Добавление заказа";
                save_button.Text = "Добавить";
            }
            else if (mode == "Update")
            {
                Text = "Изменение заказа";
                save_button.Text = "Сохранить";
            }
            else if (mode == "Delete")
            {
                Text = "Удаление заказа";
                save_button.Text = "Удалить";

                articleOrder_box.Enabled = false;
                dateOrder_box.Enabled = false;
                dateDelivery_box.Enabled = false;
                address_box.Enabled = false;
                client_box.Enabled = false;
                code_box.Enabled = false;
                status_box.Enabled = false;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {
                AddOrder();
            }
            else if (mode == "Update")
            {
                UpdateOrder();
            }
            else if (mode == "Delete")
            {
                DeleteOrder();
            }
        }

        private bool CheckFields()
        {
            if (string.IsNullOrWhiteSpace(articleOrder_box.Text) ||
                string.IsNullOrWhiteSpace(dateOrder_box.Text) ||
                string.IsNullOrWhiteSpace(dateDelivery_box.Text) ||
                string.IsNullOrWhiteSpace(client_box.Text) ||
                string.IsNullOrWhiteSpace(code_box.Text) ||
                string.IsNullOrWhiteSpace(status_box.Text))
            {
                MessageBox.Show(
                    "Заполните все поля.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }

            int code;

            if (!int.TryParse(code_box.Text, out code))
            {
                MessageBox.Show(
                    "Код должен быть числом.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }

            if (!CheckArticleOrderFormat(articleOrder_box.Text))
            {
                MessageBox.Show(
                    "Товары должны быть записаны в формате:\n\nА112Т4, 2, G843H5, 2\n\nТо есть артикул, количество, артикул, количество.",
                    "Ошибка формата товаров",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }

            return true;
        }

        private bool CheckArticleOrderFormat(string articleOrder)
        {
            string[] parts = articleOrder.Split(',');

            if (parts.Length < 2)
            {
                return false;
            }

            if (parts.Length % 2 != 0)
            {
                return false;
            }

            for (int i = 0; i < parts.Length; i += 2)
            {
                string article = parts[i].Trim();
                string countText = parts[i + 1].Trim();

                if (string.IsNullOrWhiteSpace(article))
                {
                    return false;
                }

                int count;

                if (!int.TryParse(countText, out count))
                {
                    return false;
                }

                if (count <= 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void AddOrder()
        {
            if (!CheckFields())
            {
                return;
            }

            int code = Convert.ToInt32(code_box.Text);

            using (var con = new DbConnection())
            {
                Order order = new Order();

                order.ArticleOrder = articleOrder_box.Text;
                order.DateOrder = dateOrder_box.Text;
                order.DateDelivery = dateDelivery_box.Text;
                order.AddressId = Convert.ToInt32(address_box.SelectedValue);
                order.FullnameClient = client_box.Text;
                order.Code = code;
                order.Status = status_box.Text;

                con.Orders.Add(order);
                con.SaveChanges();
            }

            this_orderPage.LoadOrders();

            MessageBox.Show(
                "Заказ добавлен.",
                "Готово",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Close();
        }

        private void UpdateOrder()
        {
            if (!CheckFields())
            {
                return;
            }

            if (this_order == null)
            {
                MessageBox.Show(
                    "Заказ не выбран.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            int code = Convert.ToInt32(code_box.Text);

            using (var con = new DbConnection())
            {
                Order? order = con.Orders.FirstOrDefault(o => o.Id == this_order.Id);

                if (order == null)
                {
                    MessageBox.Show(
                        "Заказ не найден.",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                order.ArticleOrder = articleOrder_box.Text;
                order.DateOrder = dateOrder_box.Text;
                order.DateDelivery = dateDelivery_box.Text;
                order.AddressId = Convert.ToInt32(address_box.SelectedValue);
                order.FullnameClient = client_box.Text;
                order.Code = code;
                order.Status = status_box.Text;

                con.SaveChanges();
            }

            this_orderPage.LoadOrders();

            MessageBox.Show(
                "Заказ изменён.",
                "Готово",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Close();
        }

        private void DeleteOrder()
        {
            if (this_order == null)
            {
                MessageBox.Show(
                    "Заказ не выбран.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "Вы точно хотите удалить этот заказ?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            using (var con = new DbConnection())
            {
                Order? order = con.Orders.FirstOrDefault(o => o.Id == this_order.Id);

                if (order == null)
                {
                    MessageBox.Show(
                        "Заказ не найден.",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                con.Orders.Remove(order);
                con.SaveChanges();
            }

            this_orderPage.LoadOrders();

            MessageBox.Show(
                "Заказ удалён.",
                "Готово",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}