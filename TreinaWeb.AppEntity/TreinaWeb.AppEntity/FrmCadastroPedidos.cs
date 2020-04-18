using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TreinaWeb.AppEntity.Context;
using TreinaWeb.AppEntity.Entidades;

namespace TreinaWeb.AppEntity
{
    public partial class FrmCadastroPedidos : Form
    {
        public int PedidoId { get; set; }

        public FrmCadastroPedidos()
        {
            InitializeComponent();
        }

        private void CarregaClientes()
        {
            using (AppEntityContext context = new AppEntityContext())
            {
                var clientes = context.Clientes.OrderBy(c => c.Nome).ToList();

                cboClientes.ValueMember = "ClienteId";
                cboClientes.DisplayMember = "Nome";
                cboClientes.DataSource = clientes;

                cboClientes.SelectedValue = 0;
            }
        }

        private void CarregaProdutos()
        {
            using (AppEntityContext context = new AppEntityContext())
            {
                var produtos = context.Produtos.OrderBy(c => c.Nome).ToList();

                cboProdutos.ValueMember = "ProdutoId";
                cboProdutos.DisplayMember = "Nome";
                cboProdutos.DataSource = produtos;

                cboProdutos.SelectedValue = 0;
            }
        }

        private void FrmCadastroPedidos_Load(object sender, EventArgs e)
        {
            CarregaClientes();
            CarregaProdutos();
            CarregarDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (AppEntityContext context = new AppEntityContext())
                {
                    //Pedido pedido = new Pedido();

                    Pedido pedido;

                    if (PedidoId > 0)
                        pedido = context.Pedidos.Find(PedidoId);
                    else
                        pedido = new Pedido();

                    pedido.NrPedido = txtNumPedido.Text;
                    pedido.Data = dtpData.Value;

                    int idCliente = int.Parse(cboClientes.SelectedValue.ToString());
                    int idProduto = int.Parse(cboProdutos.SelectedValue.ToString());
                    pedido.Cliente = context.Clientes.FirstOrDefault(c => c.ClienteId == idCliente);
                    pedido.Produto = context.Produtos.FirstOrDefault(p => p.ProdutoId == idProduto);

                    if (PedidoId == 0)
                        context.Pedidos.Add(pedido);

                    context.SaveChanges();
                    MessageBox.Show("Dado salvo no banco de dados com sucesso");

                    ////Limpando campos
                    //txtNumPedido.Text = String.Empty;
                    //dtpData.Value = DateTime.Now;
                    //cboClientes.SelectedValue = 0;
                    //cboProdutos.SelectedValue = 0;
                    if (PedidoId > 0)
                    {
                        var frms = this.MdiChildren.Where(f => f.Name.Contains("FrmListaPedidos"));
                        FrmListaPedidos frm = (FrmListaPedidos)frms.FirstOrDefault();

                        if (frm == null)
                            frm = new FrmListaPedidos();

                        frm.ListaPedidos();
                        frm.MdiParent = this.MdiParent;
                        frm.WindowState = FormWindowState.Maximized;
                        frm.Show();
                        this.Close();
                    }
                    else
                    {
                        //Limpando campos
                        txtNumPedido.Text = String.Empty;
                        dtpData.Value = DateTime.Now;
                        cboClientes.SelectedValue = 0;
                        cboProdutos.SelectedValue = 0;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Ao atualizar o banco de dados ocorreu o erro {0}", ex.Message));
            }
        }

        private void CarregarDados()
        {
            using (AppEntityContext context = new AppEntityContext())
            {
                if (PedidoId > 0)
                {
                    Pedido pedido = context.Pedidos.Include("Cliente").Include("Produto").FirstOrDefault(p => p.PedidoId == PedidoId);

                    txtNumPedido.Text = pedido.NrPedido;
                    dtpData.Value = pedido.Data;
                    cboClientes.SelectedValue = pedido.Cliente.ClienteId;
                    cboProdutos.SelectedValue = pedido.Produto.ProdutoId;
                }
            }
        }
    }
}
