using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace Geometry1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        public EllipseGeometry pe;
        public MainWindow()
        {
            
            InitializeComponent();
            
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                MessageBox.Show("Введiть данi!!!!!!!");
            }

            else
            {
                Window1 w1 = new Window1();
                w1.Show();
                Window2 w2 = new Window2();
                w2.Show();
                Window3 w3 = new Window3();
                w3.Show();
                Window4 w4 = new Window4();
                w4.Show();
            }


        }
    }
}
