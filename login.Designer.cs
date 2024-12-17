namespace ProyectoGina
{
    partial class login
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
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBoxUser = new TextBox();
            textBoxPassword = new TextBox();
            button_salir = new Button();
            buttonLogin = new Button();
            panel2 = new Panel();
            label3 = new Label();
            button_atras = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-2, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 122);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.logo_fuby;
            pictureBox1.Location = new Point(609, 8);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(309, 158);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 8;
            label2.Text = "Iniciar Sesion";
            // 
            // textBoxUser
            // 
            textBoxUser.Font = new Font("Segoe UI", 9F);
            textBoxUser.Location = new Point(269, 193);
            textBoxUser.Margin = new Padding(3, 2, 3, 2);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.PlaceholderText = "Usuario";
            textBoxUser.Size = new Size(203, 23);
            textBoxUser.TabIndex = 9;
            textBoxUser.Tag = "";
            textBoxUser.TextChanged += textBoxUser_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(269, 234);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Contraseña";
            textBoxPassword.Size = new Size(203, 23);
            textBoxPassword.TabIndex = 10;
            // 
            // button_salir
            // 
            button_salir.Location = new Point(116, 13);
            button_salir.Margin = new Padding(3, 2, 3, 2);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(82, 22);
            button_salir.TabIndex = 11;
            button_salir.Text = "Salir";
            button_salir.UseVisualStyleBackColor = true;
            button_salir.Click += button_salir_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(326, 272);
            buttonLogin.Margin = new Padding(3, 2, 3, 2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(82, 22);
            buttonLogin.TabIndex = 12;
            buttonLogin.Text = "Ingresar";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button_atras);
            panel2.Controls.Add(button_salir);
            panel2.Location = new Point(-2, 392);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(743, 44);
            panel2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(516, 6);
            label3.Name = "label3";
            label3.Size = new Size(200, 32);
            label3.TabIndex = 13;
            label3.Text = "Punto de Ventas";
            // 
            // button_atras
            // 
            button_atras.Location = new Point(14, 13);
            button_atras.Margin = new Padding(3, 2, 3, 2);
            button_atras.Name = "button_atras";
            button_atras.Size = new Size(82, 22);
            button_atras.TabIndex = 12;
            button_atras.Text = "Atras";
            button_atras.UseVisualStyleBackColor = true;
            button_atras.Click += button_atras_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(740, 435);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUser);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = Color.Black;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBoxUser;
        private TextBox textBoxPassword;
        private Button button_salir;
        private Button buttonLogin;
        private Panel panel2;
        private Button button_atras;
        private Label label3;
    }
}