using System;
using System.Windows;
using System.Windows.Controls;

namespace Actividad7_UT2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mediumRadioButton.IsChecked = true;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoTextBlock.FontSize = Convert.ToInt32((sender as RadioButton).Tag.ToString());
        }
    }
}
