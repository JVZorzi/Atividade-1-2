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

namespace Projeto_XAML
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string user, password;
            user = UserBx.Text.ToString();
            password = PasswordBx.Password.ToString();
            if (user.ToUpper() == "ZORZI" && password.ToUpper() == "ZORZI123")
            {
                MessageBox.Show("Logado...", "Informações de Login", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                var calc = new Window1();
                this.Close();
                calc.Show();
            }
            else MessageBox.Show("Usuário ou senha Incorretos", "Alerta!!!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
