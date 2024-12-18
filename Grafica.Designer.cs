namespace ProyectoGina
{
    partial class Grafica
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
            panel2 = new Panel();
            label8 = new Label();
            button_atras = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(button_atras);
            panel2.Location = new Point(0, 575);
            panel2.Name = "panel2";
            panel2.Size = new Size(1021, 73);
            panel2.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label8.Location = new Point(781, 21);
            label8.Name = "label8";
            label8.Size = new Size(246, 41);
            label8.TabIndex = 13;
            label8.Text = "Punto de Ventas";
            label8.Click += label8_Click;
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
            // Grafica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 648);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Grafica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grafica";
            Load += Grafica_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label8;
        private Button button_atras;
    }
}