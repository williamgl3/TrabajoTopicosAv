using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrediTecTA
{
    public partial class ImprimirCons : Form
    {
        public ImprimirCons()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // Creamos un nuevo hilo para ejecutar el proceso en segundo plano
            Thread hiloProceso = new Thread(ProcesoLargo);
            hiloProceso.Start();
        }
        private void ProcesoLargo()
        {
            // Simulamos un proceso largo (en este caso, simplemente dormimos el hilo durante 5segundos)
            for (int i = 0; i <= 100; i++)
            {
                // Actualizamos el progreso y el contador en cada iteración
                this.Invoke((MethodInvoker)delegate {
                    progressBar1.Value = i;
                    txtContador.Text = i.ToString();
                });
                // Dormimos el hilo por un breve período para simular el proceso
                Thread.Sleep(10);
            }
                // Después de terminar el proceso, actualizamos el cuadro de texto en el hilo de lainterfaz de usuario
               // para mostrar que el proceso ha finalizado
                this.Invoke((MethodInvoker)delegate {
                MessageBox.Show("Proceso completado!");
                this.Close();
               });
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
 