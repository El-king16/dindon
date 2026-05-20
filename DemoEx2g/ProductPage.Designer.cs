namespace DemoEx2g
{
    partial class ProductPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fullname_user = new Label();
            panel_products = new Panel();
            discount_filter = new ComboBox();
            label_filter = new Label();
            search_box = new TextBox();
            Search = new Label();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // fullname_user
            // 
            fullname_user.AutoSize = true;
            fullname_user.Location = new Point(1133, 9);
            fullname_user.Name = "fullname_user";
            fullname_user.Size = new Size(37, 15);
            fullname_user.TabIndex = 0;
            fullname_user.Text = "Гость";
            // 
            // panel_products
            // 
            panel_products.AutoScroll = true;
            panel_products.Location = new Point(12, 90);
            panel_products.Name = "panel_products";
            panel_products.Size = new Size(1076, 514);
            panel_products.TabIndex = 1;
            // 
            // discount_filter
            // 
            discount_filter.FormattingEnabled = true;
            discount_filter.Items.AddRange(new object[] { "Все диапазоны", "0-12.99%", "13-16.99%", "17% и более " });
            discount_filter.Location = new Point(906, 61);
            discount_filter.Name = "discount_filter";
            discount_filter.Size = new Size(121, 23);
            discount_filter.TabIndex = 2;
            discount_filter.SelectedIndexChanged += discount_filter_SelectedIndexChanged;
            // 
            // label_filter
            // 
            label_filter.AutoSize = true;
            label_filter.Location = new Point(906, 43);
            label_filter.Name = "label_filter";
            label_filter.Size = new Size(109, 15);
            label_filter.TabIndex = 3;
            label_filter.Text = "Отфильтровать по";
            // 
            // search_box
            // 
            search_box.Location = new Point(294, 61);
            search_box.Name = "search_box";
            search_box.Size = new Size(229, 23);
            search_box.TabIndex = 4;
            search_box.TextChanged += textBox1_TextChanged;
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.Location = new Point(294, 43);
            Search.Name = "Search";
            Search.Size = new Size(42, 15);
            Search.TabIndex = 5;
            Search.Text = "Поиск";
            // 
            // button1
            // 
            button1.Location = new Point(548, 60);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "По цене";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(548, 42);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 7;
            label1.Text = "Отсортировать по";
            // 
            // button2
            // 
            button2.Location = new Point(629, 61);
            button2.Name = "button2";
            button2.Size = new Size(110, 23);
            button2.TabIndex = 8;
            button2.Text = "По количеству";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 34);
            button3.Name = "button3";
            button3.Size = new Size(171, 23);
            button3.TabIndex = 9;
            button3.Text = "Добавить новый товар";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(15, 63);
            button4.Name = "button4";
            button4.Size = new Size(171, 23);
            button4.TabIndex = 10;
            button4.Text = "Посмотреть заказы";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1114, 34);
            button5.Name = "button5";
            button5.Size = new Size(56, 23);
            button5.TabIndex = 11;
            button5.Text = "Выйти";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 616);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(Search);
            Controls.Add(search_box);
            Controls.Add(label_filter);
            Controls.Add(discount_filter);
            Controls.Add(panel_products);
            Controls.Add(fullname_user);
            Name = "ProductPage";
            Text = "ProductPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fullname_user;
        private Panel panel_products;
        private ComboBox discount_filter;
        private Label label_filter;
        private TextBox search_box;
        private Label Search;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}