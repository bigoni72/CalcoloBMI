﻿namespace CalcoloBMI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            tBoxAltezza = new TextBox();
            label2 = new Label();
            tBoxPeso = new TextBox();
            label3 = new Label();
            tBoxRisultato = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(74, 230);
            button1.Name = "button1";
            button1.Size = new Size(107, 34);
            button1.TabIndex = 0;
            button1.Text = "Calcolo BMI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(74, 284);
            button2.Name = "button2";
            button2.Size = new Size(107, 37);
            button2.TabIndex = 1;
            button2.Text = "Azzera";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 56);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Altezza";
            // 
            // tBoxAltezza
            // 
            tBoxAltezza.Location = new Point(193, 53);
            tBoxAltezza.Name = "tBoxAltezza";
            tBoxAltezza.Size = new Size(100, 23);
            tBoxAltezza.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 107);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 4;
            label2.Text = "Peso";
            // 
            // tBoxPeso
            // 
            tBoxPeso.Location = new Point(193, 99);
            tBoxPeso.Name = "tBoxPeso";
            tBoxPeso.Size = new Size(100, 23);
            tBoxPeso.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 139);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 6;
            label3.Text = "Risultato";
            // 
            // tBoxRisultato
            // 
            tBoxRisultato.Location = new Point(193, 136);
            tBoxRisultato.Multiline = true;
            tBoxRisultato.Name = "tBoxRisultato";
            tBoxRisultato.Size = new Size(576, 72);
            tBoxRisultato.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tBoxRisultato);
            Controls.Add(label3);
            Controls.Add(tBoxPeso);
            Controls.Add(label2);
            Controls.Add(tBoxAltezza);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox tBoxAltezza;
        private Label label2;
        private TextBox tBoxPeso;
        private Label label3;
        private TextBox tBoxRisultato;
    }
}
