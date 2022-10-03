using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listasdoblementeenlaadas2
{
    public partial class Form1 : Form
    {
        MiLista lista = new MiLista();
        public Form1()
        {
            InitializeComponent();
         
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo n = new Nodo();
            n.Dato = txtDato.Text;
            lista.Agregar(n);
            lbxDatos.Text = lista.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (lista.Buscar(txtDato.Text))
            {
                MessageBox.Show("Encontrado");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //string dato = (txtDato.Text);
            //lista.Borrar(dato);
            //lbxDatos.Text = lista.ToString();
            //txtDato.Clear();
        }
    }
}
