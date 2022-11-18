using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsFabricio
{
    internal class Fornecedor
    {
        public string nome;


        public bool gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();

            SqlCommand cmdd = new SqlCommand();
            cmdd.Connection = cn;
            cmdd.Transaction = transacao;
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "INSERT INTO fornecedor (nome) VALUES (@nome);";
            cmdd.Parameters.Add("@nome", SqlDbType.VarChar);

            cmdd.Parameters[0].Value = nome;

            try
            {
                cmdd.ExecuteNonQuery();
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
