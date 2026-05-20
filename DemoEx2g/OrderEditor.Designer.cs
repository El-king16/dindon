namespace DemoEx2g
{
    partial class OrderEditor
    {
        private System.ComponentModel.IContainer components = null;

        private Label label_articleOrder;
        private Label label_dateOrder;
        private Label label_dateDelivery;
        private Label label_address;
        private Label label_client;
        private Label label_code;
        private Label label_status;
        private Label label_help;

        private TextBox articleOrder_box;
        private TextBox dateOrder_box;
        private TextBox dateDelivery_box;
        private ComboBox address_box;
        private TextBox client_box;
        private TextBox code_box;
        private TextBox status_box;

        private Button save_button;
        private Button cancel_button;

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
            label_articleOrder = new Label();
            articleOrder_box = new TextBox();
            label_help = new Label();
            label_dateOrder = new Label();
            dateOrder_box = new TextBox();
            label_dateDelivery = new Label();
            dateDelivery_box = new TextBox();
            label_address = new Label();
            address_box = new ComboBox();
            label_client = new Label();
            client_box = new TextBox();
            label_code = new Label();
            code_box = new TextBox();
            label_status = new Label();
            status_box = new TextBox();
            save_button = new Button();
            cancel_button = new Button();
            SuspendLayout();
            // 
            // label_articleOrder
            // 
            label_articleOrder.AutoSize = true;
            label_articleOrder.Location = new Point(20, 23);
            label_articleOrder.Name = "label_articleOrder";
            label_articleOrder.Size = new Size(52, 15);
            label_articleOrder.TabIndex = 0;
            label_articleOrder.Text = "Товары:";
            // 
            // articleOrder_box
            // 
            articleOrder_box.Location = new Point(180, 20);
            articleOrder_box.Name = "articleOrder_box";
            articleOrder_box.Size = new Size(360, 23);
            articleOrder_box.TabIndex = 1;
            // 
            // label_help
            // 
            label_help.AutoSize = true;
            label_help.Location = new Point(180, 46);
            label_help.Name = "label_help";
            label_help.Size = new Size(166, 15);
            label_help.TabIndex = 2;
            label_help.Text = "Формат: А112Т4, 2, G843H5, 2";
            // 
            // label_dateOrder
            // 
            label_dateOrder.AutoSize = true;
            label_dateOrder.Location = new Point(20, 83);
            label_dateOrder.Name = "label_dateOrder";
            label_dateOrder.Size = new Size(72, 15);
            label_dateOrder.TabIndex = 3;
            label_dateOrder.Text = "Дата заказа:";
            // 
            // dateOrder_box
            // 
            dateOrder_box.Location = new Point(180, 80);
            dateOrder_box.Name = "dateOrder_box";
            dateOrder_box.Size = new Size(360, 23);
            dateOrder_box.TabIndex = 4;
            // 
            // label_dateDelivery
            // 
            label_dateDelivery.AutoSize = true;
            label_dateDelivery.Location = new Point(20, 123);
            label_dateDelivery.Name = "label_dateDelivery";
            label_dateDelivery.Size = new Size(87, 15);
            label_dateDelivery.TabIndex = 5;
            label_dateDelivery.Text = "Дата доставки:";
            // 
            // dateDelivery_box
            // 
            dateDelivery_box.Location = new Point(180, 120);
            dateDelivery_box.Name = "dateDelivery_box";
            dateDelivery_box.Size = new Size(360, 23);
            dateDelivery_box.TabIndex = 6;
            // 
            // label_address
            // 
            label_address.AutoSize = true;
            label_address.Location = new Point(20, 163);
            label_address.Name = "label_address";
            label_address.Size = new Size(87, 15);
            label_address.TabIndex = 7;
            label_address.Text = "Пункт выдачи:";
            // 
            // address_box
            // 
            address_box.DropDownStyle = ComboBoxStyle.DropDownList;
            address_box.FormattingEnabled = true;
            address_box.Location = new Point(180, 160);
            address_box.Name = "address_box";
            address_box.Size = new Size(360, 23);
            address_box.TabIndex = 8;
            // 
            // label_client
            // 
            label_client.AutoSize = true;
            label_client.Location = new Point(20, 203);
            label_client.Name = "label_client";
            label_client.Size = new Size(49, 15);
            label_client.TabIndex = 9;
            label_client.Text = "Клиент:";
            // 
            // client_box
            // 
            client_box.Location = new Point(180, 200);
            client_box.Name = "client_box";
            client_box.Size = new Size(360, 23);
            client_box.TabIndex = 10;
            // 
            // label_code
            // 
            label_code.AutoSize = true;
            label_code.Location = new Point(20, 243);
            label_code.Name = "label_code";
            label_code.Size = new Size(30, 15);
            label_code.TabIndex = 11;
            label_code.Text = "Код:";
            // 
            // code_box
            // 
            code_box.Location = new Point(180, 240);
            code_box.Name = "code_box";
            code_box.Size = new Size(360, 23);
            code_box.TabIndex = 12;
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.Location = new Point(20, 283);
            label_status.Name = "label_status";
            label_status.Size = new Size(46, 15);
            label_status.TabIndex = 13;
            label_status.Text = "Статус:";
            // 
            // status_box
            // 
            status_box.Location = new Point(180, 280);
            status_box.Name = "status_box";
            status_box.Size = new Size(360, 23);
            status_box.TabIndex = 14;
            // 
            // save_button
            // 
            save_button.BackColor = Color.FromArgb(0, 0, 255);
            save_button.FlatStyle = FlatStyle.Flat;
            save_button.ForeColor = Color.White;
            save_button.Location = new Point(180, 330);
            save_button.Name = "save_button";
            save_button.Size = new Size(160, 35);
            save_button.TabIndex = 15;
            save_button.Text = "Сохранить";
            save_button.UseVisualStyleBackColor = false;
            save_button.Click += save_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.BackColor = Color.FromArgb(0, 0, 255);
            cancel_button.FlatStyle = FlatStyle.Flat;
            cancel_button.ForeColor = Color.White;
            cancel_button.Location = new Point(380, 330);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(160, 35);
            cancel_button.TabIndex = 16;
            cancel_button.Text = "Отмена";
            cancel_button.UseVisualStyleBackColor = false;
            cancel_button.Click += cancel_button_Click;
            // 
            // OrderEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(570, 390);
            Controls.Add(cancel_button);
            Controls.Add(save_button);
            Controls.Add(status_box);
            Controls.Add(label_status);
            Controls.Add(code_box);
            Controls.Add(label_code);
            Controls.Add(client_box);
            Controls.Add(label_client);
            Controls.Add(address_box);
            Controls.Add(label_address);
            Controls.Add(dateDelivery_box);
            Controls.Add(label_dateDelivery);
            Controls.Add(dateOrder_box);
            Controls.Add(label_dateOrder);
            Controls.Add(label_help);
            Controls.Add(articleOrder_box);
            Controls.Add(label_articleOrder);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "OrderEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderEditor";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}