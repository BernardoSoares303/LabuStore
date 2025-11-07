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
    public partial class Editar_Labubu : Form
    {
        static string conexao = "Server=127.0.0.1;Port=3306;Database=LabuStore;Uid=root;Pwd='' ;";
        Labubu labubu = new Labubu();
        int id;
        public Editar_Labubu()
        {
            InitializeComponent();
        }

        private void Editar_Labubu_Load(object sender, EventArgs e)
        {

        }
        private void id_text_TextChanged(object sender, EventArgs e)
        {
            id = int.Parse(id_text.Text);
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

        private void Labubu_Editar_Click(object sender, EventArgs e)
        {
            Editar_Labubus(id, labubu);
            this.Close();
        }

        private void excluir_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este registro?","Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {

                    excluir_labubu(id);

                    MessageBox.Show("Registro excluído com sucesso!");
                    
                    this.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("erro ao cadastrar labubu: " + ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Operação cancelada.");
            }
         

        }

        static void Editar_Labubus(int id, Labubu l1)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string query = @"UPDATE labubus SET nome_labubu = @nome_labubu, valor_labubu = @valor_labubu, quantidade_labubu = @quantidade_labubu, imagem_labubu = @imagem_labubu WHERE id_labubu = @id_labubu;";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Parâmetros
                cmd.Parameters.AddWithValue("@nome_labubu", l1.nome_labubu);
                cmd.Parameters.AddWithValue("@valor_labubu", l1.valor_labubu);
                cmd.Parameters.AddWithValue("@quantidade_labubu", l1.quantidade_labubu);
                cmd.Parameters.AddWithValue("@imagem_labubu", l1.imagem_labubu);
                cmd.Parameters.AddWithValue("@id_labubu", id); // importante!

                int linhasAfetadas = cmd.ExecuteNonQuery(); // retorna quantas linhas foram alteradas

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Labubu atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado com esse ID.");
                }

                conn.Close();
            }
        }

        static void excluir_labubu(int id)
        {
            using (MySqlConnection coon = new MySqlConnection(conexao))
            {
                coon.Open();

                string query = @$"DELETE FROM labubus WHERE id_labubu = @id;";

                MySqlCommand cmd = new MySqlCommand(query, coon);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                coon.Close();
            }
        }

        private void Editar_Labubu_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipal tela = new TelaPrincipal();
            tela.Show();
        }

    }
}
