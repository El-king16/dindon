namespace DemoEx2g
{
    partial class OrderControl
    {
        private System.ComponentModel.IContainer components = null;

        private Label label_id;
        private Label label_article;
        private Label label_dateOrder;
        private Label label_dateDelivery;
        private Label label_address;
        private Label label_client;
        private Label label_code;
        private Label label_status;

        private Button edit_button;
        private Button delete_button;

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
            label_id = new Label();
            label_article = new Label();
            label_dateOrder = new Label();
            label_dateDelivery = new Label();
            label_address = new Label();
            label_client = new Label();
            label_code = new Label();
            label_status = new Label();
            edit_button = new Button();
            delete_button = new Button();
            SuspendLayout();

            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new Point(10, 10);
            label_id.Name = "label_id";
            label_id.Size = new Size(90, 15);
            label_id.TabIndex = 0;
            label_id.Text = "Номер заказа:";

            // 
            // label_article
            // 
            label_article.AutoSize = true;
            label_article.Location = new Point(10, 35);
            label_article.MaximumSize = new Size(650, 0);
            label_article.Name = "label_article";
            label_article.Size = new Size(51, 15);
            label_article.TabIndex = 1;
            label_article.Text = "Товары:";

            // 
            // label_dateOrder
            // 
            label_dateOrder.AutoSize = true;
            label_dateOrder.Location = new Point(10, 80);
            label_dateOrder.Name = "label_dateOrder";
            label_dateOrder.Size = new Size(77, 15);
            label_dateOrder.TabIndex = 2;
            label_dateOrder.Text = "Дата заказа:";

            // 
            // label_dateDelivery
            // 
            label_dateDelivery.AutoSize = true;
            label_dateDelivery.Location = new Point(10, 105);
            label_dateDelivery.Name = "label_dateDelivery";
            label_dateDelivery.Size = new Size(92, 15);
            label_dateDelivery.TabIndex = 3;
            label_dateDelivery.Text = "Дата доставки:";

            // 
            // label_address
            // 
            label_address.AutoSize = true;
            label_address.Location = new Point(10, 130);
            label_address.MaximumSize = new Size(650, 0);
            label_address.Name = "label_address";
            label_address.Size = new Size(84, 15);
            label_address.TabIndex = 4;
            label_address.Text = "Пункт выдачи:";

            // 
            // label_client
            // 
            label_client.AutoSize = true;
            label_client.Location = new Point(10, 155);
            label_client.Name = "label_client";
            label_client.Size = new Size(49, 15);
            label_client.TabIndex = 5;
            label_client.Text = "Клиент:";

            // 
            // label_code
            // 
            label_code.AutoSize = true;
            label_code.Location = new Point(500, 10);
            label_code.Name = "label_code";
            label_code.Size = new Size(88, 15);
            label_code.TabIndex = 6;
            label_code.Text = "Код получения:";

            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.Location = new Point(500, 35);
            label_status.Name = "label_status";
            label_status.Size = new Size(45, 15);
            label_status.TabIndex = 7;
            label_status.Text = "Статус:";

            // 
            // edit_button
            // 
            edit_button.Location = new Point(700, 125);
            edit_button.Name = "edit_button";
            edit_button.Size = new Size(85, 30);
            edit_button.TabIndex = 8;
            edit_button.Text = "Изменить";
            edit_button.UseVisualStyleBackColor = false;
            edit_button.Click += edit_button_Click;

            // 
            // delete_button
            // 
            delete_button.Location = new Point(795, 125);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(85, 30);
            delete_button.TabIndex = 9;
            delete_button.Text = "Удалить";
            delete_button.UseVisualStyleBackColor = false;
            delete_button.Click += delete_button_Click;

            // 
            // OrderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(delete_button);
            Controls.Add(edit_button);
            Controls.Add(label_status);
            Controls.Add(label_code);
            Controls.Add(label_client);
            Controls.Add(label_address);
            Controls.Add(label_dateDelivery);
            Controls.Add(label_dateOrder);
            Controls.Add(label_article);
            Controls.Add(label_id);
            Name = "OrderControl";
            Size = new Size(900, 170);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}