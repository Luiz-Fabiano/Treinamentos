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
    public partial class FrmClientes : Form
    {
        private Cliente cliente;
        private AppEntityContext dc;

        public FrmClientes()
        {
            InitializeComponent();
            dc = new AppEntityContext();
        }

        public void CarregarClientes()
        {
            using (AppEntityContext dc = new AppEntityContext())
            {
                dgvClientes.DataSource = dc.Clientes.ToList();
            }
        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente == null)
                {
                    cliente = new Cliente();
                    dc.Clientes.Add(cliente);
                }

                cliente.Nome = txtNome.Text;

                dc.SaveChanges();
                MessageBox.Show("Dado salvo no banco de dados com sucesso");

                //Limpando campos
                cliente = null;
                txtNome.Text = String.Empty;
                CarregarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Ao atualizar o banco de dados ocorreu o erro {0}", ex.Message));
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["ClienteId"].Value);
                cliente = dc.Clientes.FirstOrDefault(c => c.ClienteId == id);
                if (cliente != null)
                    txtNome.Text = cliente.Nome;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente != null)
                {
                    if (MessageBox.Show("Realmente gostaria de excluir o registro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        dc.Clientes.Remove(cliente);
                        dc.SaveChanges();
                        MessageBox.Show("Dado excluído no banco de dados com sucesso");

                        //Limpando campos
                        cliente = null;
                        txtNome.Text = String.Empty;
                        CarregarClientes();
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
