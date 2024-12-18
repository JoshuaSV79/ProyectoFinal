namespace ProyectoGina
{
    partial class Eliminar
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            buttonConsultar = new Button();
            textBoxId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonDelete = new Button();
            textBoxName = new TextBox();
            textBoxDes = new TextBox();
            textBoxPrice = new TextBox();
            textBoxExis = new TextBox();
            textBoxPicture = new TextBox();
            pictureBoxproducto = new PictureBox();
            panel2 = new Panel();
            label8 = new Label();
            button_atras = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxproducto).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(943, 163);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.logo_fuby;
            pictureBox1.Location = new Point(780, 13);
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
            // buttonConsultar
            // 
            buttonConsultar.Location = new Point(68, 249);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(144, 60);
            buttonConsultar.TabIndex = 9;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = true;
            buttonConsultar.Click += buttonConsultar_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(68, 203);
            textBoxId.Name = "textBoxId";
            textBoxId.PlaceholderText = "Id del producto";
            textBoxId.Size = new Size(144, 27);
            textBoxId.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 206);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 249);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 12;
            label3.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 289);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 13;
            label5.Text = "Descripcion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(307, 337);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 14;
            label6.Text = "Existencias";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(307, 383);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 15;
            label7.Text = "Imagen_ID";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(68, 337);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(144, 60);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(388, 199);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(221, 27);
            textBoxName.TabIndex = 17;
            // 
            // textBoxDes
            // 
            textBoxDes.Location = new Point(388, 282);
            textBoxDes.Name = "textBoxDes";
            textBoxDes.ReadOnly = true;
            textBoxDes.Size = new Size(221, 27);
            textBoxDes.TabIndex = 18;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(388, 242);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(221, 27);
            textBoxPrice.TabIndex = 18;
            // 
            // textBoxExis
            // 
            textBoxExis.Location = new Point(388, 334);
            textBoxExis.Name = "textBoxExis";
            textBoxExis.ReadOnly = true;
            textBoxExis.Size = new Size(221, 27);
            textBoxExis.TabIndex = 19;
            // 
            // textBoxPicture
            // 
            textBoxPicture.Location = new Point(388, 376);
            textBoxPicture.Name = "textBoxPicture";
            textBoxPicture.ReadOnly = true;
            textBoxPicture.Size = new Size(221, 27);
            textBoxPicture.TabIndex = 20;
            // 
            // pictureBoxproducto
            // 
            pictureBoxproducto.Location = new Point(662, 199);
            pictureBoxproducto.Name = "pictureBoxproducto";
            pictureBoxproducto.Size = new Size(217, 216);
            pictureBoxproducto.TabIndex = 21;
            pictureBoxproducto.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(button_atras);
            panel2.Location = new Point(1, 511);
            panel2.Name = "panel2";
            panel2.Size = new Size(943, 68);
            panel2.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label8.Location = new Point(688, 14);
            label8.Name = "label8";
            label8.Size = new Size(246, 41);
            label8.TabIndex = 13;
            label8.Text = "Punto de Ventas";
            // 
            // button_atras
            // 
            button_atras.Location = new Point(31, 21);
            button_atras.Name = "button_atras";
            button_atras.Size = new Size(94, 29);
            button_atras.TabIndex = 12;
            button_atras.Text = "Atras";
            button_atras.UseVisualStyleBackColor = true;
            button_atras.Click += button_atras_Click;
            // 
            // Eliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 574);
            Controls.Add(panel2);
            Controls.Add(pictureBoxproducto);
            Controls.Add(textBoxPicture);
            Controls.Add(textBoxExis);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxDes);
            Controls.Add(textBoxName);
            Controls.Add(buttonDelete);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxId);
            Controls.Add(buttonConsultar);
            Controls.Add(panel1);
            Name = "Eliminar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxproducto).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private Button buttonConsultar;
        private TextBox textBoxId;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button buttonDelete;
        private TextBox textBoxName;
        private TextBox textBoxDes;
        private TextBox textBoxPrice;
        private TextBox textBoxExis;
        private TextBox textBoxPicture;
        private PictureBox pictureBoxproducto;
        private Panel panel2;
        private Label label8;
        private Button button_atras;
    }
}