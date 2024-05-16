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
    public partial class Catalogo : System.Windows.Forms.Form
    {
        public Catalogo()
        {
            InitializeComponent();
        }

        private void BtnAsesorias2_Click(object sender, EventArgs e)
        {
            Actividades actividades = new Actividades();
            actividades.ShowDialog();

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Catalogo2 catalogo2 = new Catalogo2();

            // Mostrar el formulario anterior
            catalogo2.Show();
            this.Hide();
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

        private void BtnAsesorias1_Click(object sender, EventArgs e)
        {
            Actividades actividades = new Actividades();
            actividades.ShowDialog();

            this.Hide();
        }

        private void BtnTutorias_Click(object sender, EventArgs e)
        {
            Actividades actividades = new Actividades();
            actividades.ShowDialog();

            this.Hide();
        }

        private void BtnEventosAcad_Click(object sender, EventArgs e)
        {
            Actividades actividades = new Actividades();
            actividades.ShowDialog();

            this.Hide();
        }

        private void BtnProyectos_Click(object sender, EventArgs e)
        {
            Actividades actividades = new Actividades();
            actividades.ShowDialog();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
