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
            this.FormClosing += TelaPrincipal_FormClosing;
        }
    }
}
