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
    
    public partial class Creditos : Form
    {
        
        public Creditos()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)  
        {
            if (Catalogo.totalCreditos == 5)
            {
                MessageBox.Show("¡Felicidades! Acompletaste todos tus creditos.");
            }
            MessageBox.Show("Creditos totales: " + Catalogo.totalCreditos.ToString());
            
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ImprimirCons imprimir = new ImprimirCons(); 
            imprimir.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
