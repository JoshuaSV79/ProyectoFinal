﻿namespace ProyectoGina
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
            existencias = new Label();
            descripcion = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label9 = new Label();
            id = new Label();
            label6 = new Label();
            button3 = new Button();
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
            pictureBox1.Size = new Size(140, 140);
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
            label4.Location = new Point(20, 28);
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
            panel2.Size = new Size(849, 58);
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
            image.Location = new Point(12, 169);
            image.Name = "image";
            image.Size = new Size(263, 258);
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
            price.Location = new Point(304, 250);
            price.Name = "price";
            price.Size = new Size(60, 25);
            price.TabIndex = 14;
            price.Text = "Precio";
            // 
            // existencias
            // 
            existencias.AutoSize = true;
            existencias.Font = new Font("Segoe UI", 10.8F);
            existencias.Location = new Point(720, 417);
            existencias.Name = "existencias";
            existencias.Size = new Size(45, 25);
            existencias.TabIndex = 15;
            existencias.Text = "cant";
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.Location = new Point(685, 442);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 17;
            button1.Text = "-";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button2.Location = new Point(768, 443);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 18;
            button2.Text = "+";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(721, 443);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "0";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(41, 27);
            textBox1.TabIndex = 19;
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
            id.Location = new Point(44, 441);
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
            // button3
            // 
            button3.Location = new Point(696, 479);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 24;
            button3.Text = "Enviar";
            button3.UseVisualStyleBackColor = true;
            // 
            // previa_productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 580);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(id);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(descripcion);
            Controls.Add(existencias);
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
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label9;
        public PictureBox image;
        public Label name;
        public Label price;
        public Label descripcion;
        public Label id;
        public Label existencias;
        public Label label6;
        private Button button3;
    }
}