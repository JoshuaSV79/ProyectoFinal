﻿namespace ProyectoGina
{
    partial class MenuAdmin
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
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            buttonLogin = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button3 = new Button();
            button7 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-8, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1224, 173);
            panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.logo_fuby;
            pictureBox2.Location = new Point(1069, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
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
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft PhagsPa", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(358, 204);
            label2.Name = "label2";
            label2.Size = new Size(514, 58);
            label2.TabIndex = 9;
            label2.Text = "Menu de administrador";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.DarkGray;
            buttonLogin.Location = new Point(370, 301);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(155, 89);
            buttonLogin.TabIndex = 13;
            buttonLogin.Text = "Alta";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGray;
            button4.Location = new Point(370, 448);
            button4.Name = "button4";
            button4.Size = new Size(155, 89);
            button4.TabIndex = 17;
            button4.Text = "Venta";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkGray;
            button5.Location = new Point(370, 593);
            button5.Name = "button5";
            button5.Size = new Size(155, 89);
            button5.TabIndex = 18;
            button5.Text = "Grafica";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkGray;
            button6.Location = new Point(654, 593);
            button6.Name = "button6";
            button6.Size = new Size(155, 89);
            button6.TabIndex = 19;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.Location = new Point(654, 448);
            button3.Name = "button3";
            button3.Size = new Size(155, 89);
            button3.TabIndex = 16;
            button3.Text = "Lista de productos";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkGray;
            button7.Location = new Point(654, 301);
            button7.Name = "button7";
            button7.Size = new Size(155, 89);
            button7.TabIndex = 21;
            button7.Text = "Eliminar";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 807);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(buttonLogin);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private Label label2;
        private Button buttonLogin;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
        private Button button7;
        private PictureBox pictureBox2;
    }
}