namespace ders16
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button2 = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(-10, 9);
            label1.Name = "label1";
            label1.Size = new Size(1431, 31);
            label1.TabIndex = 1;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(-1, 182);
            label2.Name = "label2";
            label2.Size = new Size(1422, 31);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(-1, 369);
            label3.Name = "label3";
            label3.Size = new Size(1413, 31);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Location = new Point(-1, 547);
            label4.Name = "label4";
            label4.Size = new Size(1413, 31);
            label4.TabIndex = 4;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Location = new Point(-10, 737);
            label5.Name = "label5";
            label5.Size = new Size(1431, 31);
            label5.TabIndex = 5;
            // 
            // label6
            // 
            label6.BackColor = Color.SkyBlue;
            label6.Location = new Point(1392, 9);
            label6.Name = "label6";
            label6.Size = new Size(39, 759);
            label6.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 233);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(151, 112);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 432);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(151, 112);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Monotype Corsiva", 14F, FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.Location = new Point(27, 628);
            button1.Name = "button1";
            button1.Size = new Size(136, 57);
            button1.TabIndex = 10;
            button1.Text = "Başla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // label7
            // 
            label7.BackColor = Color.Black;
            label7.Location = new Point(255, 590);
            label7.Name = "label7";
            label7.Size = new Size(979, 132);
            label7.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.Aqua;
            label8.Location = new Point(275, 602);
            label8.Name = "label8";
            label8.Size = new Size(57, 27);
            label8.TabIndex = 12;
            label8.Text = "Canlı";
            // 
            // label9
            // 
            label9.BackColor = Color.Black;
            label9.Font = new Font("Ink Free", 23F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.Aqua;
            label9.Location = new Point(386, 628);
            label9.Name = "label9";
            label9.Size = new Size(770, 71);
            label9.TabIndex = 13;
            label9.Text = "Ve... Yarış Başladı..(!)";
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Font = new Font("Unispace", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(1269, 613);
            button2.Name = "button2";
            button2.Size = new Size(106, 86);
            button2.TabIndex = 14;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Unispace", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(1283, 589);
            label10.Name = "label10";
            label10.Size = new Size(76, 21);
            label10.TabIndex = 15;
            label10.Text = "Derece";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Unispace", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.ForeColor = Color.Turquoise;
            label11.Location = new Point(209, 639);
            label11.Name = "label11";
            label11.Size = new Size(28, 30);
            label11.TabIndex = 16;
            label11.Text = "0\r\n";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.LightSkyBlue;
            label12.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.Location = new Point(1305, 638);
            label12.Name = "label12";
            label12.Size = new Size(31, 33);
            label12.TabIndex = 17;
            label12.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(1433, 759);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "At Yarışı";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button2;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}
