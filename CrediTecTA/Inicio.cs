using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BibliotecaCreditec;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace CrediTecTA
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }



        private static void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }




        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RegistroUsuario());
        }

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Catalogo());
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioSesion());

        }
        private void AbrirFormEnPanel(System.Windows.Forms.Form formHijo)
        {
            // Si hay algún control dentro del panel, quítalo
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            // Establece algunas propiedades del formulario hijo para que se ajuste al panel
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            // Agrega el formulario hijo al panel
            this.panelContenedor.Controls.Add(formHijo);

            // Almacena el formulario hijo en la propiedad Tag del panel (puedes usarlo para referenciarlo más tarde si es necesario)
            this.panelContenedor.Tag = formHijo;

            // Muestra el formulario hijo dentro del panel
            formHijo.Show();
        }

        private void BtnActiviades_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Actividades());
        }

        private void BtnCreditos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Creditos());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}