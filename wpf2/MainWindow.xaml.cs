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

namespace wpf2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            artibutes.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            artibutes.DefaultDrawingAttributes.Color = Colors.LightSkyBlue;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            artibutes.DefaultDrawingAttributes.Color = Colors.GreenYellow;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            artibutes.DefaultDrawingAttributes.Color = Colors.Yellow;
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            artibutes.DefaultDrawingAttributes.Color = Colors.White;
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            artibutes.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            artibutes.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            artibutes.EditingMode = InkCanvasEditingMode.Select;
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            artibutes.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            artibutes.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(null != slider && draw != null)
            {
                draw.Height = slider.Value;
                draw.Width = slider.Value;
            }
        }
    }
}
