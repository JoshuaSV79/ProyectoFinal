namespace ProyectoGina
{
    partial class PagoTarjetaForm
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
            textBoxNumeroTarjeta = new TextBox();
            textBoxFechaExpiracion = new TextBox();
            textBoxCVV = new TextBox();
            buttonConfirmarPago = new Button();
            buttonCancelar = new Button();
            total_pagar = new Label();
            labelTotal = new Label();
            SuspendLayout();
            // 
            // textBoxNumeroTarjeta
            // 
            textBoxNumeroTarjeta.Location = new Point(12, 48);
            textBoxNumeroTarjeta.Name = "textBoxNumeroTarjeta";
            textBoxNumeroTarjeta.PlaceholderText = "Número de tarjeta";
            textBoxNumeroTarjeta.Size = new Size(100, 27);
            textBoxNumeroTarjeta.TabIndex = 7;
            // 
            // textBoxFechaExpiracion
            // 
            textBoxFechaExpiracion.Location = new Point(12, 88);
            textBoxFechaExpiracion.Name = "textBoxFechaExpiracion";
            textBoxFechaExpiracion.PlaceholderText = "Fecha de expiración";
            textBoxFechaExpiracion.Size = new Size(100, 27);
            textBoxFechaExpiracion.TabIndex = 8;
            // 
            // textBoxCVV
            // 
            textBoxCVV.Location = new Point(12, 128);
            textBoxCVV.Name = "textBoxCVV";
            textBoxCVV.PlaceholderText = "CVV";
            textBoxCVV.Size = new Size(100, 27);
            textBoxCVV.TabIndex = 9;
            // 
            // buttonConfirmarPago
            // 
            buttonConfirmarPago.Location = new Point(12, 168);
            buttonConfirmarPago.Name = "buttonConfirmarPago";
            buttonConfirmarPago.Size = new Size(75, 33);
            buttonConfirmarPago.TabIndex = 10;
            buttonConfirmarPago.Text = "Confirmar Pago";
            buttonConfirmarPago.Click += buttonConfirmarPago_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(142, 168);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 33);
            buttonCancelar.TabIndex = 11;
            buttonCancelar.Text = "Cancelar";
            // 
            // total_pagar
            // 
            total_pagar.AutoSize = true;
            total_pagar.Location = new Point(118, 9);
            total_pagar.Name = "total_pagar";
            total_pagar.Size = new Size(28, 20);
            total_pagar.TabIndex = 13;
            total_pagar.Text = "0.0";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(12, 9);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(100, 20);
            labelTotal.TabIndex = 12;
            labelTotal.Text = "Total a pagar:";
            // 
            // PagoTarjetaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 258);
            Controls.Add(total_pagar);
            Controls.Add(labelTotal);
            Controls.Add(textBoxNumeroTarjeta);
            Controls.Add(textBoxFechaExpiracion);
            Controls.Add(textBoxCVV);
            Controls.Add(buttonConfirmarPago);
            Controls.Add(buttonCancelar);
            Name = "PagoTarjetaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PagoTarjetaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxNumeroTarjeta;
        private TextBox textBoxFechaExpiracion;
        private TextBox textBoxCVV;
        private Button buttonConfirmarPago;
        private Button buttonCancelar;
        private Label total_pagar;
        private Label labelTotal;
    }
}