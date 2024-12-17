namespace ProyectoGina
{
    partial class Alta
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
            panel1 = new Panel();
            label1 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            button6 = new Button();
            textBoxUser = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-2, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1080, 133);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft PhagsPa", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 74);
            label1.Name = "label1";
            label1.Size = new Size(221, 20);
            label1.TabIndex = 6;
            label1.Text = "inovacion que conecta contigo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AllowDrop = true;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("MS Reference Sans Serif", 28.2F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(18, 21);
            label4.Name = "label4";
            label4.Size = new Size(240, 46);
            label4.TabIndex = 5;
            label4.Text = "FutureByte";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(436, 165);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(153, 134);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // button6
            // 
            button6.Location = new Point(451, 312);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(121, 36);
            button6.TabIndex = 20;
            button6.Text = "Cargar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBoxUser
            // 
            textBoxUser.Font = new Font("Segoe UI", 9F);
            textBoxUser.Location = new Point(404, 368);
            textBoxUser.Margin = new Padding(3, 2, 3, 2);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.PlaceholderText = "Id";
            textBoxUser.Size = new Size(203, 23);
            textBoxUser.TabIndex = 21;
            textBoxUser.Tag = "";
            textBoxUser.TextChanged += textBoxUser_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.Location = new Point(404, 415);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Descripcion";
            textBox1.Size = new Size(203, 23);
            textBox1.TabIndex = 22;
            textBox1.Tag = "";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F);
            textBox2.Location = new Point(404, 470);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Precio";
            textBox2.Size = new Size(203, 23);
            textBox2.TabIndex = 23;
            textBox2.Tag = "";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F);
            textBox3.Location = new Point(404, 520);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Existencias";
            textBox3.Size = new Size(203, 23);
            textBox3.TabIndex = 24;
            textBox3.Tag = "";
            // 
            // button1
            // 
            button1.Location = new Point(469, 565);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(98, 36);
            button1.TabIndex = 25;
            button1.Text = "Grabar";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.logo_fuby;
            pictureBox3.Location = new Point(946, 11);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(122, 105);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // Alta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 616);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBoxUser);
            Controls.Add(button6);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "Alta";
            Text = "Alta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private PictureBox pictureBox2;
        private Button button6;
        private TextBox textBoxUser;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private PictureBox pictureBox3;
    }
}