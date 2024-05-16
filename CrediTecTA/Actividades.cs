using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaCreditec;

namespace CrediTecTA
{
    public partial class Actividades : Form
    {
        public Actividades()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRegresarInicio_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.ShowDialog();

            this.Hide();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Catalogo catalogo = new Catalogo();
            catalogo.ShowDialog();

            this.Hide();
        }

        private void BtnVerCred_Click(object sender, EventArgs e)
        {
            Creditos verCred = new Creditos();
            verCred.ShowDialog();

            this.Hide();
        }
    }
}
