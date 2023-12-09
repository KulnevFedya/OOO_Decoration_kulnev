namespace _2_сентебря
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            btnAdminForm = new Button();
            label6 = new Label();
            btnSortminus = new Button();
            btnSortplus = new Button();
            lblElementsAmount = new Label();
            BtnCheckCart = new Button();
            comboBoxdiscount = new ComboBox();
            search_textBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel5 = new Panel();
            ProductPictureBox = new PictureBox();
            dicsount_panel = new Panel();
            discount_label = new Label();
            panel3 = new Panel();
            label_cost = new Label();
            label_Provider = new Label();
            label_description = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            product_GridView = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).BeginInit();
            dicsount_panel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)product_GridView).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 204, 153);
            panel1.Controls.Add(btnAdminForm);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnSortminus);
            panel1.Controls.Add(btnSortplus);
            panel1.Controls.Add(lblElementsAmount);
            panel1.Controls.Add(BtnCheckCart);
            panel1.Controls.Add(comboBoxdiscount);
            panel1.Controls.Add(search_textBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 117);
            panel1.TabIndex = 2;
            // 
            // btnAdminForm
            // 
            btnAdminForm.BackColor = Color.FromArgb(204, 102, 0);
            btnAdminForm.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdminForm.Location = new Point(495, 31);
            btnAdminForm.Name = "btnAdminForm";
            btnAdminForm.Size = new Size(99, 45);
            btnAdminForm.TabIndex = 11;
            btnAdminForm.Text = "Форма для админов";
            btnAdminForm.UseVisualStyleBackColor = false;
            btnAdminForm.Click += btnAdminForm_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(210, 31);
            label6.Name = "label6";
            label6.Size = new Size(79, 17);
            label6.TabIndex = 10;
            label6.Text = "Сортировать";
            // 
            // btnSortminus
            // 
            btnSortminus.BackColor = Color.FromArgb(204, 102, 0);
            btnSortminus.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSortminus.Location = new Point(255, 61);
            btnSortminus.Name = "btnSortminus";
            btnSortminus.Size = new Size(96, 42);
            btnSortminus.TabIndex = 9;
            btnSortminus.Text = "По убыванию";
            btnSortminus.UseVisualStyleBackColor = false;
            btnSortminus.Click += button4_Click;
            // 
            // btnSortplus
            // 
            btnSortplus.BackColor = Color.FromArgb(204, 102, 0);
            btnSortplus.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSortplus.Location = new Point(153, 60);
            btnSortplus.Name = "btnSortplus";
            btnSortplus.Size = new Size(96, 42);
            btnSortplus.TabIndex = 8;
            btnSortplus.Text = "По возрастанию";
            btnSortplus.UseVisualStyleBackColor = false;
            btnSortplus.Click += button3_Click;
            // 
            // lblElementsAmount
            // 
            lblElementsAmount.AutoSize = true;
            lblElementsAmount.Location = new Point(410, 63);
            lblElementsAmount.Name = "lblElementsAmount";
            lblElementsAmount.Size = new Size(42, 15);
            lblElementsAmount.TabIndex = 7;
            lblElementsAmount.Text = "30 / 30";
            // 
            // BtnCheckCart
            // 
            BtnCheckCart.BackColor = Color.FromArgb(204, 102, 0);
            BtnCheckCart.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCheckCart.Location = new Point(597, 31);
            BtnCheckCart.Name = "BtnCheckCart";
            BtnCheckCart.Size = new Size(99, 45);
            BtnCheckCart.TabIndex = 6;
            BtnCheckCart.Text = "Просмотреть заказ";
            BtnCheckCart.UseVisualStyleBackColor = false;
            BtnCheckCart.Click += button2_Click;
            // 
            // comboBoxdiscount
            // 
            comboBoxdiscount.FormattingEnabled = true;
            comboBoxdiscount.Items.AddRange(new object[] { "все диапозоны", "0-9,99%", "10-14,99%", "15%" });
            comboBoxdiscount.Location = new Point(368, 31);
            comboBoxdiscount.Name = "comboBoxdiscount";
            comboBoxdiscount.Size = new Size(121, 23);
            comboBoxdiscount.TabIndex = 4;
            comboBoxdiscount.SelectedIndexChanged += comboBoxdiscount_SelectedIndexChanged;
            // 
            // search_textBox
            // 
            search_textBox.Location = new Point(16, 60);
            search_textBox.Name = "search_textBox";
            search_textBox.Size = new Size(100, 23);
            search_textBox.TabIndex = 3;
            search_textBox.TextChanged += search_textBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 31);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 2;
            label2.Text = "Поиск";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(613, 89);
            label1.Name = "label1";
            label1.Size = new Size(114, 17);
            label1.TabIndex = 1;
            label1.Text = "ООО \"Украшение\"";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(727, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 204, 153);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(dicsount_panel);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 320);
            panel2.Name = "panel2";
            panel2.Size = new Size(845, 169);
            panel2.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(ProductPictureBox);
            panel5.Location = new Point(38, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(152, 131);
            panel5.TabIndex = 2;
            // 
            // ProductPictureBox
            // 
            ProductPictureBox.Location = new Point(-2, -2);
            ProductPictureBox.Name = "ProductPictureBox";
            ProductPictureBox.Size = new Size(152, 131);
            ProductPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ProductPictureBox.TabIndex = 5;
            ProductPictureBox.TabStop = false;
            // 
            // dicsount_panel
            // 
            dicsount_panel.BorderStyle = BorderStyle.Fixed3D;
            dicsount_panel.Controls.Add(discount_label);
            dicsount_panel.Location = new Point(670, 10);
            dicsount_panel.Name = "dicsount_panel";
            dicsount_panel.Size = new Size(145, 131);
            dicsount_panel.TabIndex = 1;
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
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label_cost);
            panel3.Controls.Add(label_Provider);
            panel3.Controls.Add(label_description);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(282, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(290, 131);
            panel3.TabIndex = 0;
            // 
            // label_cost
            // 
            label_cost.AutoSize = true;
            label_cost.Location = new Point(40, 83);
            label_cost.Name = "label_cost";
            label_cost.Size = new Size(13, 15);
            label_cost.TabIndex = 5;
            label_cost.Text = "0";
            // 
            // label_Provider
            // 
            label_Provider.AutoSize = true;
            label_Provider.Location = new Point(98, 49);
            label_Provider.Name = "label_Provider";
            label_Provider.Size = new Size(12, 15);
            label_Provider.TabIndex = 4;
            label_Provider.Text = "?";
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Location = new Point(107, 13);
            label_description.Name = "label_description";
            label_description.Size = new Size(12, 15);
            label_description.TabIndex = 3;
            label_description.Text = "?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 83);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 2;
            label5.Text = "Цена:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 49);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 1;
            label4.Text = "Производитель:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 13);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 0;
            label3.Text = "Описание товара:";
            // 
            // product_GridView
            // 
            product_GridView.BackgroundColor = SystemColors.ButtonHighlight;
            product_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            product_GridView.Location = new Point(0, 109);
            product_GridView.Name = "product_GridView";
            product_GridView.RowTemplate.Height = 25;
            product_GridView.Size = new Size(845, 215);
            product_GridView.TabIndex = 4;
            product_GridView.CellClick += product_GridView_CellClick;
            product_GridView.CellContentClick += product_GridView_CellContentClick;
            product_GridView.CellMouseClick += product_GridView_CellMouseClick;
            product_GridView.SelectionChanged += product_GridView_SelectionChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.System;
            contextMenuStrip1.Size = new Size(182, 26);
            contextMenuStrip1.Click += contextMenuStrip1_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(181, 22);
            toolStripMenuItem1.Text = "добавить в корзину";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 487);
            Controls.Add(product_GridView);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).EndInit();
            dicsount_panel.ResumeLayout(false);
            dicsount_panel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)product_GridView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button BtnCheckCart;
        private ComboBox comboBoxdiscount;
        private TextBox search_textBox;
        private Label label2;
        private DataGridView product_GridView;
        private Panel panel5;
        private Panel dicsount_panel;
        private Panel panel3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblElementsAmount;
        private Label label_cost;
        private Label label_Provider;
        private Label label_description;
        private PictureBox ProductPictureBox;
        private Button btnSortplus;
        private Label label6;
        private Button btnSortminus;
        private Label discount_label;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Button btnAdminForm;
    }
}