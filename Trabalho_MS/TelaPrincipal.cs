using LabuStore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_MS
{
    public partial class TelaPrincipal : Form
    {
        private void TelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public TelaPrincipal()
        {
            InitializeComponent();
            this.FormClosing += TelaPrincipal_FormClosing; // teste
        }

        private void Ver_Labubu_Click(object sender, EventArgs e)
        {

        }

        private void Editar_Labubu_Click(object sender, EventArgs e)
        {
            Editar_Labubu editar_Labubu = new Editar_Labubu(); 
            this.Hide();
            editar_Labubu.Show();
        }

        private void Cadastrar_Labubu_Click(object sender, EventArgs e)
        {
            Cadastrar_Labubus cadastrar_Labubus = new Cadastrar_Labubus();
            this.Hide();
            cadastrar_Labubus.Show();
        }
    }
}
