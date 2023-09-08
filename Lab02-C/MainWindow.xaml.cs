using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab02_C
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void IniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            // Aquí puedes agregar la lógica para validar las credenciales del usuario.
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Password;

            // Ejemplo de validación simple (debes implementar una lógica más segura).
            if (usuario == "usuario" && contraseña == "contraseña")
            {
                Window1 window1 = new Window1();
                this.Close();
                window1.Show();
            }
            else
            {
                MessageBox.Show("Inicio de sesión fallido. Verifica tus credenciales.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
