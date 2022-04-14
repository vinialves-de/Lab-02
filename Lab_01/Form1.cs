using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btExibir_Click(object sender, EventArgs e)
        {
 
      lblMensagem.Text = "ola, " + tbNome.Text + "\n bem vindo(a) ao seu curso de " + cbCurso.Text;


        }

        private void lblMensagem_Click(object sender, EventArgs e)
        {

        }
    }
}
