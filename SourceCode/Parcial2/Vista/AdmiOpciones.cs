using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class AdmiOpciones : Form
    {
        private Usuario pUsuario;
        public AdmiOpciones(Usuario u)
        {
            InitializeComponent();
            pUsuario = u;
        }
       // Boton usuario
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            fmrPrincipal ventana = new fmrPrincipal(pUsuario);
            ventana.Show();
            
        }
        //Boton Productos
        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos ventana = new Productos();
            ventana.Show();
        }
        
       //Boton Negocios
        private void btnNegocios_Click(object sender, EventArgs e)
        {
            Negocios ventana = new Negocios();
            ventana.Show();
            
        }
      
      //Boton Ordenes
        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            OrdenesPedidas ventana = new OrdenesPedidas();
            ventana.Show();
        }
    }
}