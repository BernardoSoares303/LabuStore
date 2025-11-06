using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_MS;

namespace LabuStore
{
    public partial class Cadastrar_Labubus : Form
    {
        Labubu labubu = new Labubu();

        static string conexao = "Server=127.0.0.1;Port=3306;Database=LabuStore;Uid=root;Pwd='' ;"; // trocar a porta de 3307 para 3306 no senai

        public Cadastrar_Labubus()
        {
            InitializeComponent();
        }

        private void Cadastrar_Labubus_Load(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Labubus_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nome_text_TextChanged(object sender, EventArgs e)
        {
            labubu.nome_labubu = nome_text.Text;
        }

        private void valor_text_TextChanged(object sender, EventArgs e)
        {
            labubu.valor_labubu = double.Parse(valor_text.Text);
        }

        private void quantidade_text_TextChanged(object sender, EventArgs e)
        {
            labubu.quantidade_labubu = int.Parse(quantidade_text.Text);
        }
        private void link_text_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = link_text.Text;
            labubu.imagem_labubu = link_text.Text;

        }
        private void Cadastrar_Labubu_Click(object sender, EventArgs e)
        {
            inserir_labubu(labubu);
            
        }

        static void inserir_labubu(Labubu l1)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                string query = @$"insert into labubus (nome_labubu, valor_labubu, quantidade_labubu, imagem_labubu) values (@nome_labubu, @valor_labubu, @quantidade_labubu, @imagem_labubu);";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nome_labubu", l1.nome_labubu);
                cmd.Parameters.AddWithValue("@valor_labubu", l1.valor_labubu);
                cmd.Parameters.AddWithValue("@quantidade_labubu", l1.quantidade_labubu);
                cmd.Parameters.AddWithValue("@imagem_labubu", l1.imagem_labubu);

                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }


    }

}
