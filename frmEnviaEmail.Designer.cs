namespace Envio_Email
{
    partial class Email
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Email));
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTesteEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEmail = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnEmailRecente = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnLimparTabela = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmail)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(407, 500);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(54, 30);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Quantidade de Emails:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 509);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(38, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(770, 500);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 30);
            this.button3.TabIndex = 11;
            this.button3.Text = "Fechar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTesteEmail);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtDe);
            this.groupBox3.Controls.Add(this.txtPara);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtAssunto);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(4, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 151);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados:";
            // 
            // txtTesteEmail
            // 
            this.txtTesteEmail.Location = new System.Drawing.Point(331, 52);
            this.txtTesteEmail.Name = "txtTesteEmail";
            this.txtTesteEmail.Size = new System.Drawing.Size(60, 20);
            this.txtTesteEmail.TabIndex = 17;
            this.txtTesteEmail.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(332, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(60, 20);
            this.txtID.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(251, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 17);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(62, 118);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 17);
            this.listBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Anexo:";
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(62, 19);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(237, 20);
            this.txtDe.TabIndex = 2;
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(62, 49);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(237, 20);
            this.txtPara.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Assunto:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(62, 78);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(237, 20);
            this.txtAssunto.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Para:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "De:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEmail);
            this.groupBox2.Location = new System.Drawing.Point(407, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 482);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "E-mail:";
            // 
            // dgvEmail
            // 
            this.dgvEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmail.Location = new System.Drawing.Point(6, 19);
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.Size = new System.Drawing.Size(464, 457);
            this.dgvEmail.TabIndex = 0;
            this.dgvEmail.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmail_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMsg);
            this.groupBox1.Location = new System.Drawing.Point(4, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 325);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mensagem:";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(6, 19);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(386, 300);
            this.txtMsg.TabIndex = 7;
            this.txtMsg.Text = "Insira aqui sua mensagem.";
            // 
            // btnEmailRecente
            // 
            this.btnEmailRecente.Location = new System.Drawing.Point(532, 500);
            this.btnEmailRecente.Name = "btnEmailRecente";
            this.btnEmailRecente.Size = new System.Drawing.Size(113, 30);
            this.btnEmailRecente.TabIndex = 30;
            this.btnEmailRecente.Text = "E-mail Recente";
            this.btnEmailRecente.UseVisualStyleBackColor = true;
            this.btnEmailRecente.Click += new System.EventHandler(this.btnEmailRecente_Click);
            // 
            // btnLimparTabela
            // 
            this.btnLimparTabela.Location = new System.Drawing.Point(651, 500);
            this.btnLimparTabela.Name = "btnLimparTabela";
            this.btnLimparTabela.Size = new System.Drawing.Size(113, 30);
            this.btnLimparTabela.TabIndex = 31;
            this.btnLimparTabela.Text = "Limpa Tabela Banco";
            this.btnLimparTabela.UseVisualStyleBackColor = true;
            this.btnLimparTabela.Click += new System.EventHandler(this.btnLimparTabela_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 541);
            this.Controls.Add(this.btnLimparTabela);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEmailRecente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnviar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(904, 579);
            this.MinimumSize = new System.Drawing.Size(904, 579);
            this.Name = "Email";
            this.Text = "frmEnviaEmail";
            this.Load += new System.EventHandler(this.Email_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMsg;
        public System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDe;
        public System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnEmailRecente;
        private System.Windows.Forms.BindingSource bindingSource1;
        public System.Windows.Forms.TextBox txtTesteEmail;
        private System.Windows.Forms.Button btnLimparTabela;
    }
}