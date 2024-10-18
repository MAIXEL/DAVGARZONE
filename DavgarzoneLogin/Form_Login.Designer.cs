namespace Davgarzone1._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox7 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            pictureBox6 = new PictureBox();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            textBox3 = new TextBox();
            linkLabel2 = new LinkLabel();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            imageList1 = new ImageList(components);
            pictureBox8 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 30, 36);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(886, 61);
            panel1.TabIndex = 0;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(0, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(65, 61);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 32;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, -7);
            label1.Name = "label1";
            label1.Size = new Size(352, 65);
            label1.TabIndex = 3;
            label1.Text = "DAVGARZONE";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(823, 0);
            button1.Name = "button1";
            button1.Size = new Size(60, 58);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(193, 308);
            button2.Name = "button2";
            button2.Size = new Size(119, 45);
            button2.TabIndex = 1;
            button2.Text = "ENTRAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 149, 111);
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(368, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(509, 444);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(84, 240);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(114, 15);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Olvide la contraseña";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(48, 207);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(48, 135);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(84, 190);
            label7.Name = "label7";
            label7.Size = new Size(96, 21);
            label7.TabIndex = 18;
            label7.Text = "Contraseña";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Location = new Point(84, 214);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(202, 23);
            textBox3.TabIndex = 17;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(204, 356);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(96, 15);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "No tengo cuenta";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(138, 28);
            label4.Name = "label4";
            label4.Size = new Size(233, 40);
            label4.TabIndex = 7;
            label4.Text = "INICIAR SESIÓN";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(84, 118);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(84, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(298, 23);
            textBox2.TabIndex = 5;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(-5, 56);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(367, 551);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 4;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 149, 111);
            ClientSize = new Size(886, 607);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button button2;
        private Panel panel2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private LinkLabel linkLabel2;
        private PictureBox pictureBox2;
        private Label label7;
        private TextBox textBox3;
        private PictureBox pictureBox6;
        private ImageList imageList1;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private LinkLabel linkLabel1;
    }
}
