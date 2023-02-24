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
    public partial class Form1 : Form
    {
        // variavel com a conexão com o banco de dados (localhost):
        string connectionString = "datasource=localhost;port=3306;username=root;password=password12345;database=cadastro;";

        // variavel com a conexão com o banco de dados (online) :
        //string connectionString = "datasource=sql10.freemysqlhosting.net;port=3312;username=sql10517266;password=ujiRXI7vKP;database=sql10517266;";


        public Form1()
        {
            InitializeComponent();
        }

        private void btnnome_Click(object sender, EventArgs e)
        {
            string[] vazia = {"","","","",""};
            frmCadastro frm = new frmCadastro(vazia);
            frm.Show();

        }
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            deleteUser();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxPesquisa.SelectedIndex = 0;
            // query:
            string query = "SELECT * FROM cadastrar";

            // Prepara a conexão:
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            listUsers(); //atualiza a lista com os dados registrados no banco de dados assim que o forms é iniciado

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
                else
                {
                    MessageBox.Show("Nenhum registro encontrado.");
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

        private void listUsers() /// CRUD : Show
        {
            // Select all
            string query = "SELECT * FROM cadastrar";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            // MySqlDataAdapter adapter = new MySqlDataAdapter(commandDatabase);
            // DataTable data = new DataTable();
            // adapter.Fill(data);

            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                // Conectado com sucesso, agora lista os resgistro

                // Se existem registros...
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Mostra os registros na listView1
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4) };
                        var listViewItem = new ListViewItem(row);
                        dataGridView1.Rows.Add(row);



                    }
                }
                else
                {
                    // Caso não haja registros
                    Console.WriteLine("Nenhum registro encontrado.");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteUser() /// CRUD : Delete
        {
            //string id = listView1.SelectedItems[0].Text.ToString();
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string query = "DELETE FROM `cadastrar` WHERE id = " + id + "";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Deletado com sucesso
                MessageBox.Show("Usuário deletado com sucesso!");
                dataGridView1.Rows.Clear();
                listUsers();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mensagem de erro
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string nome = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string end = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string rg = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string cpf = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            string[] dados = new string[] { id,nome,end,rg,cpf };
            frmCadastro frm = new frmCadastro(dados);
            frm.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            listUsers();
        }

        private void btnbusca_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();

            string campo = "";

            if (cbxPesquisa.Text == "Nome")
            {
                campo = "nome";
            }
            
            if (cbxPesquisa.Text == "RG")
            {
                campo = "rg";
            }
            if (cbxPesquisa.Text == "CPF")
            {
                campo = "cpf";
            }

            string query = "SELECT * FROM cadastrar WHERE " + campo + " LIKE '" + txtpesquisa.Text + "%'";

            if (cbxPesquisa.Text == "Endereço")
            {
                query = "SELECT * FROM cadastrar WHERE endereco LIKE '%" + txtpesquisa.Text + "%'";
            }
            if (cbxPesquisa.Text == "Sobrenome")
            {
                query = "SELECT * FROM cadastrar WHERE nome LIKE '%" + txtpesquisa.Text + "%'";
            }
            if (cbxPesquisa.Text == "Código")
            {
                query = "SELECT * FROM cadastrar WHERE id = '" + txtpesquisa.Text + "'";
            }


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            // MySqlDataAdapter adapter = new MySqlDataAdapter(commandDatabase);
            // DataTable data = new DataTable();
            // adapter.Fill(data);

            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                // Conectado com sucesso, agora lista os resgistro

                // Se existem registros...
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Mostra os registros na listView1
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4) };
                        var listViewItem = new ListViewItem(row);
                        dataGridView1.Rows.Add(row);

                    }
                }
                else
                {
                    // Caso não haja registros
                    Console.WriteLine("Nenhum registro encontrado.");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
    }
}
