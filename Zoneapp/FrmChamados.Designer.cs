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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChamados));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.dtgLista = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAssunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAnexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnHashcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgLista
            // 
            this.dtgLista.AllowUserToAddRows = false;
            this.dtgLista.AllowUserToDeleteRows = false;
            this.dtgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnTitulo,
            this.clnMotivo,
            this.clnAssunto,
            this.clnAnexo,
            this.clnStatus,
            this.clnData,
            this.clnHashcode,
            this.clnCliente,
            this.clnUsuario,
            this.clnDataFinal});
            this.dtgLista.Location = new System.Drawing.Point(33, 145);
            this.dtgLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgLista.Name = "dtgLista";
            this.dtgLista.ReadOnly = true;
            this.dtgLista.RowHeadersVisible = false;
            this.dtgLista.RowHeadersWidth = 62;
            this.dtgLista.Size = new System.Drawing.Size(1454, 588);
            this.dtgLista.TabIndex = 1;
            // 
            // clnId
            // 
            this.clnId.Frozen = true;
            this.clnId.HeaderText = "ID";
            this.clnId.MinimumWidth = 8;
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 30;
            // 
            // clnTitulo
            // 
            this.clnTitulo.Frozen = true;
            this.clnTitulo.HeaderText = "Titulo";
            this.clnTitulo.MinimumWidth = 8;
            this.clnTitulo.Name = "clnTitulo";
            this.clnTitulo.ReadOnly = true;
            this.clnTitulo.Width = 125;
            // 
            // clnMotivo
            // 
            this.clnMotivo.Frozen = true;
            this.clnMotivo.HeaderText = "MOTIVO";
            this.clnMotivo.MinimumWidth = 8;
            this.clnMotivo.Name = "clnMotivo";
            this.clnMotivo.ReadOnly = true;
            this.clnMotivo.Width = 150;
            // 
            // clnAssunto
            // 
            this.clnAssunto.Frozen = true;
            this.clnAssunto.HeaderText = "ASSUNTO";
            this.clnAssunto.MinimumWidth = 8;
            this.clnAssunto.Name = "clnAssunto";
            this.clnAssunto.ReadOnly = true;
            this.clnAssunto.Width = 150;
            // 
            // clnAnexo
            // 
            this.clnAnexo.Frozen = true;
            this.clnAnexo.HeaderText = "ANEXO";
            this.clnAnexo.MinimumWidth = 8;
            this.clnAnexo.Name = "clnAnexo";
            this.clnAnexo.ReadOnly = true;
            this.clnAnexo.Width = 150;
            // 
            // clnStatus
            // 
            this.clnStatus.Frozen = true;
            this.clnStatus.HeaderText = "Status";
            this.clnStatus.MinimumWidth = 8;
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            this.clnStatus.Width = 75;
            // 
            // clnData
            // 
            this.clnData.Frozen = true;
            this.clnData.HeaderText = "Data";
            this.clnData.MinimumWidth = 8;
            this.clnData.Name = "clnData";
            this.clnData.ReadOnly = true;
            this.clnData.Width = 75;
            // 
            // clnHashcode
            // 
            this.clnHashcode.Frozen = true;
            this.clnHashcode.HeaderText = "Hashcode";
            this.clnHashcode.MinimumWidth = 8;
            this.clnHashcode.Name = "clnHashcode";
            this.clnHashcode.ReadOnly = true;
            this.clnHashcode.Width = 150;
            // 
            // clnCliente
            // 
            this.clnCliente.Frozen = true;
            this.clnCliente.HeaderText = "Cliente";
            this.clnCliente.MinimumWidth = 8;
            this.clnCliente.Name = "clnCliente";
            this.clnCliente.ReadOnly = true;
            this.clnCliente.Width = 150;
            // 
            // clnUsuario
            // 
            this.clnUsuario.Frozen = true;
            this.clnUsuario.HeaderText = "Usuário";
            this.clnUsuario.MinimumWidth = 8;
            this.clnUsuario.Name = "clnUsuario";
            this.clnUsuario.ReadOnly = true;
            this.clnUsuario.ToolTipText = "Não atribuido";
            this.clnUsuario.Width = 150;
            // 
            // clnDataFinal
            // 
            this.clnDataFinal.Frozen = true;
            this.clnDataFinal.HeaderText = "DATAF";
            this.clnDataFinal.MinimumWidth = 8;
            this.clnDataFinal.Name = "clnDataFinal";
            this.clnDataFinal.ReadOnly = true;
            this.clnDataFinal.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(567, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "LISTA DE CHAMADOS";
            // 
            // FrmChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1521, 862);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgLista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmChamados";
            this.Text = "FrmServices";
            this.Load += new System.EventHandler(this.FrmChamados_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.DataGridView dtgLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAssunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAnexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnHashcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}