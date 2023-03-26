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
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgLista
            // 
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
            this.dtgLista.Location = new System.Drawing.Point(21, 43);
            this.dtgLista.Name = "dtgLista";
            this.dtgLista.RowHeadersVisible = false;
            this.dtgLista.RowHeadersWidth = 62;
            this.dtgLista.Size = new System.Drawing.Size(969, 382);
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
            this.clnMotivo.Name = "clnMotivo";
            this.clnMotivo.ReadOnly = true;
            // 
            // clnAssunto
            // 
            this.clnAssunto.Frozen = true;
            this.clnAssunto.HeaderText = "ASSUNTO";
            this.clnAssunto.Name = "clnAssunto";
            this.clnAssunto.ReadOnly = true;
            // 
            // clnAnexo
            // 
            this.clnAnexo.Frozen = true;
            this.clnAnexo.HeaderText = "ANEXO";
            this.clnAnexo.Name = "clnAnexo";
            this.clnAnexo.ReadOnly = true;
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
            // 
            // clnCliente
            // 
            this.clnCliente.Frozen = true;
            this.clnCliente.HeaderText = "Cliente";
            this.clnCliente.MinimumWidth = 8;
            this.clnCliente.Name = "clnCliente";
            this.clnCliente.ReadOnly = true;
            // 
            // clnUsuario
            // 
            this.clnUsuario.Frozen = true;
            this.clnUsuario.HeaderText = "Usuário";
            this.clnUsuario.MinimumWidth = 8;
            this.clnUsuario.Name = "clnUsuario";
            this.clnUsuario.ReadOnly = true;
            this.clnUsuario.ToolTipText = "Não atribuido";
            // 
            // clnDataFinal
            // 
            this.clnDataFinal.Frozen = true;
            this.clnDataFinal.HeaderText = "DATAF";
            this.clnDataFinal.Name = "clnDataFinal";
            this.clnDataFinal.ReadOnly = true;
            // 
            // FrmChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 560);
            this.Controls.Add(this.dtgLista);
            this.Name = "FrmChamados";
            this.Text = "FrmServices";
            this.Load += new System.EventHandler(this.FrmChamados_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).EndInit();
            this.ResumeLayout(false);

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
    }
}