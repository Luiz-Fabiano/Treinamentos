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
    public partial class FrmProdutos : Form
    {
        private Produto produto;
        private AppEntityContext dc;

        public FrmProdutos()
        {
            InitializeComponent();
            dc = new AppEntityContext();
        }
        private void CarregarProdutos()
        {
            using (AppEntityContext dc = new AppEntityContext())
            {
                dgvProdutos.DataSource = dc.Produtos.Select(p => new { p.ProdutoId, p.Nome, p.Preco }).ToList();
            }
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (produto == null)
                {
                    produto = new Produto();
                    dc.Produtos.Add(produto);
                }

                produto.Nome = txtNome.Text;
                produto.Preco = Convert.ToDouble(txtPreco.Text);

                dc.SaveChanges();
                MessageBox.Show("Dado salvo no banco de dados com sucesso");

                //Limpando campos
                produto = null;
                txtNome.Text = String.Empty;
                txtPreco.Text = String.Empty;
                CarregarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Ao atualizar o banco de dados ocorreu o erro {0}", ex.Message));
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgvProdutos.Rows[e.RowIndex].Cells["ProdutoId"].Value);
                produto = dc.Produtos.FirstOrDefault(p => p.ProdutoId == id);
                if (produto != null)
                {
                    txtNome.Text = produto.Nome;
                    txtPreco.Text = produto.Preco.ToString();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (produto != null)
                {
                    if (MessageBox.Show("Realmente gostaria de excluir o registro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        dc.Produtos.Remove(produto);
                        dc.SaveChanges();
                        MessageBox.Show("Dado excluído no banco de dados com sucesso");

                        //Limpando campos
                        produto = null;
                        txtNome.Text = String.Empty;
                        txtPreco.Text = String.Empty;
                        CarregarProdutos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Ao atualizar o banco de dados ocorreu o erro {0}", ex.Message));
            }
        }
    }
}
