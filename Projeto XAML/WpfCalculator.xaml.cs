using System;
using System.Data;
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
using System.Windows.Shapes;

namespace Projeto_XAML
{
    /// <summary>
    /// Lógica interna para WpfCalculator.xaml
    /// </summary>
    public partial class WpfCalculator : Window
    {
        String op;




        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            op += "1 ";
            ReloadMain(op);
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            op += "2 ";
            ReloadMain(op);
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            op += "3 ";
            ReloadMain(op);

        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            op += "4 ";
            ReloadMain(op);

        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            op += "5 ";
            ReloadMain(op);

        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            op += "6 ";
            ReloadMain(op);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            op += "7 ";
            ReloadMain(op);
            ReloadMain(op);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            op += "8 ";
            ReloadMain(op);

        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            op += "9 ";
            ReloadMain(op);
        }
        private void ReloadMain(string message)
        {
            BxBig.Text = message;
        }
        private void ReloadSmall(string message)
        {
            BxSmall.Text = message;
        }

        private void BtnMulti_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEq_Click(object sender, RoutedEventArgs e)
        {
            var result = new DataTable().Compute(op, null);
            MessageBox.Show(result.ToString());


        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEq_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
