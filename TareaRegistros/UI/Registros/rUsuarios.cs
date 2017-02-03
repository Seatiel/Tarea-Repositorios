using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TareaRegistros.BLL;
using TareaRegistros.Entidades;

namespace TareaRegistros.UI.Registros
{
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private Usuarios LlenarCampos()
        {
            var usuarios = new Usuarios();
            usuarios.NombreUsuario = NombreUsuariostextBox.Text;
            usuarios.Clave = ClavetextBox.Text;
            return usuarios;
        }

        public void Limpiar()
        {
            UsuarioIdtextBox.Clear();
            NombreUsuariostextBox.Clear();
            ClavetextBox.Clear();
            ConfirmarClavetextBox.Clear();
        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(NombreUsuariostextBox.Text))
            {
                NombreUsuarioerrorProvider.SetError(NombreUsuariostextBox, "Debe introducir el Nombre del Usuario");
                if (string.IsNullOrEmpty(ClavetextBox.Text))
                {
                    ClaveerrorProvider.SetError(ClavetextBox, "Debe introducir la Contraseña");
                    if (string.IsNullOrEmpty(ConfirmarClavetextBox.Text))
                    {
                        ConfirmarClaveerrorProvider.SetError(ConfirmarClavetextBox, "Debe introducir la Contraseña de confirmacion");
                    }
                }
                retorno = false;
            }
            return retorno;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }        

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var usuario = new Usuarios();            
            usuario = LlenarCampos();
            if (ClavetextBox.Text == ConfirmarClavetextBox.Text)
            {
                if (!Validar())
                {
                    MessageBox.Show("Debe llenar los Campos vacios");
                }
                else 
                if(UsuariosBLL.Guardar(usuario))
                {
                    MessageBox.Show("El usuario ha sido Guardado.");
                }
                Limpiar();                
            }
            else
            {
                MessageBox.Show("La Contraseña es incorrecta, vuelva a intentarlo.");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var usuario = UsuariosBLL.Buscar(Utilitarios.ToInt(UsuarioIdtextBox.Text));
            if (usuario != null)
            {
                if (UsuariosBLL.Eliminar(usuario))
                    MessageBox.Show("La factoria ha sido eliminada");
            }
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UsuarioIdtextBox.Text))
            {
                int id = Convert.ToInt32(UsuarioIdtextBox.Text);
                var usuario = UsuariosBLL.Buscar(id);
                if (usuario != null)
                {
                    NombreUsuariostextBox.Text = usuario.NombreUsuario;
                }
                else
                {
                    MessageBox.Show("El usuario no esta creado.");
                }
            }            
        }
    }
}
