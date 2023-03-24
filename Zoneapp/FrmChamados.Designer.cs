namespace Zoneapp
{
    partial class FrmChamados
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHashcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAssunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUsuarioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1336, 785);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Chamados";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Image = global::Zoneapp.Properties.Resources.GamerZone_logo;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(6, 720);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 70);
            this.label7.TabIndex = 13;
            this.label7.Text = "              ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Image = global::Zoneapp.Properties.Resources.GamerZone_logo;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(1213, 720);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 70);
            this.label6.TabIndex = 12;
            this.label6.Text = "              ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(761, 720);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "DELETAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(520, 720);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "ATUALIZAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(587, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "LISTA DE CHAMADOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Image = global::Zoneapp.Properties.Resources.GamerZone_logo;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(6, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 70);
            this.label3.TabIndex = 6;
            this.label3.Text = "              ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Image = global::Zoneapp.Properties.Resources.GamerZone_logo;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(1213, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 70);
            this.label2.TabIndex = 5;
            this.label2.Text = "              ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(343, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 70);
            this.label1.TabIndex = 4;
            this.label1.Text = "              GAMERZONE CALLED";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnHashcode,
            this.ColumnTitulo,
            this.ColumnAssunto,
            this.ColumnIdCliente,
            this.ColumnUsuarioId,
            this.ColumnResposta,
            this.ColumnData,
            this.ColumnAtivo});
            this.dataGridView1.Location = new System.Drawing.Point(96, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 581);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnID
            // 
            this.ColumnID.Frozen = true;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MinimumWidth = 8;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 50;
            // 
            // ColumnHashcode
            // 
            this.ColumnHashcode.Frozen = true;
            this.ColumnHashcode.HeaderText = "Hashcode";
            this.ColumnHashcode.MinimumWidth = 8;
            this.ColumnHashcode.Name = "ColumnHashcode";
            this.ColumnHashcode.ReadOnly = true;
            this.ColumnHashcode.Width = 150;
            // 
            // ColumnTitulo
            // 
            this.ColumnTitulo.Frozen = true;
            this.ColumnTitulo.HeaderText = "Titulo";
            this.ColumnTitulo.MinimumWidth = 8;
            this.ColumnTitulo.Name = "ColumnTitulo";
            this.ColumnTitulo.ReadOnly = true;
            this.ColumnTitulo.Width = 150;
            // 
            // ColumnAssunto
            // 
            this.ColumnAssunto.FillWeight = 500F;
            this.ColumnAssunto.Frozen = true;
            this.ColumnAssunto.HeaderText = "Assunto";
            this.ColumnAssunto.MinimumWidth = 8;
            this.ColumnAssunto.Name = "ColumnAssunto";
            this.ColumnAssunto.ReadOnly = true;
            this.ColumnAssunto.Width = 180;
            // 
            // ColumnIdCliente
            // 
            this.ColumnIdCliente.Frozen = true;
            this.ColumnIdCliente.HeaderText = "Cliente";
            this.ColumnIdCliente.MinimumWidth = 8;
            this.ColumnIdCliente.Name = "ColumnIdCliente";
            this.ColumnIdCliente.ReadOnly = true;
            this.ColumnIdCliente.Width = 130;
            // 
            // ColumnUsuarioId
            // 
            this.ColumnUsuarioId.Frozen = true;
            this.ColumnUsuarioId.HeaderText = "Usuário";
            this.ColumnUsuarioId.MinimumWidth = 8;
            this.ColumnUsuarioId.Name = "ColumnUsuarioId";
            this.ColumnUsuarioId.ReadOnly = true;
            this.ColumnUsuarioId.Width = 130;
            // 
            // ColumnResposta
            // 
            this.ColumnResposta.Frozen = true;
            this.ColumnResposta.HeaderText = "Resposta";
            this.ColumnResposta.MinimumWidth = 8;
            this.ColumnResposta.Name = "ColumnResposta";
            this.ColumnResposta.ReadOnly = true;
            this.ColumnResposta.Width = 180;
            // 
            // ColumnData
            // 
            this.ColumnData.Frozen = true;
            this.ColumnData.HeaderText = "Data";
            this.ColumnData.MinimumWidth = 8;
            this.ColumnData.Name = "ColumnData";
            this.ColumnData.ReadOnly = true;
            this.ColumnData.Width = 150;
            // 
            // ColumnAtivo
            // 
            this.ColumnAtivo.HeaderText = "Ativo";
            this.ColumnAtivo.MinimumWidth = 8;
            this.ColumnAtivo.Name = "ColumnAtivo";
            this.ColumnAtivo.Width = 150;
            // 
            // FrmChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 801);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmChamados";
            this.Text = "FrmServices";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHashcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAssunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsuarioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnAtivo;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
    }
}