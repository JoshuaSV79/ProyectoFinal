namespace ProyectoGina
{
    partial class previa_productos
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
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            button_atras = new Button();
            image = new PictureBox();
            name = new Label();
            price = new Label();
            label_existencias = new Label();
            descripcion = new Label();
            button_menos = new Button();
            button_mas = new Button();
            textBox_cant = new TextBox();
            label9 = new Label();
            id = new Label();
            label6 = new Label();
            button_enviar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 163);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(304, 128);
            label2.Name = "label2";
            label2.Size = new Size(211, 23);
            label2.TabIndex = 9;
            label2.Text = "Visualizacion del producto";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.logo_fuby;
            pictureBox1.Location = new Point(696, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft PhagsPa", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 99);
            label1.Name = "label1";
            label1.Size = new Size(272, 23);
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
            label4.Location = new Point(21, 28);
            label4.Name = "label4";
            label4.Size = new Size(296, 59);
            label4.TabIndex = 5;
            label4.Text = "FutureByte";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button_atras);
            panel2.Location = new Point(0, 523);
            panel2.Name = "panel2";
            panel2.Size = new Size(849, 59);
            panel2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(590, 8);
            label3.Name = "label3";
            label3.Size = new Size(246, 41);
            label3.TabIndex = 13;
            label3.Text = "Punto de Ventas";
            // 
            // button_atras
            // 
            button_atras.Location = new Point(16, 17);
            button_atras.Name = "button_atras";
            button_atras.Size = new Size(94, 29);
            button_atras.TabIndex = 12;
            button_atras.Text = "Atras";
            button_atras.UseVisualStyleBackColor = true;
            button_atras.Click += button_atras_Click;
            // 
            // image
            // 
            image.Location = new Point(11, 169);
            image.Name = "image";
            image.Size = new Size(263, 259);
            image.TabIndex = 12;
            image.TabStop = false;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 10.8F);
            name.Location = new Point(304, 195);
            name.Name = "name";
            name.Size = new Size(78, 25);
            name.TabIndex = 13;
            name.Text = "Nombre";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI", 10.8F);
            price.Location = new Point(304, 251);
            price.Name = "price";
            price.Size = new Size(60, 25);
            price.TabIndex = 14;
            price.Text = "Precio";
            // 
            // label_existencias
            // 
            label_existencias.AutoSize = true;
            label_existencias.Font = new Font("Segoe UI", 10.8F);
            label_existencias.Location = new Point(720, 417);
            label_existencias.Name = "label_existencias";
            label_existencias.Size = new Size(45, 25);
            label_existencias.TabIndex = 15;
            label_existencias.Text = "cant";
            // 
            // descripcion
            // 
            descripcion.AutoSize = true;
            descripcion.Font = new Font("Segoe UI", 10.8F);
            descripcion.Location = new Point(304, 341);
            descripcion.Name = "descripcion";
            descripcion.Size = new Size(104, 25);
            descripcion.TabIndex = 16;
            descripcion.Text = "Descripcion";
            // 
            // button_menos
            // 
            button_menos.BackColor = Color.FromArgb(255, 192, 192);
            button_menos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button_menos.Location = new Point(685, 443);
            button_menos.Name = "button_menos";
            button_menos.Size = new Size(30, 29);
            button_menos.TabIndex = 17;
            button_menos.Text = "-";
            button_menos.TextAlign = ContentAlignment.TopCenter;
            button_menos.UseVisualStyleBackColor = false;
            button_menos.Click += button_menos_Click;
            // 
            // button_mas
            // 
            button_mas.BackColor = Color.FromArgb(192, 255, 192);
            button_mas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button_mas.Location = new Point(768, 443);
            button_mas.Name = "button_mas";
            button_mas.Size = new Size(30, 29);
            button_mas.TabIndex = 18;
            button_mas.Text = "+";
            button_mas.TextAlign = ContentAlignment.TopCenter;
            button_mas.UseVisualStyleBackColor = false;
            button_mas.Click += button_mas_Click;
            // 
            // textBox_cant
            // 
            textBox_cant.Location = new Point(721, 443);
            textBox_cant.Name = "textBox_cant";
            textBox_cant.PlaceholderText = "0";
            textBox_cant.ReadOnly = true;
            textBox_cant.Size = new Size(41, 27);
            textBox_cant.TabIndex = 19;
            textBox_cant.TextChanged += textBox1_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 440);
            label9.Name = "label9";
            label9.Size = new Size(22, 20);
            label9.TabIndex = 20;
            label9.Text = "Id";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(43, 441);
            id.Name = "id";
            id.Size = new Size(45, 20);
            id.TabIndex = 21;
            id.Text = "id_lbl";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(695, 393);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 23;
            label6.Text = "Existencias";
            // 
            // button_enviar
            // 
            button_enviar.Location = new Point(695, 478);
            button_enviar.Name = "button_enviar";
            button_enviar.Size = new Size(94, 29);
            button_enviar.TabIndex = 24;
            button_enviar.Text = "Enviar";
            button_enviar.UseVisualStyleBackColor = true;
            button_enviar.Click += button_enviar_Click;
            // 
            // previa_productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 580);
            Controls.Add(button_enviar);
            Controls.Add(label6);
            Controls.Add(id);
            Controls.Add(label9);
            Controls.Add(textBox_cant);
            Controls.Add(button_mas);
            Controls.Add(button_menos);
            Controls.Add(descripcion);
            Controls.Add(label_existencias);
            Controls.Add(price);
            Controls.Add(name);
            Controls.Add(image);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "previa_productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "previa_productos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private Panel panel2;
        private Label label3;
        private Button button_atras;
        private Label label2;
        private Button button_menos;
        private Button button_mas;
        private TextBox textBox_cant;
        private Label label9;
        public PictureBox image;
        public Label name;
        public Label price;
        public Label descripcion;
        public Label id;
        public Label label_existencias;
        public Label label6;
        private Button button_enviar;
    }
}