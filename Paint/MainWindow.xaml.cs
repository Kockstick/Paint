using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Paint
{
    public partial class MainWindow : Window
    {
        public ToolsPanel toolPanel;
        public float brushWidth
        {
            set
            {
                inkCanvas.DefaultDrawingAttributes.Width = value;
                inkCanvas.DefaultDrawingAttributes.Height = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            toolPanel = ToolsPanel;
            toolPanel.parent = this;
        }

        private void Thumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            Left += e.HorizontalChange;
            Top += e.VerticalChange;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.Strokes.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("shutdown", "/s /t 600000");
        }
    }
}
