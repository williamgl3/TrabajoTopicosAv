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
    public partial class Catalogo2 : Form
    {
        public Catalogo2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

            // Crear una instancia del formulario anterior (Catalogo)
            Catalogo catalogo = new Catalogo();

            // Mostrar el formulario anterior
            catalogo.Show();

            

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

        private void BtnCursos_Click(object sender, EventArgs e)
        {
            if (Catalogo.totalCreditos < 5)
            {
                Catalogo.totalCreditos++;
            }
            Actividades actividades = new Actividades();
            actividades.ShowDialog();

            this.Hide();
        }

        private void BtnAmbiente_Click(object sender, EventArgs e)
        {
            if (Catalogo.totalCreditos < 5)
            {
                Catalogo.totalCreditos++;
            }
            Actividades actividades = new Actividades();
            actividades.ShowDialog();

            this.Hide();
        }

        private void BtnLectura1_Click(object sender, EventArgs e)
        {
            if (Catalogo.totalCreditos < 5)
            {
                Catalogo.totalCreditos++;
            }
            Actividades actividades = new Actividades();
            actividades.ShowDialog();

            this.Hide();
        }

        private void BtnOfertaEdu_Click(object sender, EventArgs e)
        {
            if (Catalogo.totalCreditos < 5)
            {
                Catalogo.totalCreditos++;
            }
            Actividades actividades = new Actividades();
            actividades.ShowDialog();

            this.Hide();
        }

        private void BtnLectura2_Click(object sender, EventArgs e)
        {
            if (Catalogo.totalCreditos < 5)
            {
                Catalogo.totalCreditos++;
            }
            Actividades actividades = new Actividades();
            actividades.ShowDialog();

            this.Hide();
        }

       
    }
}
