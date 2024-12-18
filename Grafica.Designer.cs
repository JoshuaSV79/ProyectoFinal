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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel2 = new Panel();
            label8 = new Label();
            button_atras = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(button_atras);
            panel2.Location = new Point(0, 431);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(893, 55);
            panel2.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label8.Location = new Point(683, 16);
            label8.Name = "label8";
            label8.Size = new Size(200, 32);
            label8.TabIndex = 13;
            label8.Text = "Punto de Ventas";
            label8.Click += label8_Click;
            // 
            // button_atras
            // 
            button_atras.Location = new Point(27, 16);
            button_atras.Margin = new Padding(3, 2, 3, 2);
            button_atras.Name = "button_atras";
            button_atras.Size = new Size(82, 22);
            button_atras.TabIndex = 12;
            button_atras.Text = "Atras";
            button_atras.UseVisualStyleBackColor = true;
            button_atras.Click += button_atras_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(207, 61);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(472, 300);
            chart1.TabIndex = 25;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // Grafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 486);
            Controls.Add(chart1);
            Controls.Add(panel2);
            Name = "Grafica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grafica";
            Load += Grafica_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label8;
        private Button button_atras;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}