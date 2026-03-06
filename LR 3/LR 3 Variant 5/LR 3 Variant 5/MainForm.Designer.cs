namespace LR_3_Variant_5
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CategoriesListBox = new System.Windows.Forms.ListBox();
            this.MenuComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BasketRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriesListBox
            // 
            this.CategoriesListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CategoriesListBox.FormattingEnabled = true;
            this.CategoriesListBox.Location = new System.Drawing.Point(0, 0);
            this.CategoriesListBox.Name = "CategoriesListBox";
            this.CategoriesListBox.Size = new System.Drawing.Size(120, 452);
            this.CategoriesListBox.TabIndex = 0;
            this.CategoriesListBox.SelectedIndexChanged += new System.EventHandler(this.CategoriesListBox_SelectedIndexChanged);
            // 
            // MenuComboBox
            // 
            this.MenuComboBox.FormattingEnabled = true;
            this.MenuComboBox.Location = new System.Drawing.Point(120, 0);
            this.MenuComboBox.Name = "MenuComboBox";
            this.MenuComboBox.Size = new System.Drawing.Size(121, 21);
            this.MenuComboBox.TabIndex = 1;
            this.MenuComboBox.SelectedIndexChanged += new System.EventHandler(this.MenuComboBox_SelectedIndexChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(219, 417);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(35, 13);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "label1";
            // 
            // PriceLabel
            // 
            this.PriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(219, 373);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(35, 13);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Цена";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание";
            // 
            // BuyButton
            // 
            this.BuyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyButton.Location = new System.Drawing.Point(538, 371);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(75, 23);
            this.BuyButton.TabIndex = 4;
            this.BuyButton.Text = "Заказать";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.QuantityTextBox.Location = new System.Drawing.Point(366, 373);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuantityTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Корзина";
            // 
            // BasketRichTextBox
            // 
            this.BasketRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BasketRichTextBox.Location = new System.Drawing.Point(126, 103);
            this.BasketRichTextBox.Name = "BasketRichTextBox";
            this.BasketRichTextBox.Size = new System.Drawing.Size(136, 108);
            this.BasketRichTextBox.TabIndex = 6;
            this.BasketRichTextBox.Text = "";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhotoPictureBox.Location = new System.Drawing.Point(268, 0);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(564, 360);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PhotoPictureBox.TabIndex = 3;
            this.PhotoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 452);
            this.Controls.Add(this.PhotoPictureBox);
            this.Controls.Add(this.BasketRichTextBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.MenuComboBox);
            this.Controls.Add(this.CategoriesListBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(847, 491);
            this.MinimumSize = new System.Drawing.Size(847, 491);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа";
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CategoriesListBox;
        private System.Windows.Forms.ComboBox MenuComboBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox BasketRichTextBox;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
    }
}

