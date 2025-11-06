using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        static void inserir_labubu(Labubu l1)
        {

        }


    }

}
