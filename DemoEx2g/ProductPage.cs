using DemoEx2g.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DemoEx2g
{
    public partial class ProductPage : Form
    {
        string sortCount = "desc";
        bool sortCountClicked = false;

        string sortPrice = "desc";
        bool sortPriceClicked = false;

        int y = 0;

        Users this_users;

        public ProductPage(Users? users)
        {
            InitializeComponent();
            if (users != null)
            {
                this_users = users;
                fullname_user.Text = users.Fullname;
                if (users.Role == "Менеджер")
                {
                    button3.Visible = false;
                    button4.Visible = false;
                }
            }

            if (users == null)
            {
                button3.Visible = false;
                button4.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                search_box.Visible = false;
                discount_filter.Visible = false;
                label1.Visible = false;
                label_filter.Visible = false;
                Search.Visible = false;
            }




            LoadProducts();
        }

        public void LoadProducts()
        {
            using (var con = new DbConnection())
            {
                panel_products.Controls.Clear();
                y = 0;

                List<Products> products = con.Products.ToList();

                string searchText = search_box.Text.Trim();

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    products = products.Where(p =>
                        p.Name.Contains(searchText) ||
                        (p.Description != null && p.Description.Contains(searchText)) ||
                        p.Provider.Contains(searchText) ||
                        p.Creater.Contains(searchText) ||
                        p.Article.Contains(searchText) ||
                        p.Category.Contains(searchText)
                    ).ToList();
                }

                if (discount_filter.SelectedIndex == 1)
                {
                    products = products.Where(p => p.Discount >= 0 && p.Discount < 13).ToList();
                }
                else if (discount_filter.SelectedIndex == 2)
                {
                    products = products.Where(p => p.Discount >= 13 && p.Discount < 17).ToList();
                }
                else if (discount_filter.SelectedIndex == 3)
                {
                    products = products.Where(p => p.Discount >= 17).ToList();
                }

                if (sortPriceClicked)
                {
                    if (sortPrice == "desc")
                    {
                        products = products.OrderByDescending(p => p.Price).ToList();
                    }
                    else
                    {
                        products = products.OrderBy(p => p.Price).ToList();
                    }
                }
                else if (sortCountClicked)
                {
                    if (sortCount == "desc")
                    {
                        products = products.OrderByDescending(p => p.Count).ToList();
                    }
                    else
                    {
                        products = products.OrderBy(p => p.Count).ToList();
                    }
                }

                foreach (var product in products)
                {
                    ItemControl itemControl = new ItemControl(product, this_users, this);
                    itemControl.Location = new Point(0, y);
                    panel_products.Controls.Add(itemControl);
                    y += 300;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sortPriceClicked = true;
            sortCountClicked = false;

            if (sortPrice == "desc")
            {
                sortPrice = "asc";
            }
            else
            {
                sortPrice = "desc";
            }

            LoadProducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sortCountClicked = true;
            sortPriceClicked = false;

            if (sortCount == "desc")
            {
                sortCount = "asc";
            }
            else
            {
                sortCount = "desc";
            }

            LoadProducts();
        }

        private void discount_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ProductEditor productEditor = new ProductEditor(null, "Create", this_users);
            productEditor.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Visible = false;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrderPage orderPage = new OrderPage(this_users);
            orderPage.Show();
            this.Visible = false;
            this.Close();
        }
    }
}