using DemoEx2g.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEx2g
{
    public partial class ProductEditor : Form
    {
        string this_action = "";
        Products this_product = new Products();
        Users? this_users;

        public ProductEditor(Products? product, string action, Users? users)
        {
            this_action = action;

            if (product != null)
            {
                this_product = product;
            }

            this_users = users;

            InitializeComponent();

            if (product != null)
            {
                box_category.Text = product.Category;
                box_name.Text = product.Name;
                box_desc.Text = product.Description;
                box_photo.Text = product.Photo;
                box_provider.Text = product.Provider;
                box_creater.Text = product.Creater;
                box_article.Text = product.Article;
                box_unit.Text = product.Unit;

                box_count.Text = product.Count.ToString();
                box_discount.Text = product.Discount.ToString();
                box_price.Text = product.Price.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count;
            int discount;
            double price;

            if (!int.TryParse(box_count.Text, out count))
            {
                MessageBox.Show(
                    "Количество должно быть целым числом.",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            if (!int.TryParse(box_discount.Text, out discount))
            {
                MessageBox.Show(
                    "Скидка должна быть целым числом.",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!double.TryParse(box_price.Text, out price))
            {
                MessageBox.Show(
                    "Цена должна быть числом целым или с плавающей запятой.",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (this_action == "Create")
            {
                this_product = new Products();
            }

            this_product.Category = box_category.Text;
            this_product.Creater = box_creater.Text;
            this_product.Description = box_desc.Text;
            this_product.Provider = box_provider.Text;
            this_product.Photo = box_photo.Text;
            this_product.Name = box_name.Text;
            this_product.Article = box_article.Text;
            this_product.Unit = box_unit.Text;

            this_product.Count = count;
            this_product.Discount = discount;
            this_product.Price = price;

            using (var con = new DbConnection())
            {
                if (this_action == "Update")
                {
                    con.Update(this_product);
                    con.SaveChanges();
                }
                else
                {
                    con.Add(this_product);
                    con.SaveChanges();
                }
            }

            MessageBox.Show(
                "Данные сохранены.",
                "Готово",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ProductPage productPage = new ProductPage(this_users);
            productPage.Show();
            this.Close();
        }
    }
}