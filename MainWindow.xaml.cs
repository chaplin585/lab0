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


namespace lab0
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        public void ButtonClick(object sender, RoutedEventArgs eventArgs)
        {
            Button? b = sender as Button;
            if(b != null)
            {
                RC.Fill = new SolidColorBrush(System.Windows.Media.Colors.Khaki);
            }
        }
        public void ButtonClick1(object sender, RoutedEventArgs eventArgs)
        {
            Button? b = sender as Button;
            if(b != null)
            {
                RC.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
            }
        }
        public void ButtonClick2(object sender, RoutedEventArgs eventArgs)
        {
            Button? b = sender as Button;
            if(b != null)
            {
                RC.Fill = new SolidColorBrush(System.Windows.Media.Colors.MediumVioletRed);
            }
        }
        public void ButtonClick3(object sender, RoutedEventArgs eventArgs)
        {
            Button? b = sender as Button;
            if(b != null)
            {
                RC.Fill = new SolidColorBrush(System.Windows.Media.Colors.Bisque);
            }
        }
        public void ButtonClick4(object sender, RoutedEventArgs eventArgs)
        {
            Button? b = sender as Button;
            if(b != null)
            {
                RC.Fill = new SolidColorBrush(System.Windows.Media.Colors.LemonChiffon);
            }
        }
        public void ButtonClick5(object sender, RoutedEventArgs eventArgs)
        {
            Button? b = sender as Button;
            if(b != null)
            {
                RC.Fill = new SolidColorBrush(System.Windows.Media.Colors.PowderBlue);
            }
        }
        public void ButtonClick6(object sender, RoutedEventArgs eventArgs)
        {
            Button? b = sender as Button;
            if(b != null)
            {
                RC.Fill = new SolidColorBrush(System.Windows.Media.Colors.MintCream);
            }
        }
        public void ButtonClick7(object sender, RoutedEventArgs eventArgs)
        {
            Button? b = sender as Button;
            if(b != null)
            {
                RC.Fill = new SolidColorBrush(System.Windows.Media.Colors.Maroon);
            }
        }
        public void ButtonClick8(object sender, RoutedEventArgs eventArgs)
        {
            Button? b = sender as Button;
            if(b != null)
            {
                RC.Fill = new SolidColorBrush(System.Windows.Media.Colors.RosyBrown);
            }
        }
        public void ButtonClick9(object sender, RoutedEventArgs eventArgs)
        {
            Button? b = sender as Button;
            if(b != null)
            {
                RC.Fill = new SolidColorBrush(System.Windows.Media.Colors.LightPink);
            }
        }
        
    }
}
