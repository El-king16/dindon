using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductPage productPage = new ProductPage(null);
            productPage.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var con = new DbConnection())
            {
                var user = con.Users.FirstOrDefault(p =>
                    p.Email == email_box.Text &&
                    p.Password == password_box.Text
                );

                if (user != null)
                {
                    ProductPage productPage = new ProductPage(user);
                    productPage.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Неверный email или пароль",
                        "Ошибка входа",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
    }
}
