﻿
namespace Empresa
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

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
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(401, 46);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Empregado";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 1;
            label2.Text = "Matricula";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(46, 28);
            label3.TabIndex = 2;
            label3.Text = "CPF";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(12, 150);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 3;
            label4.Text = "Nome";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.Location = new Point(12, 180);
            label5.Name = "label5";
            label5.Size = new Size(99, 28);
            label5.TabIndex = 4;
            label5.Text = "Endereço";
            label5.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 98);
            textBox1.Name = "textMatricula";
            textBox1.Size = new Size(234, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 158);
            textBox2.Name = "textNome";
            textBox2.Size = new Size(450, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(163, 128);
            textBox3.Name = "textCpf";
            textBox3.Size = new Size(234, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(163, 188);
            textBox4.Multiline = true;
            textBox4.Name = "textEndereco";
            textBox4.Size = new Size(450, 100);
            textBox4.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(901, 525);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Empresa X";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
