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
            button1 = new Button();
            buttonLogin = new Button();
            panel2 = new Panel();
            label3 = new Label();
            button4 = new Button();
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
            label4.Location = new Point(20, 27);
            label4.Name = "label4";
            label4.Size = new Size(276, 55);
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
            label1.Location = new Point(31, 94);
            label1.Name = "label1";
            label1.Size = new Size(253, 22);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 155);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(696, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 133);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(353, 200);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 8;
            label2.Text = "Iniciar Sesion";
            // 
            // textBoxUser
            // 
            textBoxUser.Font = new Font("Segoe UI", 9F);
            textBoxUser.Location = new Point(307, 244);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.PlaceholderText = "Usuario";
            textBoxUser.Size = new Size(231, 26);
            textBoxUser.TabIndex = 9;
            textBoxUser.Tag = "";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(307, 296);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Contraseña";
            textBoxPassword.Size = new Size(231, 26);
            textBoxPassword.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(133, 16);
            button1.Name = "button1";
            button1.Size = new Size(94, 28);
            button1.TabIndex = 11;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(373, 345);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 28);
            buttonLogin.TabIndex = 12;
            buttonLogin.Text = "Ingresar";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(-2, 496);
            panel2.Name = "panel2";
            panel2.Size = new Size(849, 55);
            panel2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(590, 8);
            label3.Name = "label3";
            label3.Size = new Size(231, 38);
            label3.TabIndex = 13;
            label3.Text = "Punto de Ventas";
            // 
            // button4
            // 
            button4.Location = new Point(16, 16);
            button4.Name = "button4";
            button4.Size = new Size(94, 28);
            button4.TabIndex = 12;
            button4.Text = "Atras";
            button4.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(846, 551);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUser);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button1;
        private Button buttonLogin;
        private Panel panel2;
        private Button button4;
        private Label label3;
    }
}