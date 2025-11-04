using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;

namespace Trabalho_MS
{
    public partial class TelaLogin : Form
    {
        static string conexao = "Server=127.0.0.1;Port=3306;Database=LabuStore;Uid=root;Pwd='' ;"; // trocar a porta de 3307 para 3306 no senai

        string usuario;
        string senhacrip;
        string senha;

        private void TelaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public TelaLogin()
        {
            InitializeComponent();
            this.FormClosing += TelaLogin_FormClosing; // talvez tenho que remover para evitar bugs
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
            usuario = textUsuario.Text;
        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {
            senha = textUsuario.Text;
            senhacrip = ComputeHash(senha, SHA256.Create());
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (ValidarLogin(usuario, senhacrip) == 1)
            {
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                telaPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalidos!");
                textUsuario.Text = "Usuario:";
                textSenha.Text = "Senha:";
            }
        }
        public static string ComputeHash(string input, HashAlgorithm algorithm)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = algorithm.ComputeHash(inputBytes);

            // Converte bytes para string hexadecimal
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }

        static int ValidarLogin(string usuario, string senha)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                string querySelect = @$"select count(id_usuario) from usuarios where nome_usuario = '{usuario}' and senha_usuario = '{senha}';";

                using (MySqlCommand cmd = new MySqlCommand(querySelect, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    conn.Close();
                    return count;
                }
            }
        }
    }
}
