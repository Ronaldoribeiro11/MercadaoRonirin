﻿namespace MercadaoRonirin
{
    partial class Form1
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
            this.TxtCodBar = new System.Windows.Forms.TextBox();
            this.TxtNomeProd = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtValUni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtCodBar
            // 
            this.TxtCodBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodBar.Location = new System.Drawing.Point(412, 327);
            this.TxtCodBar.Name = "TxtCodBar";
            this.TxtCodBar.Size = new System.Drawing.Size(472, 41);
            this.TxtCodBar.TabIndex = 0;
            // 
            // TxtNomeProd
            // 
            this.TxtNomeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeProd.Location = new System.Drawing.Point(412, 426);
            this.TxtNomeProd.Name = "TxtNomeProd";
            this.TxtNomeProd.Size = new System.Drawing.Size(472, 41);
            this.TxtNomeProd.TabIndex = 1;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(672, 609);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(212, 44);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add Product";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBtn.Location = new System.Drawing.Point(412, 609);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(212, 44);
            this.ReturnBtn.TabIndex = 4;
            this.ReturnBtn.Text = "Voltar";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Insira o Codigo de Barras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Insira o nome do produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Insira o valor Unitario";
            // 
            // TxtValUni
            // 
            this.TxtValUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValUni.Location = new System.Drawing.Point(412, 532);
            this.TxtValUni.Name = "TxtValUni";
            this.TxtValUni.Size = new System.Drawing.Size(472, 41);
            this.TxtValUni.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MercadaoRonirin.Properties.Resources.Mercadin__3_;
            this.ClientSize = new System.Drawing.Size(1261, 753);
            this.Controls.Add(this.TxtValUni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.TxtNomeProd);
            this.Controls.Add(this.TxtCodBar);
            this.Name = "Form1";
            this.Text = "Estoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCodBar;
        private System.Windows.Forms.TextBox TxtNomeProd;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtValUni;
    }
}