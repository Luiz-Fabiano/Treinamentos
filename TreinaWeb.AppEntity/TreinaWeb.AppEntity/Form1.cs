using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreinaWeb.AppEntity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frms = this.MdiChildren.Where(f => f.Name.Contains("FrmClientes"));
            FrmClientes frm = (FrmClientes)frms.FirstOrDefault();

            if (frm == null)
                frm = new FrmClientes();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frms = this.MdiChildren.Where(f => f.Name.Contains("FrmProdutos"));
            FrmProdutos frm = (FrmProdutos)frms.FirstOrDefault();

            if (frm == null)
                frm = new FrmProdutos();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frms = this.MdiChildren.Where(f => f.Name.Contains("FrmCadastroPedidos"));
            FrmCadastroPedidos frm = (FrmCadastroPedidos)frms.FirstOrDefault();

            if (frm == null)
                frm = new FrmCadastroPedidos();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirListaPedidos();
        }

        private void ExibirListaPedidos()
        {
            var frms = this.MdiChildren.Where(f => f.Name.Contains("FrmListaPedidos"));
            FrmListaPedidos frm = (FrmListaPedidos)frms.FirstOrDefault();

            if (frm == null)
                frm = new FrmListaPedidos();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirListaPedidos();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirListaPedidos();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildren.ToList().ForEach(frm => frm.Close());
            Application.Exit();
        }
    }
}
