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
using System.Windows.Shapes;

namespace Paint
{
    /// <summary>
    /// Логика взаимодействия для ToolsPanel.xaml
    /// </summary>
    public partial class ToolsPanel : Canvas
    {
        public MainWindow parent;
        public ToolsPanel()
        {
            InitializeComponent();
        }

        private void SetColor(Color color)
        {
            parent.inkCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void sliderWidth_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            parent.brushWidth = (float)e.NewValue * 6;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetColor(Colors.Red);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SetColor(Colors.Green);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SetColor(Colors.Blue);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SetColor(Colors.Brown);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SetColor(Colors.White);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SetColor(Colors.Black);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            SetColor(Colors.Gray);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            SetColor(Colors.LightBlue);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            SetColor(Colors.LightGreen);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            SetColor(Colors.Yellow);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            SetColor(Colors.Cyan);
        }
    }
}
