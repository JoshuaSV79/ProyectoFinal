namespace ProyectoGina
{
    partial class PagoEfectivoForm
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
            buttonConfirmarPago = new Button();
            buttonCancelar = new Button();
            total_pagar = new Label();
            labelTotal = new Label();
            SuspendLayout();
            // 
            // buttonConfirmarPago
            // 
            buttonConfirmarPago.Location = new Point(12, 59);
            buttonConfirmarPago.Name = "buttonConfirmarPago";
            buttonConfirmarPago.Size = new Size(75, 34);
            buttonConfirmarPago.TabIndex = 4;
            buttonConfirmarPago.Text = "Confirmar Pago";
            buttonConfirmarPago.Click += buttonConfirmarPago_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(142, 59);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 34);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            // 
            // total_pagar
            // 
            total_pagar.AutoSize = true;
            total_pagar.Location = new Point(118, 24);
            total_pagar.Name = "total_pagar";
            total_pagar.Size = new Size(28, 20);
            total_pagar.TabIndex = 9;
            total_pagar.Text = "0.0";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(12, 24);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(100, 20);
            labelTotal.TabIndex = 8;
            labelTotal.Text = "Total a pagar:";
            // 
            // PagoEfectivoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 140);
            Controls.Add(total_pagar);
            Controls.Add(labelTotal);
            Controls.Add(buttonConfirmarPago);
            Controls.Add(buttonCancelar);
            Name = "PagoEfectivoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PagoEfectivoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonConfirmarPago;
        private Button buttonCancelar;
        private Label total_pagar;
        private Label labelTotal;
    }
}