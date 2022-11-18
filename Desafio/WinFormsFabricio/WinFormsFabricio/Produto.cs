using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsFabricio
{
    internal class Produto
    {
        public string nome;
        public string fornecedor;

        public bool gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();

            SqlCommand cmddd = new SqlCommand();
            cmddd.Connection = cn;
            cmddd.Transaction = transacao;
            cmddd.CommandType = CommandType.Text;
            cmddd.CommandText = "INSERT INTO produto (nome, idFornecedor) VALUES (@nome,@idFornecedor);";
            cmddd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmddd.Parameters.Add("@idFornecedor", SqlDbType.Int);
            MessageBox.Show(nome, fornecedor);
            cmddd.Parameters[0].Value = nome;
            cmddd.Parameters[1].Value = fornecedor;

            try
            {
                cmddd.ExecuteNonQuery();
                transacao.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }

        }
    }
}
