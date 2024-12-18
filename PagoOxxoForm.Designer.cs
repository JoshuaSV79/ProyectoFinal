namespace ProyectoGina
{
    partial class PagoOxxoForm
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
            total_pagar = new Label();
            labelTotal = new Label();
            buttonConfirmarPago = new Button();
            buttonCancelar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // total_pagar
            // 
            total_pagar.AutoSize = true;
            total_pagar.Location = new Point(132, 25);
            total_pagar.Name = "total_pagar";
            total_pagar.Size = new Size(28, 20);
            total_pagar.TabIndex = 7;
            total_pagar.Text = "0.0";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(26, 25);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(100, 20);
            labelTotal.TabIndex = 4;
            labelTotal.Text = "Total a pagar:";
            // 
            // buttonConfirmarPago
            // 
            buttonConfirmarPago.Location = new Point(26, 226);
            buttonConfirmarPago.Name = "buttonConfirmarPago";
            buttonConfirmarPago.Size = new Size(75, 31);
            buttonConfirmarPago.TabIndex = 5;
            buttonConfirmarPago.Text = "Confirmar Pago";
            buttonConfirmarPago.Click += buttonConfirmarPago_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(154, 226);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 31);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "Cancelar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.qr;
            pictureBox1.Location = new Point(62, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // PagoOxxoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 269);
            Controls.Add(pictureBox1);
            Controls.Add(total_pagar);
            Controls.Add(labelTotal);
            Controls.Add(buttonConfirmarPago);
            Controls.Add(buttonCancelar);
            Name = "PagoOxxoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PagoOxxoForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label total_pagar;
        private Label labelTotal;
        private Button buttonConfirmarPago;
        private Button buttonCancelar;
        private PictureBox pictureBox1;
    }
}