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
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.Size = new Size(943, 155);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.logo_fuby;
            pictureBox1.Location = new Point(780, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 133);
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
            // buttonConsultar
            // 
            buttonConsultar.Location = new Point(68, 237);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(144, 57);
            buttonConsultar.TabIndex = 9;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = true;
            buttonConsultar.Click += buttonConsultar_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(68, 193);
            textBoxId.Name = "textBoxId";
            textBoxId.PlaceholderText = "Id del producto";
            textBoxId.Size = new Size(144, 26);
            textBoxId.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 196);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 237);
            label3.Name = "label3";
            label3.Size = new Size(46, 19);
            label3.TabIndex = 12;
            label3.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 275);
            label5.Name = "label5";
            label5.Size = new Size(79, 19);
            label5.TabIndex = 13;
            label5.Text = "Descripcion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(307, 320);
            label6.Name = "label6";
            label6.Size = new Size(73, 19);
            label6.TabIndex = 14;
            label6.Text = "Existencias";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(307, 364);
            label7.Name = "label7";
            label7.Size = new Size(75, 19);
            label7.TabIndex = 15;
            label7.Text = "Imagen_ID";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(68, 320);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(144, 57);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(388, 189);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(221, 26);
            textBoxName.TabIndex = 17;
            // 
            // textBoxDes
            // 
            textBoxDes.Location = new Point(388, 268);
            textBoxDes.Name = "textBoxDes";
            textBoxDes.Size = new Size(221, 26);
            textBoxDes.TabIndex = 18;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(388, 230);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(221, 26);
            textBoxPrice.TabIndex = 18;
            // 
            // textBoxExis
            // 
            textBoxExis.Location = new Point(388, 317);
            textBoxExis.Name = "textBoxExis";
            textBoxExis.Size = new Size(221, 26);
            textBoxExis.TabIndex = 19;
            // 
            // textBoxPicture
            // 
            textBoxPicture.Location = new Point(388, 357);
            textBoxPicture.Name = "textBoxPicture";
            textBoxPicture.Size = new Size(221, 26);
            textBoxPicture.TabIndex = 20;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(662, 189);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(217, 205);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // Eliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 545);
            Controls.Add(pictureBox2);
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
            Text = "Eliminar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
    }
}