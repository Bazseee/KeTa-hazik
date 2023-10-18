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

namespace Palindrom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HatterBeallitas();
        }

        private void PalindromKereses_Click(object sender, RoutedEventArgs e)
        {
            kiIrasLista.Items.Clear();
            if (int.TryParse(szamBe.Text, out int n) && n > 0)
            {
                for (int i = 0; i <= n; i++)
                {
                    if (Palindrom_e(i))
                    {
                        kiIrasLista.Items.Add(i.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Kérem adjon meg 0-nál nagyobb N bemeneti számot!");
            }
        }

        private bool Palindrom_e(int szam)
        {
            string szamStr = szam.ToString();
            int i = 0;
            int j = szamStr.Length - 1;
            while (i < j)
            {
                if (szamStr[i] != szamStr[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }

        private void HatterBeallitas()
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush();
            gradientBrush.StartPoint = new Point(0, 0);
            gradientBrush.EndPoint = new Point(1, 1);
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromRgb(255, 0, 0), 0));
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromRgb(139, 0, 0), 1));
            Background = gradientBrush;
        }
    }
}
