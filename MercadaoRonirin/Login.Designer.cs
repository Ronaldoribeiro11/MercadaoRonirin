namespace MercadaoRonirin
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeLog = new System.Windows.Forms.TextBox();
            this.txtSenhaLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.PanalCad = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.CbServico = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeCad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaCad = new System.Windows.Forms.TextBox();
            this.txtEmailCad = new System.Windows.Forms.TextBox();
            this.PanelRecEmail = new System.Windows.Forms.Panel();
            this.pancod = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btncod = new System.Windows.Forms.Button();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnRecEmail = new System.Windows.Forms.Button();
            this.TxtRecEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PanalCad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelRecEmail.SuspendLayout();
            this.pancod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomeLog
            // 
            this.txtNomeLog.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLog.Location = new System.Drawing.Point(467, 400);
            this.txtNomeLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeLog.Name = "txtNomeLog";
            this.txtNomeLog.Size = new System.Drawing.Size(341, 42);
            this.txtNomeLog.TabIndex = 1;
            // 
            // txtSenhaLog
            // 
            this.txtSenhaLog.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaLog.Location = new System.Drawing.Point(467, 494);
            this.txtSenhaLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenhaLog.Name = "txtSenhaLog";
            this.txtSenhaLog.Size = new System.Drawing.Size(341, 42);
            this.txtSenhaLog.TabIndex = 3;
            this.txtSenhaLog.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(549, 574);
            this.btnLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(159, 69);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "ENTRAR";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.SystemColors.ActiveBorder;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(463, 446);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 16);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cadastrar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.SystemColors.ActiveBorder;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(463, 538);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(126, 16);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Esqueceu a senha?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked_1);
            // 
            // PanalCad
            // 
            this.PanalCad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanalCad.Controls.Add(this.label9);
            this.PanalCad.Controls.Add(this.CbServico);
            this.PanalCad.Controls.Add(this.pictureBox1);
            this.PanalCad.Controls.Add(this.btnCad);
            this.PanalCad.Controls.Add(this.label5);
            this.PanalCad.Controls.Add(this.txtNomeCad);
            this.PanalCad.Controls.Add(this.label6);
            this.PanalCad.Controls.Add(this.label4);
            this.PanalCad.Controls.Add(this.label3);
            this.PanalCad.Controls.Add(this.txtSenhaCad);
            this.PanalCad.Controls.Add(this.txtEmailCad);
            this.PanalCad.Location = new System.Drawing.Point(1, 73);
            this.PanalCad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanalCad.Name = "PanalCad";
            this.PanalCad.Size = new System.Drawing.Size(445, 607);
            this.PanalCad.TabIndex = 7;
            this.PanalCad.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "Serviço:";
            // 
            // CbServico
            // 
            this.CbServico.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbServico.FormattingEnabled = true;
            this.CbServico.Items.AddRange(new object[] {
            "Caixa",
            "Estacionamento",
            "Estoque"});
            this.CbServico.Location = new System.Drawing.Point(44, 434);
            this.CbServico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbServico.Name = "CbServico";
            this.CbServico.Size = new System.Drawing.Size(341, 43);
            this.CbServico.TabIndex = 13;
            this.CbServico.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MercadaoRonirin.Properties.Resources.Mercadin__2__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-191, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(828, 162);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnCad
            // 
            this.btnCad.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad.Location = new System.Drawing.Point(100, 501);
            this.btnCad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(225, 69);
            this.btnCad.TabIndex = 8;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nome:";
            // 
            // txtNomeCad
            // 
            this.txtNomeCad.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCad.Location = new System.Drawing.Point(44, 191);
            this.txtNomeCad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeCad.Name = "txtNomeCad";
            this.txtNomeCad.Size = new System.Drawing.Size(341, 42);
            this.txtNomeCad.TabIndex = 10;
            this.txtNomeCad.TextChanged += new System.EventHandler(this.txtLoginCad_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-379, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email:";
            // 
            // txtSenhaCad
            // 
            this.txtSenhaCad.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCad.Location = new System.Drawing.Point(44, 353);
            this.txtSenhaCad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenhaCad.Name = "txtSenhaCad";
            this.txtSenhaCad.Size = new System.Drawing.Size(341, 42);
            this.txtSenhaCad.TabIndex = 9;
            this.txtSenhaCad.UseSystemPasswordChar = true;
            // 
            // txtEmailCad
            // 
            this.txtEmailCad.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCad.Location = new System.Drawing.Point(44, 274);
            this.txtEmailCad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailCad.Name = "txtEmailCad";
            this.txtEmailCad.Size = new System.Drawing.Size(341, 42);
            this.txtEmailCad.TabIndex = 8;
            // 
            // PanelRecEmail
            // 
            this.PanelRecEmail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanelRecEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelRecEmail.Controls.Add(this.pancod);
            this.PanelRecEmail.Controls.Add(this.pictureBox2);
            this.PanelRecEmail.Controls.Add(this.BtnRecEmail);
            this.PanelRecEmail.Controls.Add(this.TxtRecEmail);
            this.PanelRecEmail.Controls.Add(this.label7);
            this.PanelRecEmail.Controls.Add(this.label8);
            this.PanelRecEmail.Location = new System.Drawing.Point(832, 73);
            this.PanelRecEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelRecEmail.Name = "PanelRecEmail";
            this.PanelRecEmail.Size = new System.Drawing.Size(445, 607);
            this.PanelRecEmail.TabIndex = 13;
            this.PanelRecEmail.Visible = false;
            // 
            // pancod
            // 
            this.pancod.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pancod.Controls.Add(this.label10);
            this.pancod.Controls.Add(this.btncod);
            this.pancod.Controls.Add(this.txtcod);
            this.pancod.Location = new System.Drawing.Point(3, 501);
            this.pancod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pancod.Name = "pancod";
            this.pancod.Size = new System.Drawing.Size(445, 386);
            this.pancod.TabIndex = 14;
            this.pancod.Visible = false;
            this.pancod.Paint += new System.Windows.Forms.PaintEventHandler(this.pancod_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(400, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Insira o codigo de verificação enviado no email";
            // 
            // btncod
            // 
            this.btncod.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncod.Location = new System.Drawing.Point(119, 272);
            this.btncod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncod.Name = "btncod";
            this.btncod.Size = new System.Drawing.Size(225, 69);
            this.btncod.TabIndex = 15;
            this.btncod.Text = "Cadastrar";
            this.btncod.UseVisualStyleBackColor = true;
            this.btncod.Click += new System.EventHandler(this.btncod_Click);
            // 
            // txtcod
            // 
            this.txtcod.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.Location = new System.Drawing.Point(63, 198);
            this.txtcod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(341, 42);
            this.txtcod.TabIndex = 15;
            this.txtcod.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::MercadaoRonirin.Properties.Resources.Recuperar_senha_removebg_preview;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(92, 42);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(299, 256);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // BtnRecEmail
            // 
            this.BtnRecEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecEmail.Location = new System.Drawing.Point(136, 379);
            this.BtnRecEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRecEmail.Name = "BtnRecEmail";
            this.BtnRecEmail.Size = new System.Drawing.Size(173, 53);
            this.BtnRecEmail.TabIndex = 15;
            this.BtnRecEmail.Text = "Enviar Codigo";
            this.BtnRecEmail.UseVisualStyleBackColor = true;
            this.BtnRecEmail.Click += new System.EventHandler(this.BtnRecEmail_Click);
            // 
            // TxtRecEmail
            // 
            this.TxtRecEmail.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecEmail.Location = new System.Drawing.Point(60, 327);
            this.TxtRecEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRecEmail.Name = "TxtRecEmail";
            this.TxtRecEmail.Size = new System.Drawing.Size(341, 42);
            this.TxtRecEmail.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Insira seu Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-379, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Senha";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MercadaoRonirin.Properties.Resources.Mercadin__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 753);
            this.Controls.Add(this.PanelRecEmail);
            this.Controls.Add(this.PanalCad);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtSenhaLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeLog);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Login_Load);
            this.PanalCad.ResumeLayout(false);
            this.PanalCad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelRecEmail.ResumeLayout(false);
            this.PanelRecEmail.PerformLayout();
            this.pancod.ResumeLayout(false);
            this.pancod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeLog;
        private System.Windows.Forms.TextBox txtSenhaLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Panel PanalCad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaCad;
        private System.Windows.Forms.TextBox txtEmailCad;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeCad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelRecEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtRecEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnRecEmail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox CbServico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pancod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btncod;
        private System.Windows.Forms.TextBox txtcod;
    }
}

