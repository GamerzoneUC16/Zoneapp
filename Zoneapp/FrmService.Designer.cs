namespace Zoneapp
{
    partial class FrmService
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GBChamado = new System.Windows.Forms.GroupBox();
            this.tituloChamado = new System.Windows.Forms.TextBox();
            this.descricaoChamado = new System.Windows.Forms.TextBox();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResponder = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GBresposta = new System.Windows.Forms.GroupBox();
            this.textBoxResposta = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tituloResposta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.codigo = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.GBChamado.SuspendLayout();
            this.GBresposta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.btnVoltar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.GBresposta);
            this.groupBox1.Controls.Add(this.GBChamado);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1097, 709);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tela de Serviço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GBChamado
            // 
            this.GBChamado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(47)))), ((int)(((byte)(95)))));
            this.GBChamado.Controls.Add(this.comboBox3);
            this.GBChamado.Controls.Add(this.comboBox2);
            this.GBChamado.Controls.Add(this.codigo);
            this.GBChamado.Controls.Add(this.checkBoxAtivo);
            this.GBChamado.Controls.Add(this.label7);
            this.GBChamado.Controls.Add(this.label3);
            this.GBChamado.Controls.Add(this.groupBox3);
            this.GBChamado.Controls.Add(this.btnResponder);
            this.GBChamado.Controls.Add(this.label2);
            this.GBChamado.Controls.Add(this.pictureBox1);
            this.GBChamado.Controls.Add(this.textBoxCliente);
            this.GBChamado.Controls.Add(this.descricaoChamado);
            this.GBChamado.Controls.Add(this.tituloChamado);
            this.GBChamado.Controls.Add(this.label1);
            this.GBChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBChamado.ForeColor = System.Drawing.SystemColors.Window;
            this.GBChamado.Location = new System.Drawing.Point(162, 119);
            this.GBChamado.Name = "GBChamado";
            this.GBChamado.Size = new System.Drawing.Size(793, 276);
            this.GBChamado.TabIndex = 1;
            this.GBChamado.TabStop = false;
            this.GBChamado.Text = "Chamado";
            // 
            // tituloChamado
            // 
            this.tituloChamado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.tituloChamado.Enabled = false;
            this.tituloChamado.Location = new System.Drawing.Point(104, 112);
            this.tituloChamado.Name = "tituloChamado";
            this.tituloChamado.Size = new System.Drawing.Size(274, 29);
            this.tituloChamado.TabIndex = 1;
            // 
            // descricaoChamado
            // 
            this.descricaoChamado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.descricaoChamado.Enabled = false;
            this.descricaoChamado.Location = new System.Drawing.Point(104, 188);
            this.descricaoChamado.Multiline = true;
            this.descricaoChamado.Name = "descricaoChamado";
            this.descricaoChamado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descricaoChamado.Size = new System.Drawing.Size(538, 68);
            this.descricaoChamado.TabIndex = 2;
            this.descricaoChamado.TextChanged += new System.EventHandler(this.descricaoChamado_TextChanged);
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.textBoxCliente.Enabled = false;
            this.textBoxCliente.Location = new System.Drawing.Point(104, 51);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(224, 29);
            this.textBoxCliente.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Título";
            // 
            // btnResponder
            // 
            this.btnResponder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnResponder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponder.ForeColor = System.Drawing.Color.White;
            this.btnResponder.Location = new System.Drawing.Point(666, 188);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(112, 42);
            this.btnResponder.TabIndex = 7;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 416);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 66);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // GBresposta
            // 
            this.GBresposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(47)))), ((int)(((byte)(95)))));
            this.GBresposta.Controls.Add(this.label5);
            this.GBresposta.Controls.Add(this.label4);
            this.GBresposta.Controls.Add(this.tituloResposta);
            this.GBresposta.Controls.Add(this.btnAtualizar);
            this.GBresposta.Controls.Add(this.btnEditar);
            this.GBresposta.Controls.Add(this.btnEnviar);
            this.GBresposta.Controls.Add(this.textBoxResposta);
            this.GBresposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBresposta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GBresposta.Location = new System.Drawing.Point(162, 401);
            this.GBresposta.Name = "GBresposta";
            this.GBresposta.Size = new System.Drawing.Size(793, 288);
            this.GBresposta.TabIndex = 2;
            this.GBresposta.TabStop = false;
            this.GBresposta.Text = "Resposta ao Cliente";
            // 
            // textBoxResposta
            // 
            this.textBoxResposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.textBoxResposta.Location = new System.Drawing.Point(142, 106);
            this.textBoxResposta.Multiline = true;
            this.textBoxResposta.Name = "textBoxResposta";
            this.textBoxResposta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResposta.Size = new System.Drawing.Size(391, 128);
            this.textBoxResposta.TabIndex = 3;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(550, 148);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(95, 39);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(550, 106);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(95, 36);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(550, 193);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(95, 41);
            this.btnAtualizar.TabIndex = 10;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome do Cliente";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tituloResposta
            // 
            this.tituloResposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.tituloResposta.Location = new System.Drawing.Point(142, 53);
            this.tituloResposta.Name = "tituloResposta";
            this.tituloResposta.Size = new System.Drawing.Size(224, 29);
            this.tituloResposta.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Título";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Resposta";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Zoneapp.Properties.Resources.GamerZone_logo;
            this.pictureBox3.Location = new System.Drawing.Point(981, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(98, 84);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = global::Zoneapp.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(65, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 39);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "Usuário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(356, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(366, 41);
            this.label6.TabIndex = 16;
            this.label6.Text = "GamerZone SERVICES";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnVoltar.Location = new System.Drawing.Point(6, 119);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(97, 40);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Zoneapp.Properties.Resources.GamerZone_logo;
            this.pictureBox4.Location = new System.Drawing.Point(0, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(108, 82);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(396, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Motivo";
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.Location = new System.Drawing.Point(16, 200);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(75, 28);
            this.checkBoxAtivo.TabIndex = 20;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(574, 16);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(213, 24);
            this.codigo.TabIndex = 21;
            this.codigo.Text = "#Código do Chamado";
            this.codigo.Click += new System.EventHandler(this.codigo_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(657, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 32);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.Text = "Status";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(401, 109);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(244, 32);
            this.comboBox3.TabIndex = 22;
            // 
            // FrmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 711);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmService";
            this.Text = "FrmService";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBChamado.ResumeLayout(false);
            this.GBChamado.PerformLayout();
            this.GBresposta.ResumeLayout(false);
            this.GBresposta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GBChamado;
        private System.Windows.Forms.TextBox descricaoChamado;
        private System.Windows.Forms.TextBox tituloChamado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.GroupBox GBresposta;
        private System.Windows.Forms.TextBox textBoxResposta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tituloResposta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label codigo;
    }
}