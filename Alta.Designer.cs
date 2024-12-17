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
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            textBoxId = new TextBox();
            textBoxDescripcion = new TextBox();
            textBoxPrecio = new TextBox();
            textBoxExistencias = new TextBox();
            button1 = new Button();
            textBoxImagen = new TextBox();
            textBoxNombre = new TextBox();
            button_atras = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1234, 168);
            panel1.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.logo_fuby;
            pictureBox3.Location = new Point(1081, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(139, 133);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
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
            // label4
            // 
            label4.AllowDrop = true;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("MS Reference Sans Serif", 28.2F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 27);
            label4.Name = "label4";
            label4.Size = new Size(276, 55);
            label4.TabIndex = 5;
            label4.Text = "FutureByte";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(509, 191);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(134, 113);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // textBoxId
            // 
            textBoxId.Font = new Font("Segoe UI", 9F);
            textBoxId.Location = new Point(462, 451);
            textBoxId.Name = "textBoxId";
            textBoxId.PlaceholderText = "Id";
            textBoxId.Size = new Size(231, 26);
            textBoxId.TabIndex = 21;
            textBoxId.Tag = "";
            textBoxId.TextChanged += textBoxUser_TextChanged;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Font = new Font("Segoe UI", 9F);
            textBoxDescripcion.Location = new Point(462, 513);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.PlaceholderText = "Descripcion";
            textBoxDescripcion.Size = new Size(231, 26);
            textBoxDescripcion.TabIndex = 22;
            textBoxDescripcion.Tag = "";
            textBoxDescripcion.TextChanged += textBox1_TextChanged;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Font = new Font("Segoe UI", 9F);
            textBoxPrecio.Location = new Point(462, 583);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.PlaceholderText = "Precio";
            textBoxPrecio.Size = new Size(231, 26);
            textBoxPrecio.TabIndex = 23;
            textBoxPrecio.Tag = "";
            textBoxPrecio.TextChanged += textBoxPrecio_TextChanged;
            // 
            // textBoxExistencias
            // 
            textBoxExistencias.Font = new Font("Segoe UI", 9F);
            textBoxExistencias.Location = new Point(462, 651);
            textBoxExistencias.Name = "textBoxExistencias";
            textBoxExistencias.PlaceholderText = "Existencias";
            textBoxExistencias.Size = new Size(231, 26);
            textBoxExistencias.TabIndex = 24;
            textBoxExistencias.Tag = "";
            // 
            // button1
            // 
            button1.Location = new Point(519, 707);
            button1.Name = "button1";
            button1.Size = new Size(112, 46);
            button1.TabIndex = 25;
            button1.Text = "Grabar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxImagen
            // 
            textBoxImagen.Font = new Font("Segoe UI", 9F);
            textBoxImagen.Location = new Point(462, 335);
            textBoxImagen.Name = "textBoxImagen";
            textBoxImagen.PlaceholderText = "Id imagen";
            textBoxImagen.Size = new Size(231, 26);
            textBoxImagen.TabIndex = 26;
            textBoxImagen.Tag = "";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Font = new Font("Segoe UI", 9F);
            textBoxNombre.Location = new Point(462, 385);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(231, 26);
            textBoxNombre.TabIndex = 27;
            textBoxNombre.Tag = "";
            // 
            // button_atras
            // 
            button_atras.Location = new Point(51, 722);
            button_atras.Name = "button_atras";
            button_atras.Size = new Size(112, 46);
            button_atras.TabIndex = 28;
            button_atras.Text = "Atras";
            button_atras.UseVisualStyleBackColor = true;
            button_atras.Click += button_atras_Click;
            // 
            // Alta
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 780);
            Controls.Add(button_atras);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxImagen);
            Controls.Add(button1);
            Controls.Add(textBoxExistencias);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxId);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Alta";
            Text = "Alta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private PictureBox pictureBox2;
        private TextBox textBoxId;
        private TextBox textBoxDescripcion;
        private TextBox textBoxPrecio;
        private TextBox textBoxExistencias;
        private Button button1;
        private PictureBox pictureBox3;
        private TextBox textBoxImagen;
        private TextBox textBoxNombre;
        private Button button_atras;
    }
}