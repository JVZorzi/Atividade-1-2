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
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        string op;
        public Window1()
        {
            InitializeComponent();
        }



        private void ReloadMain(string message)
        {
            BxBig.Text = message;
        }
        private void ReloadSmall(string message)
        {
            BxSmall.Text = message;
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            op += "7";
            ReloadMain(op);
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            op += "8";
            ReloadMain(op);
        }

        private void Btn9_Click_1(object sender, RoutedEventArgs e)
        {
            op += "9";
            ReloadMain(op);
        }

        private void Btn4_Click_1(object sender, RoutedEventArgs e)
        {
            op += "4";
            ReloadMain(op);
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            op += "5";
            ReloadMain(op);
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            op += "6";
            ReloadMain(op);
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            op += "1";
            ReloadMain(op);
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            op += "2";
            ReloadMain(op);
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            op += "3";
            ReloadMain(op);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            op += "0";
            ReloadMain(op);
        }

        private void BtnEq_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(op, null);
                BxBig.Text = "= " + result.ToString();
                BxSmall.Text = BxBig.Text;
                BxSmall.Text = op;
                op = result.ToString();
            }
            catch{ MessageBox.Show("Insira uma operação válida!!");
                BtnCE_Click(sender,e);
            }
            


        }

        private void BtnCE_Click(object sender, RoutedEventArgs e)
        {
            op = "";
            ReloadSmall("Sua operação aparecerá aqui...");
            ReloadMain("0");
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            op += " - ";
            ReloadMain(op);
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            op += " + ";
            ReloadMain(op);
        }

        private void BtnMulti_Click(object sender, RoutedEventArgs e)
        {
            op += " * ";
            ReloadMain(op);
        }

        private void BtnDivi_Click(object sender, RoutedEventArgs e)
        {
            op += " / ";
            ReloadMain(op);
        }

        private void BtnClose(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void BtnMinimize(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        protected override void OnMouseRightButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseRightButtonDown(e);

            WindowStyle = WindowStyle.SingleBorderWindow;
            WindowState = WindowState.Minimized;
        }

        private void RowDefinition_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("opah");
        }
    }
    } 
    
    
    

    

