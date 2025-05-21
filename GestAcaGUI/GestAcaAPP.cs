using GestAca.Services;

namespace GestAcaGUI
{
    public partial class GestAcaAPP : Form
    {
        IGestAcaService service { get; set; }


        public GestAcaAPP(IGestAcaService service)
        {
            this.service = service;
            //gestAcaService.DBInitialization();
            InitializeComponent();




            //gestAcaService.DBInitialization();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            var frmGestAcaAPPUser = new GestAcaAPPUser(this.service);
            frmGestAcaAPPUser.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var frmGestAcaAPPAdmin = new GestAcaAPPAdmin(this.service);
            (string username, string password) = UserPassword.ShowDialog("Inicio de sesión");
            if (username == "admin" && password == "admin")
            {
                frmGestAcaAPPAdmin.ShowDialog();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos.");
                return;
            }

        }

        private void btnUser_MouseEnter(object sender, EventArgs e)
        {
            btnUser.BackColor = Color.Brown;
            btnUser.ForeColor = Color.White;
        }

        private void btnUser_MouseLeave(object sender, EventArgs e)
        {
            btnUser.BackColor = Color.White;
            btnUser.ForeColor = Color.Brown;
        }

        private void btnAdmin_MouseEnter(object sender, EventArgs e)
        {
            btnAdmin.BackColor = Color.Brown;
            btnAdmin.ForeColor = Color.White;
        }

        private void btnAdmin_MouseLeave(object sender, EventArgs e)
        {
            btnAdmin.BackColor = Color.White;
            btnAdmin.ForeColor = Color.Brown;
        }

        /// <summary>
        /// Cargar la imagen al iniciar la aplicación.
        /// </summary>
        private void GestAcaAPP_Load(object sender, EventArgs e)
        {
            try
            {
                string imageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRY40iR5-q_VCxLqrOqxz0Sy66K0seylQzE5w&s"; // URL de la imagen
                pictureBoxImage.Load(imageUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen. Verifique la URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    public static class UserPassword
    {
        public static (string, string) ShowDialog(string caption)
        {
            Form prompt = new Form
            {
                Width = 500,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            // Etiquetas
            Label userLabel = new Label { Left = 50, Top = 20, Text = "Usuario:", Width = 400 };
            Label passwordLabel = new Label { Left = 50, Top = 70, Text = "Contraseña:", Width = 400 };

            // Campos de texto
            TextBox userTextBox = new TextBox { Left = 50, Top = 40, Width = 400 };
            TextBox passwordTextBox = new TextBox { Left = 50, Top = 90, Width = 400, PasswordChar = '*' };

            // Botón de confirmación
            Button confirmation = new Button
            {
                Text = "Confirmar",
                Left = 350,
                Width = 100,
                Top = 130,
                DialogResult = DialogResult.OK
            };

            // Agregar controles al formulario
            prompt.Controls.Add(userLabel);
            prompt.Controls.Add(userTextBox);
            prompt.Controls.Add(passwordLabel);
            prompt.Controls.Add(passwordTextBox);
            prompt.Controls.Add(confirmation);

            prompt.AcceptButton = confirmation;

            // Mostrar el formulario y devolver los valores ingresados
            if (prompt.ShowDialog() == DialogResult.OK)
            {
                return (userTextBox.Text, passwordTextBox.Text);
            }
            else
            {
                return (null, null);
            }
        }
    }
}
