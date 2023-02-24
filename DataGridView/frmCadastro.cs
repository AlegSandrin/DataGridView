using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataGridView
{
    public partial class frmCadastro : Form
    {

        // variavel com a conexão com o banco de dados (localhost):
        string connectionString = "datasource=localhost;port=3306;username=root;password=password12345;database=cadastro;";

        // variavel com a conexão com o banco de dados (online) :
        // string connectionString = "datasource=sql10.freemysqlhosting.net;port=3306;username=sql10517266;password=ujiRXI7vKP;database=sql10517266;";


        public frmCadastro(string[] dados)
        {
            InitializeComponent();
            txtcod.Text = dados[0];
            txtnome.Text = dados[1];
            txtend.Text = dados[2];
            txtrg.Text = dados[3];
            txtcpf.Text = dados[4];
        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {
            if(txtcod.Text == "")
            {
                btngravar.Text = "Gravar";
            }
            else
            {
                btngravar.Text = "Atualizar";
            }
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (txtcod.Text == "")
            {
                SaveUser();
            }
            else
            {
                updateUser();
            }

            //MessageBox.Show("O código é: "+txtcod.Text, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            // query:
            string query = "SELECT * FROM cadastrar";

            // Prepara a conexão:
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
      

            try
            {
                // Inicia/Abre o banco de dados
                databaseConnection.Open();

                // Executa a query
                reader = commandDatabase.ExecuteReader();

                // Tudo executado com sucesso

                // IMPORTANTE : 
                // Se a query retornar resultados :

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Como no banco de dados criado, a array terá : id 0, nome 1, endereco 2, rg 3, cpf 4
                        // Do something with every received database ROW
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4) };
                    }
                }

                // Finally close the connection
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }


        private void SaveUser() /// CRUD : Create
        {
            string query = "INSERT INTO cadastrar(`id`, `nome`, `endereco`, `rg`, `cpf`) VALUES (NULL, '"+txtnome.Text+"', '"+txtend.Text+"', '"+txtrg.Text+"','"+txtcpf.Text+"')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Usuário registrado com sucesso");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mensagem de erro
                MessageBox.Show(ex.Message);
            }
        }

        

        private void updateUser()  /// CRUD : Update
        {
            string id = txtcod.Text;
            string query = "UPDATE `cadastrar` SET `nome` = '" + txtnome.Text + "' , `endereco` = '" + txtend.Text + "' , `rg` = '" + txtrg.Text + "', `cpf` = '" + txtcpf.Text + "' WHERE id = " + id + "";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Atualizado com Sucesso
                MessageBox.Show("Dados atualizados com sucesso!");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mensagem de erro
                MessageBox.Show(ex.Message);
            }
        }
    }
}
