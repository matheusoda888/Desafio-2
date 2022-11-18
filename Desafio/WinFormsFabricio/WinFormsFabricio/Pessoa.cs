using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsFabricio
{
    internal class Pessoa
    {
        
        public string nome;
        

        public bool gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = transacao;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO cliente VALUES (@nome);";
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            
            cmd.Parameters[0].Value = nome;
            
            try
            {
                cmd.ExecuteNonQuery();
                transacao.Commit();
                return true;
            }
            catch(Exception ex)
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
