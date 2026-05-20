namespace DemoEx2g
{
    partial class ItemControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            PicturePhoto = new PictureBox();
            label_name = new Label();
            label_desc = new Label();
            label_creater = new Label();
            label_provider = new Label();
            label_price = new Label();
            label_unit = new Label();
            label_count = new Label();
            label_discount = new Label();
            edit_button = new Button();
            delete_button = new Button();
            ((System.ComponentModel.ISupportInitialize)PicturePhoto).BeginInit();
            SuspendLayout();
            // 
            // PicturePhoto
            // 
            PicturePhoto.Location = new Point(8, 8);
            PicturePhoto.Name = "PicturePhoto";
            PicturePhoto.Size = new Size(173, 161);
            PicturePhoto.SizeMode = PictureBoxSizeMode.Zoom;
            PicturePhoto.TabIndex = 0;
            PicturePhoto.TabStop = false;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_name.Location = new Point(199, 24);
            label_name.Name = "label_name";
            label_name.Size = new Size(205, 19);
            label_name.TabIndex = 1;
            label_name.Text = "Категория | Наименование";
            // 
            // label_desc
            // 
            label_desc.AutoSize = true;
            label_desc.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_desc.Location = new Point(199, 43);
            label_desc.Name = "label_desc";
            label_desc.Size = new Size(58, 15);
            label_desc.TabIndex = 2;
            label_desc.Text = "Описание:";
            // 
            // label_creater
            // 
            label_creater.AutoSize = true;
            label_creater.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_creater.Location = new Point(199, 58);
            label_creater.Name = "label_creater";
            label_creater.Size = new Size(89, 15);
            label_creater.TabIndex = 3;
            label_creater.Text = "Производитель:";
            // 
            // label_provider
            // 
            label_provider.AutoSize = true;
            label_provider.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_provider.Location = new Point(199, 73);
            label_provider.Name = "label_provider";
            label_provider.Size = new Size(67, 15);
            label_provider.TabIndex = 4;
            label_provider.Text = "Поставщик:";
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_price.Location = new Point(199, 88);
            label_price.Name = "label_price";
            label_price.Size = new Size(35, 15);
            label_price.TabIndex = 5;
            label_price.Text = "Цена:";
            // 
            // label_unit
            // 
            label_unit.AutoSize = true;
            label_unit.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_unit.Location = new Point(199, 103);
            label_unit.Name = "label_unit";
            label_unit.Size = new Size(108, 15);
            label_unit.TabIndex = 6;
            label_unit.Text = "Единица измерения:";
            // 
            // label_count
            // 
            label_count.AutoSize = true;
            label_count.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_count.Location = new Point(199, 118);
            label_count.Name = "label_count";
            label_count.Size = new Size(118, 15);
            label_count.TabIndex = 7;
            label_count.Text = "Количество на складе:";
            // 
            // label_discount
            // 
            label_discount.AutoSize = true;
            label_discount.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_discount.Location = new Point(895, 73);
            label_discount.Name = "label_discount";
            label_discount.Size = new Size(121, 15);
            label_discount.TabIndex = 8;
            label_discount.Text = "Действующая скидка: ";
            // 
            // edit_button
            // 
            edit_button.Location = new Point(895, 146);
            edit_button.Name = "edit_button";
            edit_button.Size = new Size(75, 23);
            edit_button.TabIndex = 9;
            edit_button.Text = "Изменить";
            edit_button.UseVisualStyleBackColor = true;
            edit_button.Visible = false;
            edit_button.Click += edit_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(976, 146);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(75, 23);
            delete_button.TabIndex = 10;
            delete_button.Text = "Удалить";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Visible = false;
            delete_button.Click += delete_button_Click;
            // 
            // ItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(delete_button);
            Controls.Add(edit_button);
            Controls.Add(label_discount);
            Controls.Add(label_count);
            Controls.Add(label_unit);
            Controls.Add(label_price);
            Controls.Add(label_provider);
            Controls.Add(label_creater);
            Controls.Add(label_desc);
            Controls.Add(label_name);
            Controls.Add(PicturePhoto);
            Name = "ItemControl";
            Size = new Size(1129, 183);
            ((System.ComponentModel.ISupportInitialize)PicturePhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PicturePhoto;
        private Label label_name;
        private Label label_desc;
        private Label label_creater;
        private Label label_provider;
        private Label label_price;
        private Label label_unit;
        private Label label_count;
        private Label label_discount;
        private Button edit_button;
        private Button delete_button;
    }
}
