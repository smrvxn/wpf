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

namespace wpf1
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
            MessageBox.Show("Семерова Дарья пр-31","О разработчике");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            
            phon.Background = new SolidColorBrush(Colors.LightGreen);

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            phon.Background = new SolidColorBrush(Colors.LightPink);
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            phon.Background = new SolidColorBrush(Colors.LightYellow);
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Menu_MouseEnter(object sender, MouseEventArgs e)
        {
            strsost.Text = "Меню";
        }

        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            strsost.Text = "Изменить фон";
        }

        private void MenuItem_MouseEnter_1(object sender, MouseEventArgs e)
        {
            strsost.Text = "Посмотреть информацию о разработчике";
        }

        private void MenuItem_MouseEnter_2(object sender, MouseEventArgs e)
        {
            strsost.Text = "Закрыть окно";
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            strsost.Text = "Изменить цвет фона на зеленый";
        }

        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {
            strsost.Text = "Изменить цвет фона на розовый";
        }

        private void Button_MouseEnter_2(object sender, MouseEventArgs e)
        {
            strsost.Text = "Изменить цвет фона на желтый";
        }

        private void StatusBar_MouseEnter(object sender, MouseEventArgs e)
        {
            strsost.Text = "Строка состояния";
        }

        private void StatusBar_MouseLeave(object sender, MouseEventArgs e)
        {
            strsost.Text = "";
        }
    }
}
