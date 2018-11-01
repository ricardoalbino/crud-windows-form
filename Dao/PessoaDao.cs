using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.BD;
using WindowsForm.model;
using WindowsForm.util;

namespace WindowsForm.Dao
{
    class PessoaDao : ICrud<Pessoa>
    {
        public void Create(Pessoa entity)
        {
            string sql = "INSERT INTO PESSOA(NOME, ENDERECO, EMAIL) VALUES(@NOME, @ENDERECO, @EMAIL)";

            SqlCommand comando = new SqlCommand(sql, Conexao.conectar());
            // comando.Parameters.AddWithValue("@ID", pessoaModel.id);
            comando.Parameters.AddWithValue("@NOME", entity.Nome);
            comando.Parameters.AddWithValue("@ENDERECO", entity.Endereco);
            comando.Parameters.AddWithValue("@EMAIL", entity.Emial);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            string sql = @"DELETE FROM PESSOA WHERE ID=@ID";

            SqlCommand sqlCommand = new SqlCommand(sql, Conexao.conectar());
            try
            {
                sqlCommand.Parameters.AddWithValue("@ID", id);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexao.conectar().Close();
            }

        }

        public Pessoa GetByID(int id)
        {
            string sql = "select * from pessoa where id = @id";

            Pessoa pessoaModel = new Pessoa();

            SqlCommand command = new SqlCommand(sql, Conexao.conectar());
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                pessoaModel.Codigo = Convert.ToUInt16(reader["Id"]);
                pessoaModel.Nome = reader["nome"].ToString();
                pessoaModel.Endereco= reader["endereco"].ToString();
                pessoaModel.Emial = reader["email"].ToString();
            }


            return pessoaModel;
        }



        public void Update(Pessoa entity)
        {

            string sql = "UPDATE SET PESSOA NOME=@Nome, Endereco=@Endereco, Email=@Email WHERE @ID=" + entity.Codigo;
            SqlCommand com = new SqlCommand("InsertUpdatePessoa", Conexao.conectar());
            com.Parameters.AddWithValue("@Nome", entity.Nome);
            com.Parameters.AddWithValue("@Endereco", entity.Endereco);
            com.Parameters.AddWithValue("@Email", entity.Emial);
            com.Parameters.AddWithValue("@Id", entity.Codigo);
            com.ExecuteNonQuery();

        }
    
    

        public DataGridView carregarDataGridView(DataGridView dataGridView)
        {
            string sql = "Select * FROM Pessoa ORDER BY Nome";

            SqlCommand cmd = new SqlCommand(sql, Conexao.conectar());
           
            try
            {

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;

            }
            catch (Exception e)
            {
                throw e;
            }
            return dataGridView;

        }

        public DataGridView carregarDataGridViewID(DataGridView dataGridView, string nome)
        {
            string sql = "Select * FROM Pessoa where nome like @nome";

            SqlCommand cmd = new SqlCommand(sql, Conexao.conectar());

            try
            {
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;

            }
            catch (Exception e)
            {
                throw e;
            }
            return dataGridView;

        }
    }
}
