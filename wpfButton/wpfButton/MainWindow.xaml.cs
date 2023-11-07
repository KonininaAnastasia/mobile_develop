using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lbLogs.Items.Add("Button_Click");
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            lbLogs.Items.Add("RepeatButton_Click");
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            var x = (e.Source as ToggleButton)?.IsChecked;
            lbLogs.Items.Add($"ToggleButton_Click : {x}");
        }
    }
}
