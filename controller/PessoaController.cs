using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Dao;
using WindowsForm.model;

namespace WindowsForm.controller
{
    class PessoaController
    {
        public void createController(Pessoa pessoa)
        {
            PessoaDao pessoaDao = new PessoaDao();
            pessoaDao.Create(pessoa);

         
        }

        public void UpadateController(Pessoa pessoa)
        {
            PessoaDao pessoaDao = new PessoaDao();
            pessoaDao.Update(pessoa);


        }
    }
}
