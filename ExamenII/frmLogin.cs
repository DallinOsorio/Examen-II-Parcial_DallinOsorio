using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenII
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void Ingresarbutton_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(UsuariotextBox.Text, ContraseñatextBox.Text);

            if (usuario == null)
            {
                MessageBox.Show("Datos Erroneos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);



                return;
            }

            MessageBox.Show("Datos Ingresados Correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            frmProductos frmproductos = new frmProductos();
            frmproductos.Show();

        }
    }

}

