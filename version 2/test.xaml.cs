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

namespace version_2
{
    /// <summary>
    /// Логика взаимодействия для test.xaml
    /// </summary>
    public partial class test : UserControl
    {
        public test()
        {
            InitializeComponent();
        }

        private void Articul_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(ID.Content) == 1) MessageBox.Show("Правильный ответ"); else MessageBox.Show("Не правильный ответ");
        }

        private void Materials_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(ID.Content) == 2) MessageBox.Show("Правильный ответ"); else MessageBox.Show("Не правильный ответ");
        }

        private void Cost_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(ID.Content) == 3) MessageBox.Show("Правильный ответ"); else MessageBox.Show("Не правильный ответ");
        }
    }
}
