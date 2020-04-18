using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreinaWeb.AppEntity.Context;
using TreinaWeb.AppEntity.Entidades;

namespace TreinaWeb.AppEntity
{
    public partial class FrmListaPedidos : Form
    {
        public FrmListaPedidos()
        {
            InitializeComponent();
        }

        public void ListaPedidos()
        {
            try
            {
                using (AppEntityContext context = new AppEntityContext())
                {
                    var lista = context.Pedidos.Include("Produto").Include("Cliente").Select(p => new { p.PedidoId, p.NrPedido, Data = p.Data.ToString(), Produto = p.Produto.Nome, Cliente = p.Cliente.Nome });
                    dgvPedidos.DataSource = lista.ToList();
                    CriarColunaAlterar();
                    CriarColunaExcluir();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Ao atualizar o banco de dados ocorreu o erro {0}", ex.Message));
            }
        }

        private void FrmListaPedidos_Load(object sender, EventArgs e)
        {
            ListaPedidos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                using (AppEntityContext context = new AppEntityContext())
                {
                    var lista = from p in context.Pedidos.Include("Produto").Include("Cliente")
                                where p.NrPedido.Contains(txtNumPedido.Text)
                                select new { p.PedidoId, p.NrPedido, Data = p.Data.ToString(), Produto = p.Produto.Nome, Cliente = p.Cliente.Nome };

                    dgvPedidos.DataSource = lista.ToList();
                    CriarColunaAlterar();
                    CriarColunaExcluir();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Ao atualizar o banco de dados ocorreu o erro {0}", ex.Message));
            }
        }

        private void CriarColunaAlterar()
        {
            if (!dgvPedidos.Columns.Contains("Alterar"))
            {
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn.Image = Properties.Resources.icon_edit;
                imageColumn.Name = "Alterar";
                imageColumn.HeaderText = "Alterar";
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageColumn.Width = 50;
                dgvPedidos.Columns.Insert(5, imageColumn);
            }
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgvPedidos.Rows[e.RowIndex].Cells["PedidoId"].Value);

                if (e.ColumnIndex == 0)
                {
                    //Chamando formulário de cadastro/alteração.
                    var frms = this.MdiParent.MdiChildren.Where(f => f.Name.Contains("FrmCadastroPedidos"));
                    FrmCadastroPedidos frm = (FrmCadastroPedidos)frms.FirstOrDefault();

                    if (frm == null)
                        frm = new FrmCadastroPedidos();

                    frm.PedidoId = id;

                    frm.MdiParent = this.MdiParent;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }
                else if (e.ColumnIndex == 1)
                    ExcluirPedido(id);
            }
        }

        private void CriarColunaExcluir()
        {
            if (!dgvPedidos.Columns.Contains("Excluir"))
            {
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn.Image = Properties.Resources.icon_delete;
                imageColumn.Name = "Excluir";
                imageColumn.HeaderText = "Excluir";
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageColumn.Width = 50;
                dgvPedidos.Columns.Insert(5, imageColumn);
            }
        }

        private void ExcluirPedido(int id)
        {
            if (MessageBox.Show("Tem certeza que gostaria de excluir o pedido?", "Confirmação", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    using (AppEntityContext context = new AppEntityContext())
                    {
                        Pedido pedido = new Pedido() { PedidoId = id };
                        context.Pedidos.Attach(pedido);
                        context.Pedidos.Remove(pedido);
                        context.SaveChanges();

                        MessageBox.Show("Pedido removido do banco de dados com sucesso");
                        ListaPedidos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Ao atualizar o banco de dados ocorreu o erro {0}", ex.Message));
                }
            }
        }
    }
}
