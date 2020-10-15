using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Geometry1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            Function();
        }
        public void Function()
        {

            Path p2 = new Path();
            p2.StrokeThickness = 2;
            p2.Stroke = System.Windows.Media.Brushes.Blue;
            p2.Fill = System.Windows.Media.Brushes.Blue;

            EllipseGeometry elf2 = new EllipseGeometry();
            elf2.RadiusX = 1;
            elf2.RadiusY = 1;
            elf2.Center = new Point(int.Parse(((MainWindow)Application.Current.MainWindow).textBox1.Text.ToString()), 0);
            p2.Data = elf2;
            MainCanvas2.Children.Add(p2);
            Path p1 = new Path();
            p1.StrokeThickness = 2;
            p1.Stroke = System.Windows.Media.Brushes.Blue;
            p1.Fill = System.Windows.Media.Brushes.Blue;

            EllipseGeometry elf1 = new EllipseGeometry();
            elf1.RadiusX = 1;
            elf1.RadiusY = 1;
            elf1.Center = new Point(int.Parse(((MainWindow)Application.Current.MainWindow).textBox2.Text.ToString()), 0);
            p1.Data = elf1;
            MainCanvas2.Children.Add(p1);
            double k = Math.Pow(Math.Abs(elf2.Center.X - elf1.Center.X), 2) / 4;
            for (int x = -400; x <= 400; x++)
            {
                for (int y = -225; y <= 225; y++)
                {
                    double s = Math.Sqrt(Math.Pow(elf2.Center.X - x, 2) + Math.Pow(elf2.Center.Y - y, 2)) * Math.Sqrt(Math.Pow(elf1.Center.X - x, 2) + Math.Pow(elf1.Center.Y - y, 2));
                    if (s < k)
                    {

                        Path p = new Path();
                        p.StrokeThickness = 2;
                        p.Stroke = System.Windows.Media.Brushes.Red;
                        p.Fill = System.Windows.Media.Brushes.Red;

                        EllipseGeometry elf = new EllipseGeometry();
                        elf.RadiusX = 1;
                        elf.RadiusY = 1;
                        elf.Center = new Point(x, y);
                        p.Data = elf;
                        MainCanvas2.Children.Add(p);
                    }
                }
            }
            Path p2n1 = new Path();
            p2n1.StrokeThickness = 2;
            p2n1.Stroke = System.Windows.Media.Brushes.Blue;
            p2n1.Fill = System.Windows.Media.Brushes.Blue;
            Path p2n2 = new Path();
            p2n2.StrokeThickness = 2;
            p2n2.Stroke = System.Windows.Media.Brushes.Blue;
            p2n2.Fill = System.Windows.Media.Brushes.Blue;
            p2n1.Data = elf1;
            MainCanvas2.Children.Add(p2n1);
            p2n2.Data = elf2;
            MainCanvas2.Children.Add(p2n2);
            Line l1 = new Line();
            l1.X1 = -400;
            l1.Y1 = 0;
            l1.X2 = 400;
            l1.Y2 = 0;
            l1.Stroke = Brushes.Black;
            Line l2 = new Line();
            l2.X1 = 0;
            l2.Y1 = -225;
            l2.X2 = 0;
            l2.Y2 = 225;
            l2.Stroke = Brushes.Black;
            MainCanvas2.Children.Add(l1);
            MainCanvas2.Children.Add(l2);

        }
    }
}
