namespace ProyectoGina
{
    partial class pedido
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
            label3 = new Label();
            button_atras = new Button();
            btn_confirmar = new Button();
            pedido_richtxt = new RichTextBox();
            label2 = new Label();
            total = new Label();
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
            panel1.Size = new Size(796, 122);
            panel1.TabIndex = 10;
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
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button_atras);
            panel2.Location = new Point(0, 478);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(796, 44);
            panel2.TabIndex = 11;
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
            // btn_confirmar
            // 
            btn_confirmar.Location = new Point(688, 442);
            btn_confirmar.Margin = new Padding(3, 2, 3, 2);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(82, 22);
            btn_confirmar.TabIndex = 12;
            btn_confirmar.Text = "Confirmar";
            btn_confirmar.UseVisualStyleBackColor = true;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // pedido_richtxt
            // 
            pedido_richtxt.Location = new Point(14, 136);
            pedido_richtxt.Margin = new Padding(3, 2, 3, 2);
            pedido_richtxt.Name = "pedido_richtxt";
            pedido_richtxt.Size = new Size(504, 264);
            pedido_richtxt.TabIndex = 13;
            pedido_richtxt.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 411);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 14;
            label2.Text = "TOTAL";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Location = new Point(393, 411);
            total.Name = "total";
            total.Size = new Size(31, 15);
            total.TabIndex = 15;
            total.Text = "total";
            // 
            // pedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 522);
            Controls.Add(total);
            Controls.Add(label2);
            Controls.Add(pedido_richtxt);
            Controls.Add(btn_confirmar);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "pedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pedido";
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
        private Label label3;
        private Button button_atras;
        private Button btn_confirmar;
        private RichTextBox pedido_richtxt;
        private Label label2;
        private Label total;
    }
}