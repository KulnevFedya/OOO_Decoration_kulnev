namespace _2_сентебря
{
    partial class Cart
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
            button1 = new Button();
            button2 = new Button();
            listBoxproduct = new ListBox();
            btnDeleteProduct = new Button();
            ProductPictureBox = new PictureBox();
            dicsount_panel = new Panel();
            discount_label = new Label();
            label_amount = new Label();
            labelSum = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            txtboxDeleteAmount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).BeginInit();
            dicsount_panel.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(204, 102, 0);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Вернуться";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(204, 102, 0);
            button2.Location = new Point(221, 410);
            button2.Name = "button2";
            button2.Size = new Size(90, 45);
            button2.TabIndex = 1;
            button2.Text = "Оформить заказ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listBoxproduct
            // 
            listBoxproduct.FormattingEnabled = true;
            listBoxproduct.ItemHeight = 15;
            listBoxproduct.Location = new Point(12, 41);
            listBoxproduct.Name = "listBoxproduct";
            listBoxproduct.Size = new Size(361, 169);
            listBoxproduct.TabIndex = 2;
            listBoxproduct.SelectedValueChanged += listBox1_SelectedValueChanged;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.FromArgb(204, 102, 0);
            btnDeleteProduct.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteProduct.Location = new Point(17, 216);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(52, 44);
            btnDeleteProduct.TabIndex = 4;
            btnDeleteProduct.Text = "🗑";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // ProductPictureBox
            // 
            ProductPictureBox.Location = new Point(-2, -2);
            ProductPictureBox.Name = "ProductPictureBox";
            ProductPictureBox.Size = new Size(145, 131);
            ProductPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ProductPictureBox.TabIndex = 6;
            ProductPictureBox.TabStop = false;
            // 
            // dicsount_panel
            // 
            dicsount_panel.BorderStyle = BorderStyle.Fixed3D;
            dicsount_panel.Controls.Add(discount_label);
            dicsount_panel.Controls.Add(ProductPictureBox);
            dicsount_panel.Location = new Point(12, 324);
            dicsount_panel.Name = "dicsount_panel";
            dicsount_panel.Size = new Size(145, 131);
            dicsount_panel.TabIndex = 7;
            // 
            // discount_label
            // 
            discount_label.AutoSize = true;
            discount_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            discount_label.Location = new Point(55, 49);
            discount_label.Name = "discount_label";
            discount_label.Size = new Size(0, 25);
            discount_label.TabIndex = 0;
            // 
            // label_amount
            // 
            label_amount.AutoSize = true;
            label_amount.Location = new Point(297, 326);
            label_amount.Name = "label_amount";
            label_amount.Size = new Size(0, 15);
            label_amount.TabIndex = 9;
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Location = new Point(163, 326);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(88, 15);
            labelSum.TabIndex = 11;
            labelSum.Text = "Общая сумма:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 277);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 12;
            label2.Text = "Выбрать пункт выдачи";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 295);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(361, 23);
            comboBox1.TabIndex = 13;
            // 
            // txtboxDeleteAmount
            // 
            txtboxDeleteAmount.BackColor = Color.FromArgb(204, 102, 0);
            txtboxDeleteAmount.Location = new Point(92, 229);
            txtboxDeleteAmount.Name = "txtboxDeleteAmount";
            txtboxDeleteAmount.Size = new Size(127, 23);
            txtboxDeleteAmount.TabIndex = 14;
            txtboxDeleteAmount.Text = "1";
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 204, 153);
            ClientSize = new Size(385, 467);
            Controls.Add(txtboxDeleteAmount);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(labelSum);
            Controls.Add(label_amount);
            Controls.Add(dicsount_panel);
            Controls.Add(btnDeleteProduct);
            Controls.Add(listBoxproduct);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Cart";
            Text = "Cart";
            Load += Cart_Load;
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).EndInit();
            dicsount_panel.ResumeLayout(false);
            dicsount_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox listBoxproduct;
        private Button btnDeleteProduct;
        private PictureBox ProductPictureBox;
        private Panel dicsount_panel;
        private Label discount_label;
        private Label label_amount;
        private Label labelSum;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox txtboxDeleteAmount;
    }
}