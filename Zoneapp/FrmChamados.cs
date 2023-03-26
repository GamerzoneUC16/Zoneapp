using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoneclass;

namespace Zoneapp
{
    public partial class FrmChamados : Form
    {
        public FrmChamados()
        {
            InitializeComponent();
        }
        private void FrmChamados_Load(object sender, EventArgs e)
        {
             

        }

        private void dtgLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FrmChamados_Load_1(object sender, EventArgs e)
        {
            var lista = Chamados.Listar();
            int linha = 0;

            foreach (var item in lista)
            {
                dtgLista.Rows.Add();
                dtgLista.Rows[linha].Cells[0].Value = item.Id;
                dtgLista.Rows[linha].Cells[1].Value = item.Titulo;
                dtgLista.Rows[linha].Cells[2].Value = item.Motivo;
                dtgLista.Rows[linha].Cells[3].Value = item.Assunto;
                dtgLista.Rows[linha].Cells[4].Value = item.Anexo;
                dtgLista.Rows[linha].Cells[5].Value = item.Status;
                dtgLista.Rows[linha].Cells[6].Value = item.Data;
                dtgLista.Rows[linha].Cells[7].Value = item.Hashcode;
                dtgLista.Rows[linha].Cells[8].Value = item.Cliente;
                dtgLista.Rows[linha].Cells[9].Value = item.Usuario;
                dtgLista.Rows[linha].Cells[10].Value = item.Data_Final;
                linha++;
            }
        }
    }
}
