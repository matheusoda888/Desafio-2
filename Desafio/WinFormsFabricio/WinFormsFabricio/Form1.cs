using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace WinFormsFabricio
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = textBox_Nome.Text;
            

            if (p.gravar())
            {
                MessageBox.Show("Pessoa inserida!!");
            }
            else
            {
                MessageBox.Show("Erro ao inserir");
            }

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from cliente;";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
           
            
            //dataGridView1.DataSource = dt;
        }


        
        
        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from cliente where nome = @nome;";
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            //cmd.Parameters[0].Value = textBox1.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            //dataGridView1.DataSource = dt;
        }

        

        private void buttonGravarFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor f = new Fornecedor();
            f.nome = textBox_NomeFornecedor.Text;


            if (f.gravar())
            {
                MessageBox.Show("Fornecedor inserida!!");
                
            }
            else
            {
                MessageBox.Show("Erro ao inserir");
            }
        }

        private void buttonGravarProduto_Click(object sender, EventArgs e)
        {
            
            Produto pp = new Produto();
            pp.nome = textBox_NomeProduto.Text;
            pp.fornecedor = textBox_FornecedorProduto.Text;

            if (pp.gravar())
            {
                
                MessageBox.Show("Produto inserido!!");
               


            }
            else
            {
                MessageBox.Show("Erro ao inserir");
            }
        }

        private void buttonGravarCompra_Click(object sender, EventArgs e)
        {
            textBox_IdCliente.Enabled = false;
            Compra cc = new Compra();
            cc.idCliente = textBox_IdCliente.Text;
            cc.idProduto = textBox_IdProduto.Text;

            if (cc.gravar())
            {
                MessageBox.Show("Produto inserido à nota!!");
                
            }
            else
            {
                MessageBox.Show("Erro ao inserir");
            }
           
        }
        public static string DGVtoString(DataGridView dgv, char delimiter)
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    sb.Append(cell.Value);
                    sb.Append(delimiter);
                }
                sb.Remove(sb.Length - 1, 1); // Removes the last delimiter 
                sb.AppendLine();
            }
            MessageBox.Show(sb.ToString());

            
            return sb.ToString();
            
        }
        private void button_GerarNota_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlCommand cccmd = new SqlCommand();
            cccmd.Connection = cn;
            cccmd.CommandType = CommandType.Text;
            cccmd.CommandText = "SELECT produto.nome FROM clientesProdutos INNER JOIN cliente ON cliente.id = clientesProdutos.idCliente INNER JOIN produto ON produto.id = clientesProdutos.idProduto where cliente.id=@id";
            cccmd.Parameters.Add("@id", SqlDbType.Int);
            cccmd.Parameters[0].Value = textBox_IdCliente.Text;


            SqlDataAdapter adapter = new SqlDataAdapter(cccmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView.DataSource = dt;
            DGVtoString(dataGridView, ' ');
            button1.Enabled = true;
            StreamWriter writer = new StreamWriter(@"C:\Users\OS2676\Desktop\Nota.txt");//apos o diretorio é possivel por o paramentro append = true para sobrescrever auto
            
                //PERCORRE CADA item NA LISTA linhas E OS ESCREVE NO ARQUIVO
            writer.WriteLine(DGVtoString(dataGridView, ' '));

            writer.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "DELETE w from clientesProdutos w inner join cliente c on c.id = w.idCliente where c.id=@id";
            cm.Parameters.Add("@id", SqlDbType.Int);
            cm.Parameters[0].Value = textBox_IdCliente.Text;
            cm.ExecuteNonQuery();
            MessageBox.Show("deletado");
        }
    }
}