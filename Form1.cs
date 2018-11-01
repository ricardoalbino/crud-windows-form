using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.BD;
using WindowsForm.Dao;
using WindowsForm.model;
using WindowsForm.util;
using WindowsForm.views;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        
            public Form1()
        {
            InitializeComponent();
          

            PessoaDao pessoaDao = new PessoaDao();
            pessoaDao.carregarDataGridView(dgvPessoa);
            Grid.configurarGridView(dgvPessoa);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FmPessoa pessoa = new FmPessoa();
            pessoa.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //captura linha ao clicar
            //int id = int.Parse(dgvPessoa.CurrentRow.Cells[0].Value.ToString());
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PessoaDao pessoaDao = new PessoaDao();
            pessoaDao.carregarDataGridViewID(dgvPessoa, txtbConsultar.Text);
            Grid.configurarGridView(dgvPessoa);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id =  int.Parse(dgvPessoa.CurrentRow.Cells[0].Value.ToString());
            var pessoa = new FmPessoa(id);
            pessoa.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvPessoa.CurrentRow.Cells[0].Value.ToString());
            if (MessageBox.Show("Deseja excluir o registro? " + id, "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Rotina para exclusão
                PessoaDao pessoaDao = new PessoaDao();
                pessoaDao.Delete(id);
                MessageBox.Show("Registro excluído com sucesso ", "Sucesso");

                //Atualiza a Grid
                pessoaDao.carregarDataGridView(dgvPessoa);
                Grid.configurarGridView(dgvPessoa);


            }
        }
    } 
}
