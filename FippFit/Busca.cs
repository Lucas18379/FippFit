using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FippFit
{
    public partial class Busca : Form
    {
        DataTable dt = new DataTable();
        public Busca(DataGridView dgvFippFit,DataTable d)
        {
            InitializeComponent();
            dgvBusca.DataSource = dgvFippFit.DataSource;
            dt = d;
        }

        public Busca()
        {
            InitializeComponent();
        }
        private void bPesquisar_Click(object sender, EventArgs e)
        {
            if (tbId.Text.Trim() == "")
            {
                return;
            }
            DataRow[] dr = dt.Select("ID = " + tbId.Text);
            if (dr.Length > 0)
            {
                for (int i = 0; i < dgvBusca.Rows.Count; i++)
                {
                    if (((DataRowView)dgvBusca.Rows[i].DataBoundItem).Row == dr[0])
                    {  
                        dgvBusca.Rows[i].Selected = true;
                        dgvBusca.FirstDisplayedScrollingRowIndex = dgvBusca.SelectedRows[0].Index;
                        break;
                    }
                }             
            }
            else
                MessageBox.Show("ID não encontrado.", "Informação", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bSelecionar_Click(object sender, EventArgs e)
        {
        }
    }
}
