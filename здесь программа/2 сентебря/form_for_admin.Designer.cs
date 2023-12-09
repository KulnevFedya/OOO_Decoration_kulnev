namespace _2_сентебря
{
    partial class form_for_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_for_admin));
            product_GridView = new DataGridView();
            panel1 = new Panel();
            button1 = new Button();
            label6 = new Label();
            btnSortminus = new Button();
            btnSortplus = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)product_GridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // product_GridView
            // 
            product_GridView.BackgroundColor = SystemColors.ButtonHighlight;
            product_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            product_GridView.Location = new Point(0, 109);
            product_GridView.Name = "product_GridView";
            product_GridView.RowTemplate.Height = 25;
            product_GridView.Size = new Size(801, 344);
            product_GridView.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 204, 153);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnSortminus);
            panel1.Controls.Add(btnSortplus);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 117);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(204, 102, 0);
            button1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(99, 45);
            button1.TabIndex = 11;
            button1.Text = "На главную форму";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(198, 31);
            label6.Name = "label6";
            label6.Size = new Size(73, 17);
            label6.TabIndex = 10;
            label6.Text = "Сортировка";
            // 
            // btnSortminus
            // 
            btnSortminus.BackColor = Color.FromArgb(204, 102, 0);
            btnSortminus.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSortminus.Location = new Point(241, 61);
            btnSortminus.Name = "btnSortminus";
            btnSortminus.Size = new Size(96, 42);
            btnSortminus.TabIndex = 9;
            btnSortminus.Text = "По убыванию";
            btnSortminus.UseVisualStyleBackColor = false;
            btnSortminus.Click += btnSortminus_Click;
            // 
            // btnSortplus
            // 
            btnSortplus.BackColor = Color.FromArgb(204, 102, 0);
            btnSortplus.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSortplus.Location = new Point(136, 61);
            btnSortplus.Name = "btnSortplus";
            btnSortplus.Size = new Size(96, 42);
            btnSortplus.TabIndex = 8;
            btnSortplus.Text = "По возрастанию";
            btnSortplus.UseVisualStyleBackColor = false;
            btnSortplus.Click += btnSortplus_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 31);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(562, 97);
            label1.Name = "label1";
            label1.Size = new Size(114, 17);
            label1.TabIndex = 1;
            label1.Text = "ООО \"Украшение\"";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(682, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // form_for_admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(product_GridView);
            Name = "form_for_admin";
            Text = "form_for_admin";
            Load += form_for_admin_Load;
            ((System.ComponentModel.ISupportInitialize)product_GridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView product_GridView;
        private Panel panel1;
        private Button button1;
        private Label label6;
        private Button btnSortminus;
        private Button btnSortplus;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}