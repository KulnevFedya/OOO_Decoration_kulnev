namespace _2_сентебря
{
    partial class Entry_window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry_window));
            login_button = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            login_textBox = new TextBox();
            password_textBox = new TextBox();
            pictureBoxCapcha = new PictureBox();
            timer_for_blocking = new System.Windows.Forms.Timer(components);
            Capcha_textbox = new TextBox();
            buttontrycapcha = new Button();
            imageList1 = new ImageList(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCapcha).BeginInit();
            SuspendLayout();
            // 
            // login_button
            // 
            login_button.BackColor = Color.FromArgb(204, 102, 0);
            login_button.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            login_button.Location = new Point(119, 17);
            login_button.Name = "login_button";
            login_button.Size = new Size(73, 44);
            login_button.TabIndex = 0;
            login_button.Text = "Войти";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 204, 153);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 92);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 40);
            label1.Name = "label1";
            label1.Size = new Size(114, 17);
            label1.TabIndex = 1;
            label1.Text = "ООО \"Украшение\"";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(221, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 204, 153);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(login_button);
            panel2.Location = new Point(0, 335);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 101);
            panel2.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(204, 102, 0);
            button2.Location = new Point(95, 67);
            button2.Name = "button2";
            button2.Size = new Size(122, 23);
            button2.TabIndex = 1;
            button2.Text = "Войти как гость";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(137, 106);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 3;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(130, 162);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 4;
            label3.Text = "Пароль";
            // 
            // login_textBox
            // 
            login_textBox.BackColor = Color.FromArgb(204, 102, 0);
            login_textBox.Location = new Point(95, 126);
            login_textBox.Name = "login_textBox";
            login_textBox.Size = new Size(127, 23);
            login_textBox.TabIndex = 5;
            // 
            // password_textBox
            // 
            password_textBox.BackColor = Color.FromArgb(204, 102, 0);
            password_textBox.Location = new Point(95, 182);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(127, 23);
            password_textBox.TabIndex = 6;
            // 
            // pictureBoxCapcha
            // 
            pictureBoxCapcha.Location = new Point(95, 211);
            pictureBoxCapcha.Name = "pictureBoxCapcha";
            pictureBoxCapcha.Size = new Size(127, 86);
            pictureBoxCapcha.TabIndex = 7;
            pictureBoxCapcha.TabStop = false;
            // 
            // timer_for_blocking
            // 
            timer_for_blocking.Tick += timer_for_blocking_Tick;
            // 
            // Capcha_textbox
            // 
            Capcha_textbox.BackColor = Color.FromArgb(204, 102, 0);
            Capcha_textbox.Location = new Point(65, 303);
            Capcha_textbox.Name = "Capcha_textbox";
            Capcha_textbox.Size = new Size(127, 23);
            Capcha_textbox.TabIndex = 8;
            // 
            // buttontrycapcha
            // 
            buttontrycapcha.BackColor = Color.FromArgb(204, 102, 0);
            buttontrycapcha.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttontrycapcha.Location = new Point(207, 302);
            buttontrycapcha.Name = "buttontrycapcha";
            buttontrycapcha.Size = new Size(92, 23);
            buttontrycapcha.TabIndex = 2;
            buttontrycapcha.Text = "Ввод";
            buttontrycapcha.UseVisualStyleBackColor = false;
            buttontrycapcha.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "6ne3.png");
            imageList1.Images.SetKeyName(1, "e5hb.png");
            imageList1.Images.SetKeyName(2, "xdhyn.png");
            // 
            // Entry_window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 437);
            Controls.Add(buttontrycapcha);
            Controls.Add(Capcha_textbox);
            Controls.Add(pictureBoxCapcha);
            Controls.Add(password_textBox);
            Controls.Add(login_textBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Entry_window";
            Text = "Вход";
            Load += Entry_window_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCapcha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_button;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private TextBox login_textBox;
        private TextBox password_textBox;
        private Button button2;
        private PictureBox pictureBoxCapcha;
        private System.Windows.Forms.Timer timer_for_blocking;
        private TextBox Capcha_textbox;
        private Button buttontrycapcha;
        private ImageList imageList1;
    }
}