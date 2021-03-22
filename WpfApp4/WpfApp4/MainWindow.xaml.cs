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

namespace WpfApp4
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

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            Canv.LayoutTransform = new ScaleTransform(1, 1);
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            Canv.LayoutTransform = new ScaleTransform(2, 2);
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            Canv.LayoutTransform = new ScaleTransform(3, 3);
        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {
            Canv.LayoutTransform = new ScaleTransform(4, 4);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            System.Drawing.Color color = System.Drawing.Color.White;
            System.Windows.Forms.ColorDialog colorDialog = new System.Windows.Forms.ColorDialog();
            if(colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = colorDialog.Color;
            }
            Color color1 = Colors.White;
            color1.R = color.R;
            color1.G = color.G;
            color1.B = color.B;
            color1.A = color.A;
            Brush brush = new SolidColorBrush(color1);
            Pack.Fill = brush;
        }
    }
}
