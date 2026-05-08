using src.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace src.Vista
{
    public partial class FormCrearInvitado : BaseMaterialForm
    {
        private readonly UsuarioControlador _usuarioControlador;
        public FormCrearInvitado()
        {
            InitializeComponent();
            _usuarioControlador = new UsuarioControlador();
        }

        private void FormCrearInvitado_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (txtTelefono.ToString().Length > 10)
            {
                MessageBox.Show("Haz alcanzado el limite de caracteres para el número de telefono.",
                    "Longitud inadecuada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtEdad.ToString().Length > 2)
            {
                MessageBox.Show("Haz alcanzado el limite de caracteres para la edad.",
                    "Longitud inadecuada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtCedula.ToString().Length > 10)
            {
                MessageBox.Show("Haz alcanzado el limite de caracteres para el número de cedula.",
                    "Longitud inadecuada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                bool ok = _usuarioControlador.CrearNuevoInvitado(txtNombre.Text, cbGenero.Text, txtEmail.Text, long.Parse(txtTelefono.Text), int.Parse(txtEdad.Text), int.Parse(txtCedula.Text), txtPassword.Text);
                if (ok)
                {
                    this.Close();
                }
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cancelar la creación del usuario?", "Volver al menú anterior", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
                MessageBox.Show("Solo se permite valores númericos", 
                    "Campo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permite valores númericos",
                    "Campo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permite valores númericos",
                    "Campo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
