using src.Controlador;
using System;
using System.Windows.Forms;

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
            // Leemos los campos numéricos como texto para validar vacío y longitud antes de parsear.
            string telefonoTxt = (txtTelefono.Text ?? string.Empty).Trim();
            string edadTxt = (txtEdad.Text ?? string.Empty).Trim();
            string cedulaTxt = (txtCedula.Text ?? string.Empty).Trim();

            // Validaciones de longitud máxima antes de parsear.
            if (telefonoTxt.Length > 10)
            {
                MessageBox.Show("Haz alcanzado el limite de caracteres para el número de telefono.",
                    "Longitud inadecuada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (edadTxt.Length > 2)
            {
                MessageBox.Show("Haz alcanzado el limite de caracteres para la edad.",
                    "Longitud inadecuada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cedulaTxt.Length > 10)
            {
                MessageBox.Show("Haz alcanzado el limite de caracteres para el número de cedula.",
                    "Longitud inadecuada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TryParse evita crash si el campo está vacío o tiene texto pegado.
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

            // Delegamos validaciones de negocio y guardado al Controlador.
            bool ok = _usuarioControlador.CrearNuevoInvitado(
                txtNombre.Text, cbGenero.Text, txtEmail.Text,
                telefono, edad, cedula, txtPassword.Text);

            if (ok)
                this.Close();
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
        }

        // Bloquea caracteres no numéricos en campos que solo aceptan números.
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