using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreinaWeb.WindowsLinqSQL
{
    public partial class Form1 : Form
    {
        AdventureWorksDataContext dc;
        public Form1()
        {
            InitializeComponent();
            dc = new AdventureWorksDataContext();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvCategoriaProduto.DataSource = dc.ProductCategories;
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dc.SubmitChanges();
                MessageBox.Show("Banco de dados atualizado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o banco de dados: " + ex.Message);
            }
        }
    }
}
