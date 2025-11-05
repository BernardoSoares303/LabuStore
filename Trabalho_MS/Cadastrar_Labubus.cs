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

        private void link_text_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = link_text.Text;
        }
    }
}
