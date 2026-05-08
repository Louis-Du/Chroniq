using src.Controlador;
using System;
using System.Windows.Forms;

namespace src.Vista
{
    // Formulario para registrar un nuevo usuario tipo Invitado en la base de datos.
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
            // Leemos los campos como string primero para validar vacío/longitud antes de parsear.
            string telefonoTxt = (txtTelefono.Text ?? string.Empty).Trim();
            string edadTxt     = (txtEdad.Text     ?? string.Empty).Trim();
            string cedulaTxt   = (txtCedula.Text   ?? string.Empty).Trim();

            // Validaciones de longitud máxima para dar retroalimentación clara al usuario.
            if (telefonoTxt.Length > 10)
            {
                MessageBox.Show("Has alcanzado el límite de caracteres para el número de teléfono.",
                    "Longitud inadecuada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (edadTxt.Length > 2)
            {
                MessageBox.Show("Has alcanzado el límite de caracteres para la edad.",
                    "Longitud inadecuada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cedulaTxt.Length > 10)
            {
                MessageBox.Show("Has alcanzado el límite de caracteres para el número de cédula.",
                    "Longitud inadecuada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TryParse es seguro: retorna false en lugar de lanzar excepción si el texto no es un número.
            if (!long.TryParse(telefonoTxt, out long telefono))
            {
                MessageBox.Show("Número de teléfono inválido.",
                    "Campo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(edadTxt, out int edad))
            {
                MessageBox.Show("Edad inválida.",
                    "Campo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cedulaTxt, out int cedula))
            {
                MessageBox.Show("Cédula inválida.",
                    "Campo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Delegamos las validaciones de negocio (duplicado de cédula, etc.) al Controlador.
            bool ok = _usuarioControlador.CrearNuevoInvitado(
                txtNombre.Text, cbGenero.Text, txtEmail.Text,
                telefono, edad, cedula, txtPassword.Text);

            // Solo cerramos si el controlador confirma que el usuario fue creado.
            if (ok) this.Close();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que deseas cancelar la creación del usuario?",
                "Volver al menú anterior", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sin restricción de caracteres en el email; la validación del formato la hace el controlador.
        }

        // Los tres métodos siguientes bloquean en tiempo real caracteres no numéricos en sus campos.
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten valores numéricos",
                    "Campo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten valores numéricos",
                    "Campo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten valores numéricos",
                    "Campo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
