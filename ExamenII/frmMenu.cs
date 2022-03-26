using Datos.Accesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExamenII
{
    public partial class frmMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        frmProductos frmProductos = null;
        frmPedidos frmPedidos = null;
        private void toolStripEx1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (frmProductos == null)
            {
                frmProductos = new frmProductos();
                frmProductos.MdiParent = this;
                frmProductos.FormClosed += FrmProductos_FormClosed;
                frmProductos.Show();
            }
            else
            {
                frmProductos.Activate();
            }
            

        }

        private void FrmProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmProductos = null;
        }

        private void toolStripEx2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
          
            if (frmPedidos == null)
            {
                frmPedidos = new frmPedidos();
                frmPedidos.MdiParent = this;
                frmPedidos.FormClosed += FrmProductos_FormClosed1;
                frmPedidos.Show();
            }
            else
            {
                frmPedidos.Activate();
            }
        }

        private void FrmProductos_FormClosed1(object sender, FormClosedEventArgs e)
        {
            frmPedidos = null;
        }
    }
}
