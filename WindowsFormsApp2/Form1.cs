using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmLoggin : Form
    {
        Usuarios usuarios = new Usuarios();
        public frmLoggin()
        {
            InitializeComponent();
        }

        private void frmLoggin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txbUsuario.Text;
            string password = txbContra.Text;


            var lista = usuarios.ObtenerUsuarios();
            var validar = lista.FirstOrDefault(u => u.NombreUsuario == user && u.Contraseña == password);
            if (validar != null)
            {
                this.Hide();
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Fallaste...");
            }
        }
    }
}
