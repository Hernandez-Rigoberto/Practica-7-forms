namespace Practica_7_forms
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            valor = new TextBox();
            Resultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 29);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 65);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingresa Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 99);
            label3.Name = "label3";
            label3.Size = new Size(148, 15);
            label3.TabIndex = 2;
            label3.Text = "Opciones de Conversacion";
            // 
            // button1
            // 
            button1.Location = new Point(95, 131);
            button1.Name = "button1";
            button1.Size = new Size(109, 31);
            button1.TabIndex = 3;
            button1.Text = "FAHRENHEIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(229, 131);
            button2.Name = "button2";
            button2.Size = new Size(106, 31);
            button2.TabIndex = 4;
            button2.Text = "CENTIGRADOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(166, 168);
            button3.Name = "button3";
            button3.Size = new Size(92, 34);
            button3.TabIndex = 5;
            button3.Text = "BORRAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 236);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(120, 15);
            label4.TabIndex = 6;
            label4.Text = "Resultados en Grados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(166, 266);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 7;
            label5.Text = "Equivalente en Grados";
            // 
            // valor
            // 
            valor.Location = new Point(175, 62);
            valor.Name = "valor";
            valor.Size = new Size(100, 23);
            valor.TabIndex = 8;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(175, 284);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(100, 23);
            Resultado.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(800, 450);
            Controls.Add(Resultado);
            Controls.Add(valor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private TextBox valor;
        private TextBox Resultado;
    }
}