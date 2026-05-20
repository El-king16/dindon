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
    public partial class ItemControl : UserControl
    {
        Products this_product;
        Users? this_user;
        ProductPage this_productPage;

        private Color normalBackColor;
        private Label? label_finalPrice;

        public ItemControl(Products products, Users? users, ProductPage productPage)
        {

          
            this_user = users;
            this_product = products;
            this_productPage = productPage;

            InitializeComponent();
            if (users != null)
            {
                if (users.Role == "Администратор")
                {
                    edit_button.Visible = true;
                    delete_button.Visible = true;
                }
            }
            label_count.Text += products.Count.ToString();
            label_creater.Text += products.Creater.ToString();
            label_desc.Text += products.Description;
            label_provider.Text += products.Provider;
            label_discount.Text += products.Discount.ToString() + "%";
            label_name.Text = products.Category + " | " + products.Name;
            label_unit.Text += products.Unit;
            label_price.Text += products.Price.ToString();

            string photo = products.Photo;

            if (products.Photo == null)
            {
                photo = "picture.png";
            }

            PicturePhoto.ImageLocation = "C:\\Users\\knyaz\\Desktop\\import\\" + photo;

            ApplyDesign(products);
            ApplyDescriptionWrap();
            UpdateFinalPriceLocation();
        }

        private void ApplyDesign(Products products)
        {
            Color mainBackground = ColorTranslator.FromHtml("#FFFFFF");
            Color additionalBackground = ColorTranslator.FromHtml("#00FFFF");
            Color accentColor = ColorTranslator.FromHtml("#0000FF");
            Color discountBackground = ColorTranslator.FromHtml("#008080");
            Color notAvailableBackground = Color.Gray;

            this.BackColor = mainBackground;

            label_name.BackColor = Color.Transparent;
            label_desc.BackColor = Color.Transparent;
            label_creater.BackColor = Color.Transparent;
            label_provider.BackColor = Color.Transparent;
            label_price.BackColor = Color.Transparent;
            label_unit.BackColor = Color.Transparent;
            label_count.BackColor = Color.Transparent;
            label_discount.BackColor = Color.Transparent;

            if (products.Discount > 15)
            {
                normalBackColor = discountBackground;
            }
            else
            {
                normalBackColor = additionalBackground;
            }

            if (products.Count <= 0)
            {
                normalBackColor = notAvailableBackground;
            }

            this.BackColor = normalBackColor;

            this.MouseEnter += ItemControl_MouseEnter;
            this.MouseLeave += ItemControl_MouseLeave;

            foreach (Control control in this.Controls)
            {
                control.MouseEnter += ItemControl_MouseEnter;
                control.MouseLeave += ItemControl_MouseLeave;
            }

            edit_button.BackColor = accentColor;
            edit_button.ForeColor = Color.White;
            edit_button.FlatStyle = FlatStyle.Flat;
            edit_button.FlatAppearance.BorderSize = 0;

            delete_button.BackColor = accentColor;
            delete_button.ForeColor = Color.White;
            delete_button.FlatStyle = FlatStyle.Flat;
            delete_button.FlatAppearance.BorderSize = 0;

            if (products.Discount > 0)
            {
                int discount = products.Discount;
                double price = products.Price;
                double finalPrice = price - (price * discount / 100);

                label_price.Font = new Font(label_price.Font, FontStyle.Strikeout);
                label_price.ForeColor = Color.Red;

                label_finalPrice = new Label();
                label_finalPrice.AutoSize = true;
                label_finalPrice.Font = new Font(label_price.Font.FontFamily, label_price.Font.Size, FontStyle.Regular);
                label_finalPrice.ForeColor = Color.Black;
                label_finalPrice.BackColor = Color.Transparent;
                label_finalPrice.Text = " Итоговая цена: " + Math.Round(finalPrice, 2).ToString();

                label_finalPrice.MouseEnter += ItemControl_MouseEnter;
                label_finalPrice.MouseLeave += ItemControl_MouseLeave;

                this.Controls.Add(label_finalPrice);
                label_finalPrice.BringToFront();
            }
            else
            {
                label_price.ForeColor = Color.Black;
                label_price.Font = new Font(label_price.Font, FontStyle.Regular);
            }
        }

        private void ApplyDescriptionWrap()
        {
            label_desc.AutoSize = true;
            label_desc.MaximumSize = new Size(650, 0);

            int nextY = label_desc.Bottom + 5;

            label_creater.Location = new Point(label_creater.Location.X, nextY);
            label_provider.Location = new Point(label_provider.Location.X, label_creater.Bottom + 5);
            label_price.Location = new Point(label_price.Location.X, label_provider.Bottom + 5);
            label_unit.Location = new Point(label_unit.Location.X, label_price.Bottom + 5);
            label_count.Location = new Point(label_count.Location.X, label_unit.Bottom + 5);

            int minHeight = label_count.Bottom + 15;

            if (minHeight > this.Height)
            {
                this.Height = minHeight;
            }
        }

        private void UpdateFinalPriceLocation()
        {
            if (label_finalPrice != null)
            {
                label_finalPrice.Location = new Point(label_price.Right + 10, label_price.Top);
            }
        }

        private void ItemControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#0000FF");
        }

        private void ItemControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = normalBackColor;
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            ProductEditor productEditor = new ProductEditor(this_product, "Update", this_user);
            this_productPage.Visible = false;
            productEditor.Show();
            this_productPage.Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            using (var con = new DbConnection())
            {
                con.Remove(this_product);
                con.SaveChanges();
                this_productPage.LoadProducts();
            }
        }
    }
}