using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoneapp
{
    public partial class FrmChamados : Form
    {
        public FrmChamados()
        {
            InitializeComponent();
        }
        public void AtualizaDataGrid(int id)
        {
            dgvChamados.Rows.Clear();
            List<ItemPedido> chamados = ItemPedido.Listar(id);
            double total = 0;
            int linha = 0;
            foreach (var item in items)
            {
                dgvChamados.Add();
                dgvItens.Rows[linha].Cells[0].Value = linha + 1;
                dgvItens.Rows[linha].Cells[1].Value = item.Produto.Id.ToString();
                dgvItens.Rows[linha].Cells[2].Value = item.Produto.Descricao.ToString();
                dgvItens.Rows[linha].Cells[3].Value = item.Produto.Unidade.ToString();
                dgvItens.Rows[linha].Cells[4].Value = item.Preco.ToString();
                dgvItens.Rows[linha].Cells[5].Value = item.Quantidade.ToString();
                dgvItens.Rows[linha].Cells[6].Value = item.Desconto.ToString("##0.00");
                double totalIten = (item.Preco * item.Quantidade) - item.Desconto;
                dgvItens.Rows[linha].Cells[7].Value = totalIten.ToString("##0.00");
                linha++;
                total += totalIten;


            }
            txtTotal.Text = total.ToString("##0.00");
        }
}
