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
using WindowsForm.controller;
using WindowsForm.Dao;
using WindowsForm.model;

namespace WindowsForm.views
{
    public partial class FmPessoa : Form
    {
        PessoaDao pessoaDao = new PessoaDao();
        public FmPessoa()
        {
            InitializeComponent();
           
        }

        public FmPessoa(int id)
        {
            InitializeComponent();

           

            Pessoa pessoa = pessoaDao.GetByID(id);
            textBCod.Text = pessoa.Codigo.ToString();
            txtbNome.Text = pessoa.Nome;
            textBEndereco.Text = pessoa.Endereco;
            textBEmail.Text = pessoa.Emial;

        }

            private void FmPessoa_Load(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtbNome.Text == "")
            {
                MessageBox.Show("Campo nome deve ser Preenchido!");
            }

            else if (textBEndereco.Text == "")
            {
                MessageBox.Show("Campo Endereco deve ser Preenchido!");
            }


            else if(textBEmail.Text == "")
            {
                MessageBox.Show("Campo Email deve ser Preenchido!");
            }

            Pessoa pessoa = new Pessoa();
            PessoaController pessoaController = new PessoaController();
            if (int.Parse(textBCod.Text) > 0)
            {
                
                pessoa.Nome = txtbNome.Text;
                pessoa.Endereco = textBEndereco.Text;
                pessoa.Emial = textBEmail.Text;
                pessoaController.createController(pessoa);
            }

               pessoaController.UpadateController(pessoa);




        }
    }
}
