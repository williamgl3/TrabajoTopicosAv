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
            IniciarNuevoFormulario(new RegistroUsuario());
        }

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            IniciarNuevoFormulario(new Catalogo());
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            IniciarNuevoFormulario(new InicioSesion());
        }

        private void BtnActiviades_Click(object sender, EventArgs e)
        {
            IniciarNuevoFormulario(new Actividades());
        }

        private void BtnCreditos_Click(object sender, EventArgs e)
        {
            IniciarNuevoFormulario(new Creditos());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelMenu_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void IniciarNuevoFormulario(Form form)
        {
            Thread thread = new Thread(() =>
            {
                form.StartPosition = FormStartPosition.CenterScreen;
                form.FormClosed += (s, args) => Application.ExitThread(); // Cerrar el hilo cuando el formulario se cierra
                Application.Run(form);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}