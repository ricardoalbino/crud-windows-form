using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm.util
{
    public static class Grid
    {
        public static void configurarGridView(DataGridView dataGridView)
        {
            //Renomear Colunas da DataGridView
            dataGridView.Columns[0].HeaderText = "Código";
            dataGridView.Columns[1].HeaderText = "Nome";
            dataGridView.Columns[2].HeaderText = "Endereço";
            dataGridView.Columns[3].HeaderText = "E-mail";

            //Redimencionar o Tamanho das Colunas DataGridView
            dataGridView.Columns[0].Width = 60;
            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[3].Width = 300;

            //Colunas Invisiveis DataGridView 
            //dgvPessoa.Columns[""].Visible = false;

        }

    }
}
