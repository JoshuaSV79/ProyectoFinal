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
            panel1.Name = "panel1";
            panel1.Size = new Size(1242, 177);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.logo_fuby;
            pictureBox1.Location = new Point(1090, 15);
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
            panel2.Controls.Add(label8);
            panel2.Controls.Add(button_atras);
            panel2.Location = new Point(0, 635);
            panel2.Name = "panel2";
            panel2.Size = new Size(1242, 95);
            panel2.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label8.Location = new Point(1001, 40);
            label8.Name = "label8";
            label8.Size = new Size(246, 41);
            label8.TabIndex = 13;
            label8.Text = "Punto de Ventas";
            // 
            // button_atras
            // 
            button_atras.Location = new Point(31, 40);
            button_atras.Name = "button_atras";
            button_atras.Size = new Size(94, 29);
            button_atras.TabIndex = 12;
            button_atras.Text = "Atras";
            button_atras.UseVisualStyleBackColor = true;
            button_atras.Click += button_atras_Click;
            // 
            // box_ventas
            // 
            box_ventas.Location = new Point(21, 195);
            box_ventas.Name = "box_ventas";
            box_ventas.Size = new Size(702, 409);
            box_ventas.TabIndex = 26;
            box_ventas.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(772, 209);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 27;
            label2.Text = "Total vendido:";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 729);
            Controls.Add(label2);
            Controls.Add(box_ventas);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}