namespace ProyectoGina
{
    partial class Ventas
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
            panel2 = new Panel();
            label8 = new Label();
            button_atras = new Button();
            box_ventas = new RichTextBox();
            label2 = new Label();
            total_text = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1087, 133);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.logo_fuby;
            pictureBox1.Location = new Point(954, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 105);
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
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(button_atras);
            panel2.Location = new Point(0, 476);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1087, 71);
            panel2.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label8.Location = new Point(876, 30);
            label8.Name = "label8";
            label8.Size = new Size(200, 32);
            label8.TabIndex = 13;
            label8.Text = "Punto de Ventas";
            // 
            // button_atras
            // 
            button_atras.Location = new Point(27, 30);
            button_atras.Margin = new Padding(3, 2, 3, 2);
            button_atras.Name = "button_atras";
            button_atras.Size = new Size(82, 22);
            button_atras.TabIndex = 12;
            button_atras.Text = "Atras";
            button_atras.UseVisualStyleBackColor = true;
            button_atras.Click += button_atras_Click;
            // 
            // box_ventas
            // 
            box_ventas.Location = new Point(18, 146);
            box_ventas.Margin = new Padding(3, 2, 3, 2);
            box_ventas.Name = "box_ventas";
            box_ventas.Size = new Size(615, 308);
            box_ventas.TabIndex = 26;
            box_ventas.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(676, 157);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 27;
            label2.Text = "Total vendido:";
            // 
            // total_text
            // 
            total_text.AutoSize = true;
            total_text.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_text.ForeColor = Color.Green;
            total_text.Location = new Point(797, 158);
            total_text.Name = "total_text";
            total_text.Size = new Size(42, 19);
            total_text.TabIndex = 28;
            total_text.Text = "Total\r\n";
            total_text.Click += total_text_Click;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 547);
            Controls.Add(total_text);
            Controls.Add(label2);
            Controls.Add(box_ventas);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            Load += Ventas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel2;
        private Label label8;
        private Button button_atras;
        private RichTextBox box_ventas;
        private Label label2;
        private Label total_text;
    }
}