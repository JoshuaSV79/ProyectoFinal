namespace ProyectoGina
{
    partial class FormPagos
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
            buttonCancelar = new Button();
            buttonPagoTarjeta = new Button();
            buttonPagoOxxo = new Button();
            buttonPagoEfectivo = new Button();
            total_pagar = new Label();
            labelTotal = new Label();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(28, 214);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(200, 40);
            buttonCancelar.TabIndex = 9;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonPagoTarjeta
            // 
            buttonPagoTarjeta.Location = new Point(28, 164);
            buttonPagoTarjeta.Name = "buttonPagoTarjeta";
            buttonPagoTarjeta.Size = new Size(200, 40);
            buttonPagoTarjeta.TabIndex = 8;
            buttonPagoTarjeta.Text = "Pagar con Tarjeta";
            buttonPagoTarjeta.UseVisualStyleBackColor = true;
            buttonPagoTarjeta.Click += buttonPagoTarjeta_Click;
            // 
            // buttonPagoOxxo
            // 
            buttonPagoOxxo.Location = new Point(28, 114);
            buttonPagoOxxo.Name = "buttonPagoOxxo";
            buttonPagoOxxo.Size = new Size(200, 40);
            buttonPagoOxxo.TabIndex = 7;
            buttonPagoOxxo.Text = "Pagar en OXXO";
            buttonPagoOxxo.UseVisualStyleBackColor = true;
            buttonPagoOxxo.Click += buttonPagoOxxo_Click;
            // 
            // buttonPagoEfectivo
            // 
            buttonPagoEfectivo.Location = new Point(28, 64);
            buttonPagoEfectivo.Name = "buttonPagoEfectivo";
            buttonPagoEfectivo.Size = new Size(200, 40);
            buttonPagoEfectivo.TabIndex = 6;
            buttonPagoEfectivo.Text = "Pagar en Efectivo";
            buttonPagoEfectivo.UseVisualStyleBackColor = true;
            buttonPagoEfectivo.Click += buttonPagoEfectivo_Click;
            // 
            // total_pagar
            // 
            total_pagar.AutoSize = true;
            total_pagar.Location = new Point(134, 19);
            total_pagar.Name = "total_pagar";
            total_pagar.Size = new Size(28, 20);
            total_pagar.TabIndex = 11;
            total_pagar.Text = "0.0";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(28, 19);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(100, 20);
            labelTotal.TabIndex = 10;
            labelTotal.Text = "Total a pagar:";
            // 
            // FormPagos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 276);
            Controls.Add(total_pagar);
            Controls.Add(labelTotal);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonPagoTarjeta);
            Controls.Add(buttonPagoOxxo);
            Controls.Add(buttonPagoEfectivo);
            Name = "FormPagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPagos";
            Load += FormPagos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancelar;
        private Button buttonPagoTarjeta;
        private Button buttonPagoOxxo;
        private Button buttonPagoEfectivo;
        private Label total_pagar;
        private Label labelTotal;
    }
}