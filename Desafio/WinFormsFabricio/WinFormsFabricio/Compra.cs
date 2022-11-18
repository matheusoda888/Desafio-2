using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsFabricio
{
    internal class Compra
    {
        public string idProduto;
        public string idCliente;


        public bool gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();

            SqlCommand ccmd = new SqlCommand();
            ccmd.Connection = cn;
            ccmd.Transaction = transacao;
            ccmd.CommandType = CommandType.Text;
            ccmd.CommandText = "INSERT INTO clientesProdutos VALUES (@idCliente,@idProduto);";
            ccmd.Parameters.Add("@idCliente", SqlDbType.Int);
            ccmd.Parameters.Add("@idProduto", SqlDbType.Int);
            ccmd.Parameters[0].Value = idCliente;
            ccmd.Parameters[1].Value = idProduto;

            try
            {
                ccmd.ExecuteNonQuery();
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
