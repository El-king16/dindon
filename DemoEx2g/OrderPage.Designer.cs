namespace DemoEx2g
{
    partial class OrderPage
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panel_orders;
        private Button add_button;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel_orders = new Panel();
            add_button = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel_orders
            // 
            panel_orders.AutoScroll = true;
            panel_orders.BackColor = Color.White;
            panel_orders.Location = new Point(10, 55);
            panel_orders.Name = "panel_orders";
            panel_orders.Size = new Size(926, 446);
            panel_orders.TabIndex = 1;
            // 
            // add_button
            // 
            add_button.BackColor = Color.FromArgb(0, 0, 255);
            add_button.FlatStyle = FlatStyle.Flat;
            add_button.ForeColor = Color.White;
            add_button.Location = new Point(10, 10);
            add_button.Name = "add_button";
            add_button.Size = new Size(150, 35);
            add_button.TabIndex = 0;
            add_button.Text = "Добавить заказ";
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += add_button_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(175, 10);
            button1.Name = "button1";
            button1.Size = new Size(150, 35);
            button1.TabIndex = 2;
            button1.Text = "Назад к товарам";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // OrderPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(946, 511);
            Controls.Add(button1);
            Controls.Add(panel_orders);
            Controls.Add(add_button);
            Name = "OrderPage";
            Text = "Заказы";
            ResumeLayout(false);
        }

        private Button button1;
    }
}