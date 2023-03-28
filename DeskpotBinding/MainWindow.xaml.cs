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

namespace DeskpotBinding
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (same.IsChecked == true)
            {
                System.Windows.Data.Binding binding = new System.Windows.Data.Binding();
                binding.Path = new PropertyPath("Value");
                binding.Mode = BindingMode.Default;

                binding.Source = slider1;
                slider2.SetBinding(Slider.ValueProperty, binding);
            }
            else if (same.IsChecked == false)
            {

                BindingOperations.ClearBinding(slider2, Slider.ValueProperty);
                slider2.Value = slider1.Value;
            }
        }
    }
}
